using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GenericBD
{
    internal partial class GenericData : IDisposable
    {
        private readonly string Connection;
        private OleDbConnection LongConnection;
        private OleDbTransaction TransactionConnection;

        internal GenericData(string connection)
        {
            Connection = connection;
        }

        public void Dispose() { EndTransaction(false); }

        internal void InitTransaction()
        {
            EndTransaction(false);
            LongConnection = new OleDbConnection(Connection);
            LongConnection.Open();
            TransactionConnection = LongConnection.BeginTransaction();
        }

        internal void EndTransaction(bool commit)
        {
            if (LongConnection != null)
            {
                if (commit)
                    TransactionConnection.Commit();
                else
                    TransactionConnection.Rollback();

                TransactionConnection.Dispose();
                TransactionConnection = null;
                LongConnection.Close();
                LongConnection.Dispose();
                LongConnection = null;
            }
        }

        internal void ChangeDB(string db)
        {
            if (LongConnection != null)
                LongConnection.ChangeDatabase(db);
        }

        internal int? Execute<T>(bool procedure, string sql, T parameters) where T : class
        {
            return ActionConnection((command) =>
            {
                if (parameters != null)
                    MapParameters(parameters, (PropertyInfo p) => { return true; }, ref command, procedure);

                var affect = command.ExecuteNonQuery();
                return affect;
            }, procedure, sql);
        }

        internal List<TR> ExecuteList<TR, TP>(bool procedure, string sql, TP parameters)
            where TR : class
            where TP : class
        {
            return ActionConnection((command) =>
            {
                if (parameters != null)
                    MapParameters(parameters, (PropertyInfo p) => { return true; }, ref command, procedure);

                var reader = command.ExecuteReader();
                var result = MapReaderToList<TR>(reader);
                return result;
            }, procedure, sql);
        }

        internal T ExecuteInsert<T>(T insert) where T : class
        {
            var attribute = typeof(T).GetCustomAttribute<BDProperties>()
                ?? throw new Exception("Attribute BDProperties not found");
            bool findAttrParamInsert(PropertyInfo p)
            {
                return FindAttr(p, nameof(BDProperties.Insert))
                    && !FindAttr(p, nameof(BDProperties.AutoIdentity));
            }
            bool findAttrParamIdentity(PropertyInfo p)
            {
                return FindAttr(p, nameof(BDProperties.AutoIdentity))
                    && FindAttr(p, nameof(BDProperties.Insert));
            }

            var root = attribute.Root is null ? typeof(T).Name : attribute.Root;
            var inserts = insert.GetType().GetProperties().Where(p => findAttrParamInsert(p)).ToList();
            var identys = insert.GetType().GetProperties().Select(p => GetAttrIdenty(p, false))
                .Where(p => p != null).ToList();
            var sqlParams = string.Join(",", inserts.Select(p => GetAttrName(p)));
            var sqlValues = string.Join(",", inserts.Select(p => "?"));
            var sqlIdentys = string.Join(" and ", identys);
            var setParamNames = false;

            return ActionConnection((command) =>
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"insert into {root}({sqlParams})");
                sql.AppendLine($"values({sqlValues})");
                MapParameters(insert, (PropertyInfo p) => { return findAttrParamInsert(p); }, ref command, setParamNames);
                sql.AppendLine($"select * from {root}");
                sql.AppendLine($"where {sqlIdentys}");
                MapParameters(insert, (PropertyInfo p) => { return findAttrParamIdentity(p); }, ref command, setParamNames);
                command.CommandText = sql.ToString();

                var reader = command.ExecuteReader();
                var result = MapReaderToSingle<T>(reader);

                return result;
            }, false, "");
        }

        internal T ExecuteUpdate<T>(T update) where T : class
        {
            var attribute = typeof(T).GetCustomAttribute<BDProperties>()
                ?? throw new Exception("Attribute BDProperties not found");
            bool findAttrParamUpdate(PropertyInfo p)
            {
                return FindAttr(p, nameof(BDProperties.Update))
                    && !FindAttr(p, nameof(BDProperties.AutoIdentity));
            }
            bool findAttrParamIdentity(PropertyInfo p)
            {
                return FindAttr(p, nameof(BDProperties.AutoIdentity))
                    && FindAttr(p, nameof(BDProperties.Update));
            }

            var root = attribute.Root is null ? typeof(T).Name : attribute.Root;
            var updates = update.GetType().GetProperties().Where(p => findAttrParamUpdate(p)).ToList();
            var identys = update.GetType().GetProperties().Select(p => GetAttrIdenty(p, true))
                .Where(p => p != null).ToList();
            var sqlValues = string.Join(",", updates.Select(p => $"{GetAttrName(p)} = ?"));
            var sqlIdentys = string.Join(" and ", identys);
            var setParamNames = false;

            return ActionConnection((command) =>
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"update {root}");
                sql.AppendLine($"set {sqlValues}");
                MapParameters(update, (PropertyInfo p) => { return findAttrParamUpdate(p); }, ref command, setParamNames);
                sql.AppendLine($"where {sqlIdentys}");
                MapParameters(update, (PropertyInfo p) => { return findAttrParamIdentity(p); }, ref command, setParamNames);
                sql.AppendLine($"select * from {root}");
                sql.AppendLine($"where {sqlIdentys}");
                MapParameters(update, (PropertyInfo p) => { return findAttrParamIdentity(p); }, ref command, setParamNames);
                command.CommandText = sql.ToString();

                var reader = command.ExecuteReader();
                var result = MapReaderToSingle<T>(reader);

                return result;
            }, false, "");
        }

        internal List<T> ExecuteTable<T>() where T : class
        {
            var attribute = typeof(T).GetCustomAttribute<BDProperties>()
                ?? throw new Exception("Attribute BDProperties not found");
            var root = attribute.Root is null ? typeof(T).Name : attribute.Root;
            return ActionConnection((command) =>
            {
                command.CommandText = root;
                command.CommandType = CommandType.TableDirect;
                var reader = command.ExecuteReader();
                var result = MapReaderToList<T>(reader);
                result.Reverse();

                return result;
            }, false, "");
        }

        internal TR ExecuteScalar<TR, TP>(bool procedure, string sql, TP parameters)
            where TP : class
        {
            return ActionConnection((command) =>
            {
                if (parameters != null)
                    MapParameters(parameters, (PropertyInfo p) => { return true; }, ref command, procedure);

                var result = (TR)Convert.ChangeType(command.ExecuteScalar(), typeof(TR));
                return result;
            }, procedure, sql);
        }

        internal int? ExecuteReturn<TP>(bool procedure, string sql, TP parameters)
            where TP : class
        {
            return ActionConnection((command) =>
            {
                if (parameters != null)
                    MapParameters(parameters, (PropertyInfo p) => { return true; }, ref command, procedure);
                var rtn = new OleDbParameter("ReturnValue", OleDbType.Integer);
                rtn.Direction = ParameterDirection.ReturnValue;
                command.Parameters.Add(rtn);

                command.ExecuteNonQuery();
                return (int)Convert.ChangeType(rtn.Value, typeof(int));
            }, procedure, sql);
        }

        internal TR ExecuteOutput<TR, TP>(bool procedure, string sql, TP parameters)
            where TP : class
        {
            return ActionConnection((command) =>
            {
                if (parameters != null)
                    MapParameters(parameters, (PropertyInfo p) => { return true; }, ref command, procedure);
                var rtn = new OleDbParameter("ReturnValue", OleDbType.Variant);
                rtn.Direction = ParameterDirection.Output;
                command.Parameters.Add(rtn);

                command.ExecuteNonQuery();
                return (TR)Convert.ChangeType(rtn.Value, typeof(TR));
            }, procedure, sql);
        }
    }

    internal partial class GenericData
    {
        private T ActionConnection<T>(Func<OleDbCommand, T> act, bool procedure, string sql)
        {
            OleDbCommand NewCommand(OleDbConnection cn)
            {
                OleDbCommand command = cn.CreateCommand();
                command.Transaction = TransactionConnection;
                command.CommandText = sql;
                command.CommandType = procedure ? CommandType.StoredProcedure : CommandType.Text;
                return command;
            };

            if (LongConnection is null)
            {
                using (var cn = new OleDbConnection(Connection))
                {
                    cn.Open();
                    var cmd = NewCommand(cn);
                    var res = act(cmd);
                    cn.Close();
                    return res;
                }
            }
            else
            {
                var cmd = NewCommand(LongConnection);
                return act(cmd);
            }
        }

        private bool FindAttr(PropertyInfo prop, string attrDBP)
        {
            var attr = prop.GetCustomAttribute<BDProperties>();
            if (attr is null) return false;
            var propAttr = attr.GetType().GetProperty(attrDBP);
            return attr != null && Convert.ToBoolean(propAttr.GetValue(attr));
        }

        private string GetAttrName(PropertyInfo obj, string prefijo = "")
        {
            var attr = obj.GetCustomAttribute<BDProperties>();
            return prefijo + ((attr != null && attr.Root != null) ? attr.Root : obj.Name);
        }

        private string GetAttrIdenty(PropertyInfo obj, bool compareSelf)
        {
            var attr = obj.GetCustomAttribute<BDProperties>();
            if (attr is null) return null;
            if (!attr.AutoIdentity) return null;
            var root = GetAttrName(obj);
            if (compareSelf)
                return $"{root} = ?";
            else
                return $"{root} = {(attr.Insert ? "?" : "@@identity")}";
        }

        private void MapParameters(object parameters, Func<PropertyInfo, bool> allowParameter, ref OleDbCommand command, bool setNames)
        {
            var props = parameters.GetType().GetProperties();
            foreach (var prop in props)
            {
                if (allowParameter(prop))
                {
                    OleDbParameter param = new OleDbParameter();
                    param.Value = prop.GetValue(parameters);
                    if (setNames)
                        param.ParameterName = $"@{prop.Name}";
                    if (param.Value is DateTime)
                        param.OleDbType = OleDbType.Date;
                    command.Parameters.Add(param);
                }
            }
        }

        private List<T> MapReaderToList<T>(IDataReader dr)
        {

            List<T> res = new List<T>();
            while (dr.Read())
            {
                var row = MapObject<T>(dr);
                res.Add(row);
            }

            return res;
        }

        private T MapReaderToSingle<T>(IDataReader dr)
        {
            T res = default;
            if (dr.Read())
                res = MapObject<T>(dr);

            return res;
        }

        private T MapObject<T>(IDataReader dr)
        {
            var res = Activator.CreateInstance<T>();
            var columns = Enumerable.Range(0, dr.FieldCount).Select(dr.GetName).ToList();
            foreach (string column in columns)
            {
                var prop = res.GetType().GetProperty(column);
                if (prop == null) continue;
                if (!Equals(dr[column], DBNull.Value) && prop.CanWrite)
                    prop.SetValue(res, dr[prop.Name], null);
            }

            return res;
        }
    }
}

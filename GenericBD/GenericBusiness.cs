using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GenericBD
{
    public partial class GenericBusiness : IDisposable
    {
        private string Connection;
        private GenericData LongConnection;

        public Error Error { get; set; }

        public GenericBusiness()
        {
            Error = new Error();
            Connection = ConfigurationManager.ConnectionStrings["local"].ConnectionString;
        }

        public GenericBusiness(string conecction)
        {
            Error = new Error();
            Connection = conecction;
        }

        public void Dispose() { EndTransaction(false); }

        public void InitTransaction()
        {
            EndTransaction(false);
            LongConnection = new GenericData(Connection);
            LongConnection.InitTransaction();
        }

        public void EndTransaction(bool commit)
        {
            if (LongConnection != null)
            {
                LongConnection.EndTransaction(commit);
                LongConnection.Dispose();
                LongConnection = null;
            }
        }

        public void ChangeDB(string db)
        {
            if (LongConnection != null)
                LongConnection.ChangeDB(db);
        }

        public int? Execute(string sql, object parameters = null)
        {
            return Execute(false, sql, parameters);
        }
        public int? Execute(Enum sql, object parameters = null)
        {
            return Execute(true, sql.ToString(), parameters);
        }

        public List<TR> ExecuteList<TR>(string sql, object parameters = null)
            where TR : class
        {
            return ExecuteList<TR, object>(false, sql, parameters);
        }
        public List<TR> ExecuteList<TR>(Enum sql, object parameters = null)
            where TR : class
        {
            return ExecuteList<TR, object>(true, sql.ToString(), parameters);
        }

        public TR ExecuteSingle<TR>(string sql, object parameters = null)
            where TR : class
        {
            return ExecuteSingle<TR, object>(false, sql, parameters);
        }
        public TR ExecuteSingle<TR>(Enum sql, object parameters = null)
            where TR : class
        {
            return ExecuteSingle<TR, object>(true, sql.ToString(), parameters);
        }

        public T ExecuteInsert<T>(T insert) where T : class
        {
            return Consumer((data) =>
            {
                var result = data.ExecuteInsert(insert);
                if (result == null)
                    Error.Set(1, $"{typeof(T).Name} not registered");
                return result;
            });
        }

        public T ExecuteUpdate<T>(T update) where T : class
        {
            return Consumer((data) =>
            {
                var result = data.ExecuteUpdate(update);
                if (result == null)
                    Error.Set(1, $"{typeof(T).Name} not updated");
                return result;
            });
        }

        public List<T> ExecuteTable<T>() where T : class
        {
            return Consumer((data) =>
            {
                List<T> result = data.ExecuteTable<T>();
                if (result == null)
                    Error.Set(1, $"{typeof(T).Name} not found");
                return result;
            });
        }

        public T ExecuteScalar<T>(string sql, object parameters = null)
        {
            return ExecuteScalar<T, object>(false, sql, parameters);
        }

        public T ExecuteScalar<T>(Enum sql, object parameters = null)
        {
            return ExecuteScalar<T, object>(true, sql.ToString(), parameters);
        }
        public int? ExecuteReturn(string sql, object parameters = null)
        {
            return ExecuteReturn(false, sql, parameters);
        }

        public int? ExecuteReturn(Enum sql, object parameters = null)
        {
            return ExecuteReturn(true, sql.ToString(), parameters);
        }

        public T ExecuteOutput<T>(Enum sql, object parameters = null)
        {
            return Consumer((data) =>
            {
                T result = data.ExecuteOutput<T, object>(true, sql.ToString(), parameters);
                if (result == null)
                    Error.Set(1, $"value not found");
                return result;
            });
        }

    }

    public partial class GenericBusiness
    {
        private T Consumer<T>(Func<GenericData, T> action)
        {
            try
            {
                var data = LongConnection ?? new GenericData(Connection);
                Error.Clear();
                return action(data);
            }
            catch (Exception ex)
            {
                Error.Set(1, ex.Message);
                return default;
            }
        }

        private int? Execute<T>(bool procedure, string sql, T parameters)
            where T : class
        {
            return Consumer((data) =>
            {
                var result = data.Execute(procedure, sql, parameters);
                if (result == null)
                    Error.Set(1, $"{sql} [Incompleted]");
                return result;
            });
        }

        private List<TR> ExecuteList<TR, TP>(bool procedure, string sql, TP parameters)
            where TR : class
            where TP : class
        {
            return Consumer((data) =>
            {
                var result = data.ExecuteList<TR, TP>(procedure, sql, parameters);
                if (result == null)
                    Error.Set(1, $"{sql} [Incompleted]");
                return result;
            });
        }

        private TR ExecuteSingle<TR, TP>(bool procedure, string sql, TP parameters)
            where TR : class
            where TP : class
        {
            return Consumer((data) =>
            {
                var result = data.ExecuteList<TR, TP>(procedure, sql, parameters);
                if (result == null)
                    Error.Set(1, $"{typeof(TR).Name} not found");
                return result.FirstOrDefault();
            });
        }

        public TR ExecuteScalar<TR, TP>(bool procedure, string sql, TP parameters)
            where TP : class
        {
            return Consumer((data) =>
            {
                TR result = data.ExecuteScalar<TR, TP>(procedure, sql, parameters);
                if (result == null)
                    Error.Set(1, $"value not found");
                return result;
            });
        }

        public int? ExecuteReturn<TP>(bool procedure, string sql, TP parameters)
            where TP : class
        {
            return Consumer((data) =>
            {
                int? result = data.ExecuteReturn(procedure, sql, parameters);
                if (result == null)
                    Error.Set(1, $"value not found");
                return result;
            });
        }
    }
}

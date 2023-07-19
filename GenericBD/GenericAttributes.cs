using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBD
{
    public class BDProperties : Attribute
    {
        public string Root;

        public bool AutoIdentity { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
    }
}

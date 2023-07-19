using GenericBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Tables
{
    [BDProperties(Root = "Concepts")]
    internal class Concept
    {
        [BDProperties(AutoIdentity = true, Update = true)]
        public int Id { get; set; }

        [BDProperties(Insert = true, Update = true)]
        public string Name { get; set; }
    }
}

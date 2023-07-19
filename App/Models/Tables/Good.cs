using GenericBD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Tables
{
    [BDProperties(Root = "Goods")]
    internal partial class Good
    {
        [BDProperties(AutoIdentity = true, Update = true)]
        public int Id { get; set; }

        [BDProperties(Insert = true, Update = true)]
        public string Brand { get; set; }

        [BDProperties(Insert = true, Update = true)]
        public string Category { get; set; }

        [BDProperties(Insert = true, Update = true)]
        public string Color { get; set; }

        [BDProperties(Insert = true, Update = true)]
        public decimal Cost { get; set; }

        [BDProperties(Insert = true, Update = true)]
        public decimal Price { get; set; }

        [BDProperties(Insert = true, Update = true)]
        public int Stock { get; set; }
    }
    internal partial class Good
    {
        public string FullDescription { get { return $"{Brand}, {Category}, {Color}"; } }
    }
}

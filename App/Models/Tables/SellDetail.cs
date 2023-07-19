using GenericBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Tables
{
    [BDProperties(Root = "SellsDetails")]
    internal partial class SellDetail
    {
        [BDProperties(AutoIdentity = true)]
        public int Id { get; set; }

        [BDProperties(Insert = true)]
        public int IdSell { get; set; }

        [BDProperties(Insert = true)]
        public int IdProduct { get; set; }

        [BDProperties(Insert = true)]
        public int IdMovement { get; set; }

        [BDProperties(Insert = true)]
        public int Quantity { get; set; }

        [BDProperties(Insert = true)]
        public decimal Price { get; set; }

        [BDProperties(Insert = true)]
        public decimal Amount { get; set; }
    }
    internal partial class SellDetail
    {
        public Good Product { get; set; }
        public Movement Movement { get; set; }
    }
}

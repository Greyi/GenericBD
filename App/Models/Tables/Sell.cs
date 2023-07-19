using GenericBD;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Tables
{
    [BDProperties(Root = "Sells")]
    internal partial class Sell
    {
        [BDProperties(AutoIdentity = true)]
        public int Id { get; set; }

        [BDProperties(Insert = true)]
        public decimal Amount { get; set; }

        [BDProperties(Insert = true)]
        public DateTime DateSell { get; set; }
    }

    internal partial class Sell
    {
        public List<SellDetail> Detail { get; set; }
    }
}

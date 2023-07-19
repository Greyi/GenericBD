using GenericBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Tables
{
    [BDProperties(Root = "Movements")]
    internal partial class Movement
    {
        [BDProperties(AutoIdentity = true)]
        public int Id { get; set; }

        [BDProperties(Insert = true)]
        public int IdProduct { get; set; }

        [BDProperties(Insert = true)]
        public int IdConcept { get; set; }

        [BDProperties(Insert = true)]
        public int Quantity { get; set; }

        [BDProperties(Insert = true)]
        public DateTime DateMovement { get; set; }
    }

    internal partial class Movement
    {
        public Good Product { get; set; }
        public Concept Concept { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBD
{
    public class Error
    {
        public int Number { get; set; }
        public string Description { get; set; }

        public void Set(int number, string description)
        {
            Number = number;
            Description = description;
        }
        public void Clear()
        {
            Number = 0;
            Description = null;
        }

        public override string ToString()
        {
            return $"{Number} - {Description}";
        }

    }
}

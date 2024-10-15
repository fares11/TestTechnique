using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTechnique
{
    public class Product
    {
        public decimal Prix { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public Product(decimal prix, string name, string type)
        {
            Prix = prix;
            Name = name;
            Type = type;
        }
    }
}

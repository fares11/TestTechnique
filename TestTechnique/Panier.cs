using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTechnique
{
    public class Panier
    {
        private List<Product> _products = new List<Product>();
        private List<IDiscount> _discounts = new List<IDiscount>();

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public void AddDiscount(IDiscount discount)
        {
            _discounts.Add(discount);
        }
        public decimal totalPanierWithoutDiscount()
        {
            return _products.Sum(p => p.Prix);
        }
        public decimal totalPanierWithDiscount()
        {
            decimal total = totalPanierWithoutDiscount();
            decimal discount = _discounts.Sum(d => d.calculateDiscount(_products));
            return total - discount;
        }

    }
}

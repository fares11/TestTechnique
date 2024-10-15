using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTechnique
{
    public class BuyOneGetOneFree : IDiscount
    {
        private readonly string _productType;

        public BuyOneGetOneFree(string productType)
        {
            _productType = productType;
        }
        public decimal calculateDiscount(List<Product> products)
        {
            var discountableProducts = products.Where(p => p.Type == _productType).ToList();
            var itemFree = discountableProducts.Count / 2;
            decimal discount = itemFree * discountableProducts.FirstOrDefault()?.Prix ?? 0;
            return discount;
        }
    }
}

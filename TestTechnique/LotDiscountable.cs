using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTechnique
{
    public class LotDiscountable : IDiscount
    {
        private string _productType;
        private int _quantity;
        private decimal _discountPerOne;


        public LotDiscountable(string productType, int quantity, decimal discountPerOne)
        {
            _productType = productType;
            _quantity = quantity;
            _discountPerOne = discountPerOne;
        }
        public decimal calculateDiscount(List<Product> products)
        {
            var discountableProducts = products.Where(p => p.Type == _productType).ToList();
            var items = discountableProducts.Count / _quantity;
            return _discountPerOne * items;
        }
    }
}

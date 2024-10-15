using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTechnique
{
    public interface IDiscount
    {
        decimal calculateDiscount(List<Product> products);
    }
}

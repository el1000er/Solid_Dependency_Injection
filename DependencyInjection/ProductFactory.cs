using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class ProductFactory
    {
        public static IProductRepository create()
        {
            return new SQLProductRepo();
        }
    }
}

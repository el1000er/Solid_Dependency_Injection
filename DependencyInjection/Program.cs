using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductRepository productRepo = ProductFactory.create();

            //here we are injecting the dependency to product catalog
            ProductCatalog productCatalog = new ProductCatalog(productRepo);

            productCatalog.ListAllProducts();
        }
    }
}

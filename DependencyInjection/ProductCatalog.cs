using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
   public class ProductCatalog
    {
        private IProductRepository productRepository;
        //ctor
        public ProductCatalog(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }


        //Instead of invoking the product factory here, we will use the one that will be  injected in Program.cs
        //public void ListAllProducts()
        //{
        //    IProductRepository porductRepository = ProductFactory.create();       
        //    porductRepository.GetAllProductNames();
        //}


        public void ListAllProducts()
        {
            List<string> AllProductNames = productRepository.GetAllProductNames();
            foreach(string p in AllProductNames)
            {
                Console.WriteLine(p);

                //Display product names
            }
            Console.ReadKey();
        }


    }
}

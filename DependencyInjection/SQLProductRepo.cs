using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class SQLProductRepo:IProductRepository
    {
        public List<string> GetAllProductNames()
        {
            return new List<string> { "soap", "toothpaste" };
        }
    }
     
}

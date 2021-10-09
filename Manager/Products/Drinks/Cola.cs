using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine.Manager.Products.Drinks
{
    class Cola: Product
    {
        
    
        public Cola()
        {
            Name = "Cola";
            Price = 10;
        }

        public int Price { get; set; }

        public string Name { get; set; }
    }
}
    


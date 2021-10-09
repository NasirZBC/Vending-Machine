using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine.Manager.Products.Drinks
{
    class FaxeKondi : Product
    {
        public FaxeKondi()
        {
            Name = "Faxe Kondi";
            Price = 10;
        }

        public int Price { get; set; }

        public string Name { get; set; }
    }
}

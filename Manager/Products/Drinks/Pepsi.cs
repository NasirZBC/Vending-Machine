using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine.Manager.Products.Drinks
{
    class Pepsi
    {
        private string Name = "Pepsi";
        private int Price = 10;

        public Pepsi()
        {
        }

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public int price
        {
            get { return Price; }
            set { Price = value; }
        }
    }
}

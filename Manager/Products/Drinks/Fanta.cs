using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine.Manager.Products.Drinks
{
    class Fanta
    {
        private string Name = "Fanta";
        private int Price = 10;

        public Fanta()
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

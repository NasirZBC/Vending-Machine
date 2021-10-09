using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine.Manager;
using Vending_Machine.Manager.Products.Drinks;

namespace Vending_Machine
{
    class GUI
    {
        public void Execute()
        {
            Console.CursorVisible = false;

            //while (true)
            //{

            //    Console.ReadKey(true);
            //}

            Product product = new(); 

            Console.WriteLine(product.Name);
        }

    }
}

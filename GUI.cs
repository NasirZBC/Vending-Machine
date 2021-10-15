using System;
using System.Collections.Generic;
using System.Threading;
using Vending_Machine.Manager;

namespace Vending_Machine
{
    internal class GUI
    {
        private Handler handler = new Handler();

        public void Execute()
        {
            Console.CursorVisible = false;

            Console.WriteLine("These are the available products at the moment, press S to select");
            Console.WriteLine("Press I to insert your coin and press Enter once you're done inserting.");
            Console.WriteLine("If you change your mind and would like your money back then press R");
            Console.WriteLine();
            //Console.WriteLine("S = Select, I = Insert, R = Return");
            while (true)
            {
                List<Tuple<string, int, int>> products = handler.GetProducts();

                int x;
                int y;
                int z = 0;
                int productNumber = 1;

                for (int i = 0; i < products.Count; i++)
                {
                    Thread.Sleep(200);
                    Console.WriteLine("#" + productNumber++ + " " + products[i].Item1 + " " + products[i].Item2 + "kr" + " " + products[i].Item3 + "x");
                }
                Console.WriteLine();
                Console.WriteLine("Amount of coin in the machine " + handler.GetInsertedCoin() + "kr");

                Console.WriteLine();

                
                Console.WriteLine();

                while (z == 0)
                {

                    x = 0;
                    y = 0;
                    Console.WriteLine("S = Select, I = Insert, R = Return");
                    var input = Console.ReadKey(true);

                    if (input.Key == ConsoleKey.Oem5)
                    {
                        handler.Refill();
                    }
                    else if (input.Key == ConsoleKey.I)
                    {
                        Console.WriteLine("Insert the amount of coin you would like and press Enter once done.");
                        while (x == 0)
                        {
                            if (int.TryParse(Console.ReadLine(), out int coinInput))
                            {
                                handler.InsertCoin(coinInput);
                                Console.WriteLine(handler.GetInsertedCoin() + "kr has been inserted.");
                                x = 1;
                            }
                            else
                            {
                                Console.WriteLine("Please only use numeric values or press Esc to stop inserting coins if not then press any other key to not exit.");
                                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                                {
                                    x = 1;
                                }
                            }
                        }
                    }
                    else if (input.Key == ConsoleKey.R)
                    {
                        Console.WriteLine("There are now " + handler.ReturnMoney() + "kr in the vending machine.");
                        z = 1;
                    }
                    else if (input.Key == ConsoleKey.S)
                    {
                        Console.WriteLine("Type the # product you would like and press enter.");
                        while (y == 0)
                        {
                            if (int.TryParse(Console.ReadLine(), out int coinInput))
                            {
                                Console.WriteLine();
                                Console.WriteLine(handler.vending(coinInput));
                                Console.WriteLine();
                                Console.WriteLine("Amount of coin left in the machine " + handler.GetInsertedCoin() + "kr");
                                y = 1;
                                z = 1;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Please only use numeric values or press Esc to stop selecting, if not then press any other key to not exit.");
                                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                                {
                                    y = 1;
                                    z = 1;
                                }
                            }
                        }
                    }
                }

                Thread.Sleep(3000);
                Console.Clear();
                

            }
        }
    }
}
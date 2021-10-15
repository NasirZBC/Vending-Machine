using System;
using System.Collections.Generic;
using Vending_Machine.Manager.Products;

namespace Vending_Machine.Manager
{
    internal class Handler
    {
        //Create instances to refer to methods and variables
        public VendingMachine vendingMachine = new VendingMachine();

        private List<Tuple<string, int, int>> Products = new List<Tuple<string, int, int>>();

        //instances of Product
        public Product cola = new Product("Cola", 15);

        public Product fanta = new Product("Fanta", 15);
        public Product faxeKondi = new Product("Faxe Kondi", 15);
        public Product pepsi = new Product("Pepsi", 15);
        public Product butterfinger = new Product("Butterfinger", 13);
        public Product kitkat = new Product("Kitkat", 16);
        public Product marsBar = new Product("Mars Bar", 14);
        public Product twix = new Product("Twix", 14);

        private string insufficient = "Insufficient stock/inserted money";

        public Handler()
        {
            fill();
            GetProducts();
        }

        private void fill()
        {
            for (int i = 0; i < 10; i++)
            {
                vendingMachine.slot1Amount.Add(cola);
                vendingMachine.slot2Amount.Add(fanta);
                vendingMachine.slot3Amount.Add(faxeKondi);
                vendingMachine.slot4Amount.Add(pepsi);
                vendingMachine.slot5Amount.Add(butterfinger);
                vendingMachine.slot6Amount.Add(kitkat);
                vendingMachine.slot7Amount.Add(marsBar);
                vendingMachine.slot8Amount.Add(twix);
            }
        }

        public List<Tuple<string, int, int>> GetProducts()
        {
            Products.Clear();
            Products.Add(Tuple.Create(cola.Name, cola.Price, vendingMachine.slot1Amount.Count));
            Products.Add(Tuple.Create(fanta.Name, fanta.Price, vendingMachine.slot2Amount.Count));
            Products.Add(Tuple.Create(faxeKondi.Name, faxeKondi.Price, vendingMachine.slot3Amount.Count));
            Products.Add(Tuple.Create(pepsi.Name, pepsi.Price, vendingMachine.slot4Amount.Count));
            Products.Add(Tuple.Create(butterfinger.Name, butterfinger.Price, vendingMachine.slot5Amount.Count));
            Products.Add(Tuple.Create(kitkat.Name, kitkat.Price, vendingMachine.slot6Amount.Count));
            Products.Add(Tuple.Create(marsBar.Name, marsBar.Price, vendingMachine.slot7Amount.Count));
            Products.Add(Tuple.Create(twix.Name, twix.Price, vendingMachine.slot8Amount.Count));
            return Products;
        }

        public void Refill()
        {
            for (int i = 0; i < 10; i++)
            {
                if (vendingMachine.slot1Amount[0] == null)
                {
                    vendingMachine.slot1Amount[i] = cola;
                }
                if (vendingMachine.slot2Amount[9] == null)
                {
                    vendingMachine.slot2Amount[i] = fanta;
                }
                if (vendingMachine.slot3Amount[9] == null)
                {
                    vendingMachine.slot3Amount[i] = faxeKondi;
                }
                if (vendingMachine.slot4Amount[9] == null)
                {
                    vendingMachine.slot4Amount[i] = pepsi;
                }
                if (vendingMachine.slot5Amount[9] == null)
                {
                    vendingMachine.slot5Amount[i] = butterfinger;
                }
                if (vendingMachine.slot6Amount[9] == null)
                {
                    vendingMachine.slot6Amount[i] = kitkat;
                }
                if (vendingMachine.slot7Amount[9] == null)
                {
                    vendingMachine.slot7Amount[i] = marsBar;
                }
                if (vendingMachine.slot8Amount[9] == null)
                {
                    vendingMachine.slot8Amount[i] = twix;
                }
            }
        }

        public int InsertCoin(int insertedCoin)
        {
            vendingMachine.insertedMoney += insertedCoin;
            return vendingMachine.insertedMoney;
        }

        public int ReturnMoney()
        {
            vendingMachine.insertedMoney = 0;
            return vendingMachine.insertedMoney;
        }

        public int GetInsertedCoin()
        {
            return vendingMachine.insertedMoney;
        }

        public string vending(int userChoice)
        {
            int money = vendingMachine.insertedMoney;
            string result = "";

            switch (userChoice)
            {
                case 1:

                    if (vendingMachine.slot1Amount.Count != 0 && money >= cola.Price)
                    {
                        vendingMachine.insertedMoney -= cola.Price;
                        vendingMachine.totalMoney += cola.Price;
                        vendingMachine.slot1Amount.RemoveAt(vendingMachine.slot1Amount.Count - 1);
                        return result = "Here's your " + cola.Name;
                    }
                    else
                    {
                        result = insufficient;
                    }
                    break;

                case 2:
                    if (vendingMachine.slot2Amount.Count != 0 && money >= fanta.Price)
                    {
                        vendingMachine.insertedMoney -= fanta.Price;
                        vendingMachine.totalMoney = +fanta.Price;
                        vendingMachine.slot2Amount.RemoveAt(vendingMachine.slot1Amount.Count - 1);
                        return result = "Here's your " + fanta.Name;
                    }
                    else
                    {
                        result = insufficient;
                    }
                    break;

                case 3:
                    if (vendingMachine.slot3Amount.Count != 0 && money >= faxeKondi.Price)
                    {
                        vendingMachine.insertedMoney -= faxeKondi.Price;
                        vendingMachine.totalMoney += faxeKondi.Price;
                        vendingMachine.slot3Amount.RemoveAt(vendingMachine.slot1Amount.Count - 1);
                        return result = "Here's your " + faxeKondi.Name;
                    }
                    else
                    {
                        result = insufficient;
                    }
                    break;

                case 4:
                    if (vendingMachine.slot4Amount.Count != 0 && money >= pepsi.Price)
                    {
                        vendingMachine.insertedMoney -= pepsi.Price;
                        vendingMachine.totalMoney += pepsi.Price;
                        vendingMachine.slot4Amount.RemoveAt(vendingMachine.slot1Amount.Count - 1);
                        return result = "Here's your " + pepsi.Name;
                    }
                    else
                    {
                        result = insufficient;
                    }
                    break;

                case 5:
                    if (vendingMachine.slot5Amount.Count != 0 && money >= butterfinger.Price)
                    {
                        vendingMachine.insertedMoney -= butterfinger.Price;
                        vendingMachine.totalMoney += butterfinger.Price;
                        vendingMachine.slot5Amount.RemoveAt(vendingMachine.slot1Amount.Count - 1);
                        return result = "Here's your " + butterfinger.Name;
                    }
                    else
                    {
                        result = insufficient;
                    }
                    break;

                case 6:
                    if (vendingMachine.slot6Amount.Count != 0 && money >= kitkat.Price)
                    {
                        vendingMachine.insertedMoney -= kitkat.Price;
                        vendingMachine.totalMoney += kitkat.Price;
                        vendingMachine.slot6Amount.RemoveAt(vendingMachine.slot1Amount.Count - 1);
                        return result = "Here's your " + kitkat.Name;
                    }
                    else
                    {
                        result = insufficient;
                    }
                    break;

                case 7:
                    if (vendingMachine.slot7Amount.Count != 0 && money >= marsBar.Price)
                    {
                        vendingMachine.insertedMoney -= marsBar.Price;
                        vendingMachine.totalMoney += marsBar.Price;
                        vendingMachine.slot7Amount.RemoveAt(vendingMachine.slot1Amount.Count - 1);
                        return result = "Here's your " + marsBar.Name;
                    }
                    else
                    {
                        result = insufficient;
                    }
                    break;

                case 8:
                    if (vendingMachine.slot8Amount.Count != 0 && money >= twix.Price)
                    {
                        vendingMachine.insertedMoney -= twix.Price;
                        vendingMachine.totalMoney += twix.Price;
                        vendingMachine.slot8Amount.RemoveAt(vendingMachine.slot1Amount.Count - 1);
                        return result = "Here's your " + twix.Name;
                    }
                    else
                    {
                        result = insufficient;
                    }
                    break;

                default:
                    result = "Invalid choice.";
                    break;
            }

            return result;
        }
    }
}
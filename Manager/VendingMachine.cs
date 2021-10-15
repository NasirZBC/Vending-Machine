using System.Collections.Generic;
using Vending_Machine.Manager.Products;

namespace Vending_Machine.Manager
{
    internal class VendingMachine
    {
        private int InsertedMoney;
        private int TotalMoney;
        private List<Product> Slot1Amount = new List<Product>(10);
        private List<Product> Slot2Amount = new List<Product>(10);
        private List<Product> Slot3Amount = new List<Product>(10);
        private List<Product> Slot4Amount = new List<Product>(10);
        private List<Product> Slot5Amount = new List<Product>(10);
        private List<Product> Slot6Amount = new List<Product>(10);
        private List<Product> Slot7Amount = new List<Product>(10);
        private List<Product> Slot8Amount = new List<Product>(10);



        public VendingMachine()
        {
             
        }

        public int totalMoney
        {
            get { return TotalMoney; }
            set { TotalMoney = value; }
        }

        public int insertedMoney
        {
            get { return InsertedMoney; }
            set { InsertedMoney = value; }
        }

        public List<Product> slot1Amount
        {
            get { return Slot1Amount; }
            set { Slot1Amount = value; }
        }

        public List<Product> slot2Amount
        {
            get { return Slot2Amount; }
            set { Slot2Amount = value; }
        }

        public List<Product> slot3Amount
        {
            get { return Slot3Amount; }
            set { Slot3Amount = value; }
        }

        public List<Product> slot4Amount
        {
            get { return Slot4Amount; }
            set { Slot4Amount = value; }
        }

        public List<Product> slot5Amount
        {
            get { return Slot5Amount; }
            set { Slot5Amount = value; }
        }

        public List<Product> slot6Amount
        {
            get { return Slot6Amount; }
            set { Slot6Amount = value; }
        }

        public List<Product> slot7Amount
        {
            get { return Slot7Amount; }
            set { Slot7Amount = value; }
        }

        public List<Product> slot8Amount
        {
            get { return Slot8Amount; }
            set { Slot8Amount = value; }
        }
    }
}
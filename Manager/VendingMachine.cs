namespace Vending_Machine.Manager
{
    internal class VendingMachine
    {
        private int InsertedMoney;
        private int Slot1Amount;
        private int Slot2Amount;
        private int Slot3Amount;
        private int Slot4Amount;
        private int Slot5Amount;
        private int Slot6Amount;
        private int Slot7Amount;
        private int Slot8Amount;

        public VendingMachine()
        {
        }

        public int insertedMoney
        {
            get { return InsertedMoney; }
            set { InsertedMoney = value; }
        }

        public int slot1Amount
        {
            get { return Slot1Amount; }
            set { Slot1Amount = value; }
        }

        public int slot2Amount
        {
            get { return Slot2Amount; }
            set { Slot2Amount = value; }
        }

        public int slot3Amount
        {
            get { return Slot3Amount; }
            set { Slot3Amount = value; }
        }

        public int slot4Amount
        {
            get { return Slot4Amount; }
            set { Slot4Amount = value; }
        }

        public int slot5Amount
        {
            get { return Slot5Amount; }
            set { Slot5Amount = value; }
        }

        public int slot6Amount
        {
            get { return Slot6Amount; }
            set { Slot6Amount = value; }
        }

        public int slot7Amount
        {
            get { return Slot7Amount; }
            set { Slot7Amount = value; }
        }

        public int slot8Amount
        {
            get { return Slot8Amount; }
            set { Slot8Amount = value; }
        }

        private Product Product;

        public Product product
        {
            get { return Product; }
            set { Product = value; }
        }
    }
}
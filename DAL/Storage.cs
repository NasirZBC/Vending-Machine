using Vending_Machine.Manager;


namespace Vending_Machine.DAL
{
    internal class Storage
    {
        private VendingMachine vendingMachine = new VendingMachine();

        

        public Storage()
        {
            vendingMachine.insertedMoney = 0;
            vendingMachine.slot1Amount = 10;
            vendingMachine.slot2Amount = 10;
            vendingMachine.slot3Amount = 10;
            vendingMachine.slot4Amount = 10;
            vendingMachine.slot5Amount = 10;
            vendingMachine.slot6Amount = 10;
            vendingMachine.slot7Amount = 10;
            vendingMachine.slot8Amount = 10;

        }
    }
}
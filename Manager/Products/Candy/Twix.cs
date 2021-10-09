namespace Vending_Machine.Manager.Products.Candy
{
    internal class Twix : Product
    {
        public Twix()
        {
            Name = "Twix";
            Price = 15;
        }

        public int Price { get; set; }

        public string Name { get; set; }
    }
}
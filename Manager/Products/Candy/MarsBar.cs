namespace Vending_Machine.Manager.Products.Candy
{
    internal class MarsBar : Product
    {
        public MarsBar()
        {
            Name = "Mars bar";
            Price = 15;
        }

        public int Price { get; set; }

        public string Name { get; set; }
    }
}
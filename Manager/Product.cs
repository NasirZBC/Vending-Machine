namespace Vending_Machine.Manager.Products
{
     class Product
    {
        public string Name { get; private set; }
        public int Price { get; private set; }

        public Product(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }

        
    }
}
namespace VendingMachine
{
    public class ProductItem
    {

        private int productId;
        private string productName;
        private int price;
        private string description;

        public ProductItem(int productId, string productName, int price, string description)
        {
            this.productId = productId;
            this.productName = productName;
            this.price = price;
            this.description = description;
        }

        public ProductItem(Product Product)
        {
            this.productId = Product.;
            this.productName = productName;
            this.price = price;
            this.description = description;
        }

        public int ProductId { get { return productId; } set { productId = value; } }
        public string Name { get { return productName; } set { productName = value; } }
        public int Price { get { return price; } set { price = value; } }
        public string Description { get { return description; } set { description = value; } }



        //public static void PrintShoppingCart(List<ProductItem> newLog)
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine("=================================================================");
        //    Console.WriteLine(newLog[0].PlayerName);
        //    Console.WriteLine("=================================================================");
        //    Console.ForegroundColor = ConsoleColor.Gray;

        //    foreach (ProductItem productItem in newProductList)
        //    {
        //        Console.WriteLine($"{productItem.ProductName} | {productItem.Price}");
        //    }
        //    Console.WriteLine("Press any key.");
        //    Console.ReadKey();
        //}

    }
}

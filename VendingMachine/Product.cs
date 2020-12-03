using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class Product
    {
       //public object ProductItem { get; set; }        
    }

    public class ProductItem : IProduct
    {
        public int ProductId { get ; set ; }
        public string ProductName { get => ProductName; set => ProductName = "value"; } //Stack overflow
        public int Price { get { return Price; } set => Price = value; }
        public string Description { get { return Description; } set => Description = value; }

        public void Examine()
        {            
        }

        public void Purchase(int customerWallet, int productPrice, Product product)
        {
        }

        public void Use()
        {
        }                
    }

    public class Beverage : ProductItem
    {        
        public new void Examine()
        {
            Console.WriteLine("Dryck: {0}\tPris: {1}", ProductName, Price);
            Console.WriteLine("Description: {0}", Description);
        }
        public new void Purchase(int customerWallet, int productPrice, Product product)
        {
            int CustomerWallet = customerWallet;
            int ProductPrice = productPrice;
            CustomerWallet -= ProductPrice;

            //Add to cart
            Console.WriteLine("{0} added to cart.", ProductName);
            Console.WriteLine("You have {0} kr left in your wallet.", CustomerWallet);
        }
        public new void Use()
        {
            Console.WriteLine("Klunk, klunk, klunk! Ahh, refreshed!");
        }

        public override string ToString()
        {
            return ProductName;
        }
    }    

    public class Food : ProductItem
    {        

        public new void Examine()
        {
            Console.WriteLine("Dryck: {0}\tPris: {1}", ProductName, Price);
            Console.WriteLine("Description: {0}", Description);
        }

        public new void Purchase(int customerWallet, int productPrice, Product product)
        {
            int CustomerWallet = customerWallet;
            int ProductPrice = productPrice;

            CustomerWallet -= ProductPrice;
            //Add to cart
            Console.WriteLine("{0} added to cart.", ProductName);
            Console.WriteLine("You have {0} kr left in your wallet.", CustomerWallet);
        }

        public new void Use()
        {
            Console.WriteLine("Smack, moffel, gulp!! that was a good {0}", ProductName);
        }
    }
    public class Snacks : ProductItem
    {
        public new void Examine()
        {
            Console.WriteLine("Dryck: {0}\tPris: {1}", ProductName, Price);
            Console.WriteLine("Description: {0}", Description);
        }

        public void Purchase(int customerWallet, int productPrice, ProductItem product)
        {
            int CustomerWallet = customerWallet;
            int ProductPrice = productPrice;
            ProductItem Product = product;

            CustomerWallet -= ProductPrice;

            //shoppingCart.Add(Product);

            //Add to cart
            Console.WriteLine("{0} added to cart.", ProductName);
            Console.WriteLine("You have {0} kr left in your wallet.", CustomerWallet);
        }

        public new void Use()
        {
            Console.WriteLine("Moffa, moffa, moffa!");
        }
    }

}

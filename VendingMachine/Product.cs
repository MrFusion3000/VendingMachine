using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class ProductItem : IProduct
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }

        public void Examine()
        {
            Console.WriteLine("Dryck: {0}\tPris: {1}", ProductName, Price);
            Console.WriteLine("Description: {0}", Description);
        }

        public void Purchase(int customerWallet, int productPrice, ProductItem product )
        {
            int CustomerWallet = customerWallet;
            int ProductPrice = productPrice;
            CustomerWallet -= ProductPrice;
            ProductItem Product = product;

            //shoppingCart.Add(Product);


            //Add to cart
            Console.WriteLine("{0} added to cart.", ProductName);
            Console.WriteLine("You have {0} kr left in your wallet.", CustomerWallet);
        }

        public void Use(string ProductName)
        {
            Console.WriteLine("Nothin'!");
        }                
    }

    public class Beverage : ProductItem
    {
        public new static void Use(string ProductName)
        {
            Console.WriteLine("Klunk, klunk, klunk! Ahh! This {0} was refreshing!", ProductName);
        }

        //public override string ToString()
        //{
        //    return ProductName;
        //}
    }    

    public class Food : ProductItem
    {
        public new static void Use(string ProductName)
        {
            Console.WriteLine("Smack, moffel, gulp!! that was a good {0}", ProductName);
        }
    }
    public class Snacks : ProductItem
    {

        public new static void Use(string ProductName )
        {
            Console.WriteLine("Moffa, moffa, moffa! You're mine now, {0} !", ProductName);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class Product
    {
       public object ProductItem { get; set; }
    }
    public class Beverage : ProductBaseClass
    {
        //public override int ProductId => 1;
        //public override string ProductName => "ZvampZoda";
        //public override int Price => 5;
        public override string Description { get; set; }
        public override int AmountInStock { get { return AmountInStock; } set {  } }
        public override bool OutOfStock { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Examine()
        {
            Console.WriteLine("Dryck: {0}\tPris: {1}\t Lager:{2}", ProductName, Price, AmountInStock);
            Console.WriteLine("Description: {0}", Description);
        }
        public override void Purchase()
        {
        }
        public override void Use()
        {
            Console.WriteLine("Klunk, klunk, klunk! Ahh, refreshed!");
        }
    }

    public class Food : ProductBaseClass
    {
        //public override int ProductId => throw new NotImplementedException();
        //public override string ProductName => throw new NotImplementedException();
        //public override int Price => throw new NotImplementedException();
        public override string Description { get; set; }
        public override int AmountInStock { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override bool OutOfStock { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Examine()
        {
            throw new NotImplementedException();
        }

        public override void Purchase()
        {
            throw new NotImplementedException();
        }

        public override void Use()
        {
            Console.WriteLine("Smack, moffel, gulp!! that was a good {0}", ProductName);
        }
    }
    public class Snacks : ProductBaseClass
    {
        //public override int ProductId => throw new NotImplementedException();
        //public override string ProductName => throw new NotImplementedException();
        //public override int Price => throw new NotImplementedException();
        public override string Description { get; set; }
        public override int AmountInStock { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override bool OutOfStock { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Examine()
        {
            throw new NotImplementedException();
        }

        public override void Purchase()
        {
            throw new NotImplementedException();
        }

        public override void Use()
        {
            Console.WriteLine("Moffa, moffa, moffa!");
        }
    }

}

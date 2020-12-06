using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public abstract class VendingMachineBaseClass
    {
        //public int VendingMachineId { get; set; }
        //public abstract int ShoppingCartWallet { get; set; }

        public static int CustomerWallet { get; set; }

        public static ProductItem ProductChoice = ProductInit.Init;

        public  static List<ProductItem> shoppingCart = new List<ProductItem>();

        //public abstract void AddToCustomerWallet(int moneyInput);
        //public abstract void SubFromCustomerWallet(int moneyInput);
        //public abstract void AddToShoppingCart();
        //public abstract void SubFromShoppingCart();
    }

    public class Product
    {

    }
}


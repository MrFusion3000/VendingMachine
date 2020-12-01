using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public abstract class VendingMachineBaseClass
    {
        //List of products, array of products or list of enums
        public int CustomerWallet { get; set; }
        public int ShoppingCartWallet { get; set; }
        public int MyProperty { get; set; }

        public abstract void AddToCustomerWallet();

        public abstract void SubFromCustomerWallet();

        public abstract void AddToShoppingCartWallet();

        public abstract void SubFromShoppingCartWallet();



    }


}

using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public abstract class VendingMachineBaseClass
    {
        public int VendingMachineId { get; set; }
        public int CustomerWallet { get; set; }
        public int ShoppingCartWallet { get; set; }
        public object ShoppingCart { get; set; }
        public List<Product> ProductList { get; set; }

        public abstract void AddToCustomerWallet(int moneyInput);
        public abstract void SubFromCustomerWallet(int moneyInput);
        public abstract void AddToShoppingCart();
        public abstract void SubFromShoppingCart();


    }
}


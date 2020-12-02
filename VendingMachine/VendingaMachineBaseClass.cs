using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    //Class to setup a Vending Machine with  a list of products and a buy/return change function
    public abstract class VendingMachineBaseClass
    {
        public int VendingMachineId { get; set; }
        public int CustomerWallet { get; set; }
        public int ShoppingCartWallet { get; set; }
        //public int MyProperty { get; set; }
        //public List<Product> ProductList { get; set; }

        public abstract void AddToCustomerWallet(int moneyInput);
        public abstract void SubFromCustomerWallet(int moneyInput);
        public abstract void AddToShoppingCartWallet();
        public abstract void SubFromShoppingCartWallet();

        //public void VendingMachineBaseClass() { }
        //public void VendingMachineBaseClass(int vendingMachineId) { }

    }

    class VendingMachine : VendingMachineBaseClass 
    {
        public override void AddToCustomerWallet(int moneyInput) 
        {
            int MoneyInput = moneyInput;
            CustomerWallet += MoneyInput;
        }
        public override void SubFromCustomerWallet(int moneyInput) 
        {
            int MoneyInput = moneyInput;
            CustomerWallet -= MoneyInput;
        }
        public override void AddToShoppingCartWallet() { }
        public override void SubFromShoppingCartWallet() { }

        public void VendingMachineSetup()
        {
        }
        public  void VendingMachineBaseClass(int vendingMachineId)
        {
            VendingMachineId = vendingMachineId;
            //ProductList = new List<Product>();
        }

    }

        //List of products, array of products or list of enums    


}


using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public interface  IProduct
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }

        public abstract void Purchase(int customerWallet, int productPrice, Product product);
        public abstract void Examine();
        public abstract void Use();

    }
}

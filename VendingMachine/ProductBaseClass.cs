using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public abstract class ProductBaseClass
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public abstract string Description { get; set; }
        public abstract int AmountInStock { get; set; }
        public abstract bool OutOfStock { get; set; }
        public abstract void Purchase();
        public abstract void Examine();
        public abstract void Use();

    }
}

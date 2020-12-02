using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public abstract class ProductBaseClass
    {
        public int ProductId { get; }
        public string ProductName { get; }

        public int Price { get; }

        public int AmountInStock { get; set; }

        public bool OutOfStock  { get; set; }
    }

}

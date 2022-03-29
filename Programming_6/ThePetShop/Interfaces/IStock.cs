using System;
namespace ThePetShop.Interfaces
{
    public interface IStock
    {
        public int Price { get; set; }
        public int Quantity { get; set; }
    }
}


using System;
namespace ThePetShop.Entities
{
    public class Pet : Animal
    {
        private string name;
        private int price;
        private int quantity;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Quantity: {Quantity}, Kind: {Kind}, Age: {Age}, MaxAge {MaxAge}, Speak {Speak}";
        }
    }
}


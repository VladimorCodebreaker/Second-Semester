using System;
using ThePetShop.Enums;
namespace ThePetShop.Entities
{
    public class Creature
    {
        public int Age { get; set; }
        public int MaxAge { get; set; }
        public Speak Speak { get; set; }
    }
}

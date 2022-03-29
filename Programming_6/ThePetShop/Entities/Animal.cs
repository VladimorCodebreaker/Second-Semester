using System;
using ThePetShop.Enums;
namespace ThePetShop.Entities
{
    public class Animal : Creature
    {
        public AnimalKind Kind { get; set; }
    }
}


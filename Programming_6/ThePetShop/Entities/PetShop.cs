using System;
using System.Threading;
using ThePetShop.Enums;
using ThePetShop.Interfaces;

namespace ThePetShop.Entities
{
    public class PetShop
    {
        public static Pet[] pets = new Pet[] { };
        static Random random = new Random();

        public PetShop(int size)
        {
            pets = new Pet[size];
        }

        public void GeneratePet()
        {
            int k = 0;
            for (int i = 0; i < pets.Length; i++)
            {
                pets[i] = new Pet
                {
                    Name = $"Pet {k++}",
                    Price = (int)random.Next(1, 100),
                    Quantity = (int)random.Next(1, 100),
                    Kind = (AnimalKind)random.Next(0, 5),
                    Age = (int)random.Next(1, 120),
                    MaxAge = (int)random.Next(1, 170),
                    Speak = (Speak)random.Next(0, 5),
                };
            }
        }

        public void Print()
        {
            foreach (var item in pets)
            {
                Console.WriteLine(item);
            }
        }

        public void AddPet()
        {
            Pet pet = new Pet();

            Console.WriteLine("Name of the pet:");
            pet.Name = Console.ReadLine();
            Console.WriteLine("Price of the pet:");
            pet.Price = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantity:");
            pet.Quantity = int.Parse(Console.ReadLine());
            pet.Kind = (AnimalKind)random.Next(0, 5);
            Console.WriteLine("Age:");
            pet.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Max age: ");
            pet.MaxAge = Convert.ToInt32(Console.ReadLine());
            pet.Speak = (Speak)random.Next(0, 5);

            pets = pets.Concat(new Pet[] { pet }).ToArray();
        }

        public Pet SellPet()
        {
            Console.WriteLine("Number of the pet: ");
            int index = Convert.ToInt32(Console.ReadLine());

            if (index > pets.Length)
            {
                throw new Exception("Index outside the bounds!");
            }

            var chosen = pets[index];

            for (int i = index; i < pets.Length - 1; i++)
            {
                pets[i] = pets[i + 1];
            }
            pets[pets.Length - 1] = null;

            Console.WriteLine("\nSold: {0}\n", chosen);
            return chosen;
        }

        public void ListPetsByKind()
        {
            AnimalKind kind = new AnimalKind();

            Console.WriteLine("Choose the kind of pet..\n" +
                "1. Mammal\n" +
                "2. Fish\n" +
                "3. Amphibian\n" +
                "4. Reptile\n" +
                "5. Bird\n" +
                "6. Invertebrate");

            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    kind = AnimalKind.Mammal;
                    break;
                case 2:
                    kind = AnimalKind.Fish;
                    break;
                case 3:
                    kind = AnimalKind.Amphibian;
                    break;
                case 4:
                    kind = AnimalKind.Reptile;
                    break;
                case 5:
                    kind = AnimalKind.Bird;
                    break;
                case 6:
                    kind = AnimalKind.Invertebrate;
                    break;
                default:
                    Console.WriteLine("Error. Wrong input format or the number is outside the bounds. Try again...");
                    break;
            }

            for (int i = 0; i < pets.Length - 1; i++)
            {
                if (pets[i].Kind.Equals(kind))
                {
                    Console.WriteLine(pets[i]);
                }
            }
        }

        public void ListPetsByAge()
        {
            Console.WriteLine("Enter the age of the pet: ");
            bool input = int.TryParse(Console.ReadLine(), out int age);

            for (int i = 0; i < pets.Length - 1; i++)
            {
                if (pets[i].Age.Equals(age))
                {
                    Console.WriteLine(pets[i]);
                }
            }
            Console.WriteLine("There are no more or no pets with this age.");
        }

        public void ListPetsByAgeStage()
        {
            for (int i = 0; i < pets.Length - 1; i++)
            {
                if (((pets[i].Age / pets[i].MaxAge) * 100) <= 20)
                {
                    Console.WriteLine(pets[i] + "== Young");
                }
                else if ((pets[i].Age / pets[i].MaxAge) * 100 >= 70)
                {
                    Console.WriteLine(pets[i] + "== Old");
                }
                else
                {
                    Console.WriteLine(pets[i] + "== Middle");
                }
            }
        }

        public void Search()
        {
            Pet pet = new Pet();

            Console.WriteLine("What's the name of the pet?");
            pet.Name = Console.ReadLine();
            Console.WriteLine("Age of the pet: ");
            pet.Age = int.Parse(Console.ReadLine());


            for (int i = 0; i < pets.Length; i++)
            {
                if (pets[i].Name == pet.Name && pets[i].Age == pet.Age)
                {
                    Console.WriteLine(pets[i] + "     || Found ||");
                    return;
                }
            }
        }
    }
}


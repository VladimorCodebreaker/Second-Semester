using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Globalization;
using System.IO.Enumeration;
using System.IO;
using ThePetShop.Enums;
using ThePetShop.Interfaces;
using ThePetShop.Entities;
namespace ThePetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            PetShop petShop = new PetShop(20);

            while (true)
            {
                Console.WriteLine("------------The Pet Shop-------------");
                Console.WriteLine("Please choose an option..\n");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. View all pets");
                Console.WriteLine("2. Add Pet");
                Console.WriteLine("3. Sell Pet");
                Console.WriteLine("4. View Pet (by kind)");
                Console.WriteLine("5. View Pet (by age)");
                Console.WriteLine("6. View Pet (by agestage)");
                Console.WriteLine("7. Search (for pet)");

                bool read = int.TryParse(Console.ReadLine(), out int input);

                if (input == 0)
                {
                    break;
                }

                switch (input)
                {

                    case 1:
                        petShop.GeneratePet();
                        petShop.Print();
                        break;
                    case 2:
                        petShop.AddPet();
                        petShop.Print();
                        break;
                    case 3:
                        petShop.GeneratePet();
                        petShop.SellPet();

                        Console.WriteLine("Do you wanna see the list of pets? true/false");
                        bool userInput = Convert.ToBoolean(Console.ReadLine());
                        if (userInput == true)
                        {
                            petShop.Print();
                        }
                        break;
                    case 4:
                        petShop.GeneratePet();
                        petShop.ListPetsByKind();
                        break;
                    case 5:
                        petShop.GeneratePet();
                        petShop.ListPetsByAge();
                        break;
                    case 6:
                        petShop.GeneratePet();
                        petShop.ListPetsByAgeStage();
                        break;
                    case 7:
                        petShop.GeneratePet();
                        petShop.Print();
                        petShop.Search();
                        break;
                }
                Console.WriteLine("Click Enter ==> Menu");
                Console.ReadLine();
                Console.Clear();
            }

            System.Console.WriteLine("Thank you for visiting our Pet Shop :)");
        }
    }
}
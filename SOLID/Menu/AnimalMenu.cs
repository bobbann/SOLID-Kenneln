using SOLID_Kenneln.Animals;
using SOLID_Kenneln.Kennel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Kenneln.Menu
{
    class AnimalMenu : IAnimalMenu
    {
        public IKennelManager KennelManager { get; set; }
        public IAnimalManager AnimalManager { get; set; }
        public IServicesMenu ServicesMenu { get; set; }

        public AnimalMenu(IKennelManager kennelManager, IAnimalManager animalManager, IServicesMenu servicesMenu)
        {
            KennelManager = kennelManager;
            AnimalManager = animalManager;
            ServicesMenu = servicesMenu;
        }
        public void ShowAnimalMenu()
        {
            Console.Clear();
            Console.WriteLine("*********************************");
            Console.WriteLine(" Animal Menu");
            Console.WriteLine("*********************************");
            Console.WriteLine("1: Registered Animals");
            Console.WriteLine("2: Submit Animal");
            Console.WriteLine("3: Retrieve Animal");
            Console.WriteLine("4: View Current Animals and Owners");
            Console.WriteLine("5: Services");

            var userInput = Console.ReadKey(true).Key;
            switch (userInput)
            {
                case ConsoleKey.D1:
                    KennelManager.RegisteredAnimals();
                    break;

                case ConsoleKey.D2:
                    KennelManager.SubmitAnimal();
                    break;

                case ConsoleKey.D3:
                    KennelManager.RetrieveAnimal();
                    break;

                case ConsoleKey.D4:
                    KennelManager.ViewCurrentAnimalsAndOwners();
                    break;

                case ConsoleKey.D5:
                    ServicesMenu.ShowServicesMenu();
                    break;

                default:
                    Console.WriteLine("Unknown Command");
                    break;
            }
        }
    }
}

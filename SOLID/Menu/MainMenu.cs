using SOLID_Kenneln.Animals;
using SOLID_Kenneln.Customers;
using SOLID_Kenneln.Kennel;
using System;

namespace SOLID_Kenneln.Menu
{
    internal class MainMenu : IMainMenu
    {
        public ICustomerManager CustomerManager { get; set; }
        public IKennelManager KennelManager { get; set; }
        public IAnimalManager AnimalManager { get; set; }
        public IAnimalMenu AnimalMenu { get; set; }
        public ICustomerMenu CustomerMenu { get; set; }

        public MainMenu(ICustomerManager customerManager, IKennelManager kennelManager, IAnimalManager animalManager, IAnimalMenu animalMenu, ICustomerMenu customerMenu)
        {
            CustomerManager = customerManager;
            KennelManager = kennelManager;
            AnimalManager = animalManager;
            AnimalMenu = animalMenu;
            CustomerMenu = customerMenu;
        }

        public void Show()
        {
            Console.WriteLine("*********************************");
            Console.WriteLine(" Welcome to the Kennel Facility");
            Console.WriteLine("*********************************");
            Console.WriteLine("1: Register Customer");
            Console.WriteLine("2: Register Animal");
            Console.WriteLine("3: Add Animal to customer");
            Console.WriteLine("4: Customer Menu");
            Console.WriteLine("5: Animal Menu");
        }

        public void GetInput()
        {
            var userInput = Console.ReadKey(true).Key;
            switch (userInput)
            {
                case ConsoleKey.D1:
                    CustomerManager.RegisterCustomer();
                    break;

                case ConsoleKey.D2:
                    AnimalManager.RegisterAnimal();
                    break;
                
                case ConsoleKey.D3:
                    KennelManager.AddAnimalToCustomer();
                    break;

                case ConsoleKey.D4:
                    CustomerMenu.ShowCustomerMenu();
                    break;

                case ConsoleKey.D5:
                    AnimalMenu.ShowAnimalMenu();
                    break;

                default:
                    Console.WriteLine("Unknown Command");
                    break;
            }
        }
    }
}
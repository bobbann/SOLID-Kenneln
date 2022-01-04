using SOLID_Kenneln.Customers;
using SOLID_Kenneln.Kennel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Kenneln.Menu
{
    class CustomerMenu : ICustomerMenu
    {
        public IKennelManager KennelManager { get; set; }
        public ICustomerManager CustomerManager { get; set; }

        public CustomerMenu(IKennelManager kennelManager, ICustomerManager customerManager)
        {
            KennelManager = kennelManager;
            CustomerManager = customerManager;
        }

        public void ShowCustomerMenu()
        {
            Console.Clear();
            Console.WriteLine("*********************************");
            Console.WriteLine(" Customer Menu");
            Console.WriteLine("*********************************");
            Console.WriteLine("1: Registered Customers");
            Console.WriteLine("2: View Connected Animals");

            var userInput = Console.ReadKey(true).Key;
            switch (userInput)
            {
                case ConsoleKey.D1:
                    KennelManager.RegisteredCustomers();
                    break;

                case ConsoleKey.D2:
                    KennelManager.ViewConnectedAnimals();
                    break;

                default:
                    Console.WriteLine("Unknown Command");
                    break;
            }
        }
    }
}

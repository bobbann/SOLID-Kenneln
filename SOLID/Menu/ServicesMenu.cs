using SOLID_Kenneln.Animals;
using SOLID_Kenneln.Kennel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Kenneln.Menu
{
    class ServicesMenu : IServicesMenu
    {

        public IKennelManager KennelManager { get; set; }
        public IAnimalManager AnimalManager { get; set; }

        public ServicesMenu(IKennelManager kennelManager, IAnimalManager animalManager)
        {
            KennelManager = kennelManager;
            AnimalManager = animalManager;
        }
        public void ShowServicesMenu()
        {
            Console.Clear();
            Console.WriteLine("*********************************");
            Console.WriteLine(" Services Menu");
            Console.WriteLine("*********************************");
            Console.WriteLine("1: Wash");
            Console.WriteLine("2: Claw Trimming");


            var userInput = Console.ReadKey(true).Key;
            switch (userInput)
            {
                case ConsoleKey.D1:
                    KennelManager.AddWash();
                    break;

                case ConsoleKey.D2:
                    KennelManager.AddClawTrimming();
                    break;
            }
        }
    }
}

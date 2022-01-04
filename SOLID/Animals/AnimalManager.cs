using SOLID_Kenneln.Customers.Animals;
using Data;
using SOLID_Kenneln.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Kenneln.Animals
{
    class AnimalManager : IAnimalManager
    {
        public IDatabaseUsingLists Db { get; set; }

        public AnimalManager(IDatabaseUsingLists db)
        {
            Db = db;
        }

        public void RegisterAnimal()
        {
            IAnimal animal = AnimalFactory.Create();

            Console.WriteLine("Enter the dogs registrationnumber");
            animal.RegistrationNumber = (Console.ReadLine());

            Console.WriteLine("Enter the breed");
            animal.DogBreed = Console.ReadLine();

            Console.WriteLine("Enter the Dogs name");
            animal.Name = Console.ReadLine();

            Console.WriteLine("Enter age of dog");
            animal.Age = (Console.ReadLine());

            Db.Animals.Add(animal);
        }
    }
}

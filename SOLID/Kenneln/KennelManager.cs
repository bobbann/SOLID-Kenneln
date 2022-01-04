using Data;
using SOLID_Kenneln.Customers;
using SOLID_Kenneln.Customers.Animals;
using System;
using System.Collections.Generic;

namespace SOLID_Kenneln.Kennel
{
    internal class KennelManager : IKennelManager
    {
        public IDataRepository Db { get; set; }

        public KennelManager(IDataRepository db)
        {
            Db = db;
        }

        public void AddAnimalToCustomer()
        {
            Console.WriteLine("Please add the dogs registrationnumber");
            IAnimal animal = Db.GetAnimalByRegistrationNumber(Console.ReadLine());
            Console.WriteLine("Please enter the personal identification number of the customer");
            ICustomer customer = Db.GetCustomerByPid(Console.ReadLine()); 
            customer.ConnectedAnimals.Add(animal);
            animal.ConnectedOwners.Add(customer);
        }

        public void RegisteredCustomers()
        {
            var customers = Db.GetAllCustomers();
            Console.WriteLine("Registered Customers:");
            foreach (var customer in customers)
            {
                Console.WriteLine("First Name: " + customer.FirstName + " " + "Last Name: " + customer.LastName + " " + "Personal IdentificationNumber: " + customer.PersonalIdentificationNumber);
            }
        }

        public void RegisteredAnimals()
        {
            var animals = Db.GetAllAnimals();
            Console.WriteLine("Registered Animals:");
            foreach (var animal in animals)
            {
                Console.WriteLine("Registration Number: " + animal.RegistrationNumber + " " + "Breed: " + animal.DogBreed + " " + "Age: " + animal.Age + " " + "Name: " + animal.Name);
            }
        }

        public void SubmitAnimal()
        {
            Console.WriteLine("Please enter the registrationnumber of the submitted Dog");
            IAnimal animal = Db.GetAnimalByRegistrationNumber(Console.ReadLine());

            Console.WriteLine("Please enter the Kennel Place Number");
            IKennelPlace kennelPlace = Db.GetKennelPlaceByNumber(Console.ReadLine());
            Console.WriteLine("Animal with registration number: " + animal.RegistrationNumber + " " + "Has been submitted.");

            
            animal.IsSubmitted = true;
            kennelPlace.CurrentAnimals.Add(animal);
        }

        public void RetrieveAnimal()
        {
            Console.WriteLine("Please enter the registrationnumber of the dog to be retrieved");
            IAnimal animal = Db.GetAnimalByRegistrationNumber(Console.ReadLine());

            Console.WriteLine("Please enter the Kennel Place Number");
            IKennelPlace kennelPlace = Db.GetKennelPlaceByNumber(Console.ReadLine());

            kennelPlace.CurrentAnimals.Remove(animal);

            Console.WriteLine("Registration Number: " + animal.RegistrationNumber + " " + "Breed: " + animal.DogBreed + " " + "Age: " + animal.Age + " " + "Name: " + animal.Name + " " + "Has been retrieved");
            animal.IsSubmitted = false;

            Console.WriteLine("Reciept");
            if (animal.GotWash)
            {
                Console.WriteLine("Animal got a wash: 150");
            }
            if (animal.GotClawTrim)
            {
                Console.WriteLine("Animal got a ClawTrim: 300");
            }
            Console.WriteLine($"Total Price: {animal.Price}");
        }

        public void ViewConnectedAnimals()
        {
            Console.WriteLine("Please enter the Personal Identification Number of customer");
            ICustomer customer = Db.GetConnectedAnimalByPersonalIdentificationNumber(Console.ReadLine());
            foreach (var item in customer.ConnectedAnimals)
            {
                Console.WriteLine("The dog connected to Personal Identification Number: " + customer.PersonalIdentificationNumber + " " + "Registration Number: " + item.RegistrationNumber + " " + "Breed: " + item.DogBreed + " " + "Age: " + item.Age + " " + "Name: " + item.Name + " ");
            }
        }

        public void AddWash()
        {
            var animals = Db.GetAllAnimals();
            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i].IsSubmitted)
                {
                    Console.WriteLine($"{i}   {animals[i].Name}");
                }
            }
            Console.WriteLine("Select the dog to wash");
            int chosenAnimal = Convert.ToInt32(Console.ReadLine());
            animals[chosenAnimal].GotWash = true;
            animals[chosenAnimal].Price += 150;
            Console.ReadLine();
            Console.Clear();

        }

        public void AddClawTrimming()
        {
            var animals = Db.GetAllAnimals();
            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i].IsSubmitted)
                {
                    Console.WriteLine($"{i}   {animals[i].Name}");
                }
            }
            Console.WriteLine("Select the dog to trim");
            int chosenAnimal = Convert.ToInt32(Console.ReadLine());
            animals[chosenAnimal].GotClawTrim = true;
            animals[chosenAnimal].Price += 300;
            Console.ReadLine();
            Console.Clear();

        }

        public void ViewCurrentAnimalsAndOwners()
        {
            foreach (var currentAnimal in Db.GetCurrentAnimals())
            {
                if (currentAnimal.IsSubmitted)
                {
                    Console.WriteLine("Name of dog: ");
                    Console.WriteLine(currentAnimal.Name);
                    Console.WriteLine("Registration Number: ");
                    Console.WriteLine(currentAnimal.RegistrationNumber);
                    Console.WriteLine("Connected Owner: ");
                    foreach (var customer in currentAnimal.ConnectedOwners)
                    {
                        Console.WriteLine(customer.FirstName);
                    }
                }
            }
        }
    }
}
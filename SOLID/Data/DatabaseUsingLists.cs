using SOLID_Kenneln.Customers;
using SOLID_Kenneln.Customers.Animals;
using SOLID_Kenneln.Kennel;
using System.Collections.Generic;

namespace Data
{
    internal class DatabaseUsingLists : IDatabaseUsingLists
    {

        public List<ICustomer> Customers { get; set; }

        public List<IAnimal> Animals { get; set; }
        public List<IKennelPlace> KennelPlaces { get; set; }

        public DatabaseUsingLists()
        {
            KennelPlaces = new();
            Animals = new() { new Animal() { Id = 1, RegistrationNumber = "2", Name = "Hund", DogBreed = "Dog", Age = "10" } };
            Customers = new() { new Customer() { Id = 1, FirstName = "Eric", LastName = "Boberg", PersonalIdentificationNumber = "1" } };
        }
    }
}
using SOLID_Kenneln.Customers.Animals;
using System.Collections.Generic;

namespace SOLID_Kenneln.Customers
{
    internal class Customer : ICustomer
    {
        public int Id { get; set; }
        public string PersonalIdentificationNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<IAnimal> ConnectedAnimals { get; set; }
        public Customer()
        {
            ConnectedAnimals = new();
        }

    }
}
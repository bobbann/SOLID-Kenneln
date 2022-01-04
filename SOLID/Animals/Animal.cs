
using SOLID_Kenneln.Customers;
using System.Collections.Generic;

namespace SOLID_Kenneln.Customers.Animals
{
    class Animal : IAnimal
    {
        public int Id { get; set; }
        public string RegistrationNumber { get; set; }
        public string DogBreed { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public decimal Price { get; set; }
        public List<ICustomer> ConnectedOwners { get; set; }
        public bool IsSubmitted { get; set; }
        public bool GotWash { get; set; }
        public bool GotClawTrim { get; set; }
        public Animal()
        {
            ConnectedOwners = new();
            GotClawTrim = false;
            GotWash = false;
        }

    }
}

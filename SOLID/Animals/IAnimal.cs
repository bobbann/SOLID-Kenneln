using System.Collections.Generic;

namespace SOLID_Kenneln.Customers.Animals
{
    public interface IAnimal
    {
        string Age { get; set; }
        string DogBreed { get; set; }
        int Id { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
        string RegistrationNumber { get; set; }
        bool IsSubmitted { get; set; }
        public bool GotWash { get; set; }
        public bool GotClawTrim { get; set; }
        public List<ICustomer> ConnectedOwners { get; set; }
    }
}
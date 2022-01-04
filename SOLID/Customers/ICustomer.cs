using SOLID_Kenneln.Customers.Animals;
using System.Collections.Generic;

namespace SOLID_Kenneln.Customers
{
    public interface ICustomer
    {
        string FirstName { get; set; }
        string PersonalIdentificationNumber { get; set; }
        int Id { get; set; }
        string LastName { get; set; }
        public List<IAnimal> ConnectedAnimals { get; set; }
    }
}
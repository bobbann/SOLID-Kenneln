using SOLID_Kenneln.Customers;
using SOLID_Kenneln.Customers.Animals;
using SOLID_Kenneln.Kennel;
using System.Collections.Generic;

namespace Data
{
    interface IDataRepository
    {
        IDatabaseUsingLists Db { get; set; }

        List<ICustomer> GetAllCustomers();
        IAnimal GetAnimalByRegistrationNumber(string registrationNumber);
        ICustomer GetCustomerByConnectedAnimal(IAnimal connectedAnimal);
        ICustomer GetCustomerById(int id);
        ICustomer GetCustomerByPid(string personalIdentificationNumber);
        List<IAnimal> GetAllAnimals();
        IKennelPlace GetKennelPlaceByNumber(string v);
        ICustomer GetConnectedAnimalByPersonalIdentificationNumber(string personalIdentificationNumber);
        IEnumerable<IAnimal> GetCurrentAnimals();
        IEnumerable<ICustomer> GetConnectedOwners();
        
    }
}
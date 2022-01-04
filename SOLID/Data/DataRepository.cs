using SOLID_Kenneln.Animals;
using SOLID_Kenneln.Customers;
using SOLID_Kenneln.Customers.Animals;
using SOLID_Kenneln.Kennel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class DataRepository : IDataRepository
    {
        public IDatabaseUsingLists Db { get; set; }
        public DataRepository(IDatabaseUsingLists db)
        {
            Db = db;
        }

        public ICustomer GetCustomerByPid(string personalIdentificationNumber)
        {
            return Db.Customers.Where(c => c.PersonalIdentificationNumber == personalIdentificationNumber).FirstOrDefault();
        }

        public ICustomer GetCustomerById(int id)
        {
            return Db.Customers.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<ICustomer> GetAllCustomers()
        {
            return Db.Customers.ToList();
        }

        public List<IAnimal> GetAllAnimals()
        {
            return Db.Animals.ToList();
        }

        public IAnimal GetAnimalByRegistrationNumber(string registrationNumber)
        {
            return Db.Animals.Where(a => a.RegistrationNumber == registrationNumber).FirstOrDefault();
        }

        public ICustomer GetCustomerByConnectedAnimal(IAnimal connectedAnimal)
        {
            return Db.Customers.Where(c => c.ConnectedAnimals.Contains(connectedAnimal)).FirstOrDefault();
        }

        public IKennelPlace GetKennelPlaceByNumber(string placenumber)
        {
            return Db.KennelPlaces.Where(k => k.PlaceNumber == placenumber).FirstOrDefault();
        }

        public ICustomer GetConnectedAnimalByPersonalIdentificationNumber(string personalIdentificationNumber)
        {
            return Db.Customers.Where(c => c.PersonalIdentificationNumber == personalIdentificationNumber).FirstOrDefault();
        }

        public IEnumerable<IAnimal> GetCurrentAnimals()
        {
            return Db.KennelPlaces.SelectMany(c => c.CurrentAnimals);
        }

        public IEnumerable<ICustomer> GetConnectedOwners()
        {
            return Db.Animals.SelectMany(c => c.ConnectedOwners);
        }
    }
}

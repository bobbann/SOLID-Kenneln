using SOLID_Kenneln.Customers;
using SOLID_Kenneln.Customers.Animals;
using SOLID_Kenneln.Kennel;
using System.Collections.Generic;

namespace Data
{
    internal interface IDatabaseUsingLists
    {
        List<IAnimal> Animals { get; set; }
        List<ICustomer> Customers { get; set; }

        List<IKennelPlace> KennelPlaces { get; set; }

    }
}
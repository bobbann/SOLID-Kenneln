using SOLID_Kenneln.Customers.Animals;
using System.Collections.Generic;

namespace SOLID_Kenneln.Kennel
{
    public interface IKennelPlace
    {
        int Id { get; set; }
        public string PlaceNumber { get; set; }
        decimal Price { get; set; }
        public List<IAnimal> CurrentAnimals { get; set; }
    }
}
using SOLID_Kenneln.Customers.Animals;
using System.Collections.Generic;

namespace SOLID_Kenneln.Kennel
{
    internal class KennelPlace : IKennelPlace
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string PlaceNumber { get; set; }
        public List<IAnimal> CurrentAnimals { get; set; }

        public KennelPlace()
        {
           CurrentAnimals = new();
        }
    }
}
using SOLID_Kenneln.Customers.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Kenneln.Factories
{
    class AnimalFactory
    {
        public static IAnimal Create()
        {
            return new Animal();
        }
    }
}

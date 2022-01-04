using SOLID_Kenneln.Customers.Animals;
using Data;
using SOLID_Kenneln.Factories;
using System;
using System.Linq;

namespace SOLID_Kenneln.Customers
{
    internal class CustomerManager : ICustomerManager
    {
        public IDatabaseUsingLists Db { get; set; }

        public CustomerManager(IDatabaseUsingLists db)
        {
            Db = db;
        }

        public void RegisterCustomer()
        {
            ICustomer customer = CustomerFactory.Create();

            Console.WriteLine("Enter the personal identification number");
            customer.PersonalIdentificationNumber = (Console.ReadLine());

            Console.WriteLine("Enter the first name");
            customer.FirstName = Console.ReadLine();

            Console.WriteLine("Enter the last name");
            customer.LastName = Console.ReadLine();

            Db.Customers.Add(customer);
        }
    }
}
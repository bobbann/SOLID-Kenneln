using SOLID_Kenneln.Customers;

namespace SOLID_Kenneln.Factories
{
    internal static class CustomerFactory
    {
        public static ICustomer Create()
        {
            return new Customer();
        }
    }
}
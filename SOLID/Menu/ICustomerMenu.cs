using SOLID_Kenneln.Customers;
using SOLID_Kenneln.Kennel;

namespace SOLID_Kenneln.Menu
{
    interface ICustomerMenu
    {
        ICustomerManager CustomerManager { get; set; }
        IKennelManager KennelManager { get; set; }

        void ShowCustomerMenu();
    }
}
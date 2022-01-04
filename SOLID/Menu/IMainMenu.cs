using SOLID_Kenneln.Animals;
using SOLID_Kenneln.Customers;
using SOLID_Kenneln.Kennel;

namespace SOLID_Kenneln.Menu
{
    internal interface IMainMenu
    {
        ICustomerManager CustomerManager { get; set; }
        IKennelManager KennelManager { get; set; }
        IAnimalManager AnimalManager { get; set; }

        void GetInput();

        void Show();
    }
}
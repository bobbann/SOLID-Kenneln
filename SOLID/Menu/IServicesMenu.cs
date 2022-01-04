using SOLID_Kenneln.Animals;
using SOLID_Kenneln.Kennel;

namespace SOLID_Kenneln.Menu
{
    interface IServicesMenu
    {
        IAnimalManager AnimalManager { get; set; }
        IKennelManager KennelManager { get; set; }

        void ShowServicesMenu();
    }
}
using Data;

namespace SOLID_Kenneln.Kennel
{
    internal interface IKennelManager
    {
        void AddAnimalToCustomer();
        void RegisteredAnimals();

        void RegisteredCustomers();
        void SubmitAnimal();
        void RetrieveAnimal();
        void ViewConnectedAnimals();
        void ViewCurrentAnimalsAndOwners();
        void AddWash();
        void AddClawTrimming();
    }
}
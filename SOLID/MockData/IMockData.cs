using Data;

namespace SOLID_Kenneln
{
    internal interface IMockData
    {
        IDatabaseUsingLists Db { get; set; }

        void GenerateKennelPlaces();
    }
}
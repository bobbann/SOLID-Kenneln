using Data;
using SOLID_Kenneln.Kennel;
using System.Collections.Generic;

namespace SOLID_Kenneln
{
    internal class MockData : IMockData
    {
        public IDatabaseUsingLists Db { get; set; }

        public MockData(IDatabaseUsingLists databaseUsingLists)
        {
            Db = databaseUsingLists;
        }

        public void GenerateKennelPlaces()
        {
            //Skapa Platser
            for (int i = 1; i < 11; i++)
            {
                var kennelPlace = new KennelPlace();
                kennelPlace.PlaceNumber = i.ToString();
                kennelPlace.Price = i * 10;

                Db.KennelPlaces.Add(kennelPlace);
            }
        }


    }
}
using Data;
using SOLID_Kenneln.Menu;

namespace SOLID_Kenneln
{
    internal class Application : IApplication
    {
        public IMockData MockData { get; set; }
        public IDatabaseUsingLists Db { get; set; }
        public IMainMenu MainMenu { get; set; }

        public Application(IMainMenu mainMenu, IDatabaseUsingLists databaseUsingLists, IMockData mockData)
        {
            Db = databaseUsingLists;
            MockData = mockData;
            MainMenu = mainMenu;
        }

        public void Run()
        {
            MockData.GenerateKennelPlaces();

            while (true)
            {
                MainMenu.Show();
                MainMenu.GetInput();
            }
        }
    }
}
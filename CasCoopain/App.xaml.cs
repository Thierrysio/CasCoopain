using CasCoopain.Services;
using CasCoopain.Vues;

namespace CasCoopain;

public partial class App : Application
{
    static GestionDatabase database;
    public App()
    {
        InitializeComponent();

        MainPage = new CasCoopainVue();
    }
    public static GestionDatabase Database
    {
        get
        {
            if (database == null)
            {
                database = new GestionDatabase();
            }
            return database;
        }
    }
}

namespace Minhascompras;
using Minhascompras.Helpers;
public partial class App : Application
{
    static SQliteDatabaseHelpers _db;


    public static SQliteDatabaseHelpers db
    {
        get
        {
            if (_db == null)
            {
                string caminho = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "banco_sqlite_compras.db3");
                _db = new SQliteDatabaseHelpers(caminho);
            }
            return _db;
        }
    }
    public App()
    {
        InitializeComponent();

        // MainPage = new AppShell();
        MainPage = new NavigationPage(new views.Listaproduto());
    }

}

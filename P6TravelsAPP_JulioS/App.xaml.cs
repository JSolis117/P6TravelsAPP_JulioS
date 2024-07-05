using P6TravelsAPP_JulioS.Views;



namespace P6TravelsAPP_JulioS
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }
    }
}

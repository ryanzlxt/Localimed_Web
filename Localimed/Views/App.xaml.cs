namespace Localimed
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell(); //Dizendo ao código que a MainPage são os parâmetros que foram passados em AppShell.xaml
        }

        
    }
}
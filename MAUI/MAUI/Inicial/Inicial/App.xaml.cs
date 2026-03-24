using Microsoft.Extensions.DependencyInjection;

namespace Inicial
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }
    }
}
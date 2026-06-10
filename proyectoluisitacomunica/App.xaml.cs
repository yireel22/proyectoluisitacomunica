using Microsoft.Maui.Controls;

namespace proyectoluisitacomunica
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
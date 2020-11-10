using Autofac;
using System.Windows;
using WPF_MahApps_UI_Elements.StartUp;

namespace WPF_MahApps_UI_Elements
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var bootstrapper = new Bootstrapper();
            var container = bootstrapper.Bootstrap();
            var newWindow = container.Resolve<MainWindow>();
            newWindow.Show();
        }
    }
}

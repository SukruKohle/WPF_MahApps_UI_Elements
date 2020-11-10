using Autofac;

namespace WPF_MahApps_UI_Elements.StartUp
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            //Dependency Injection - Autofac
            var builder = new ContainerBuilder();
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            return builder.Build();
        }
    }
}

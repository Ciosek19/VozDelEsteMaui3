using Microsoft.Extensions.DependencyInjection;
using VozDelEsteMaui3.Servicios.Interfaces;
using VozDelEsteMaui3.Vistas;

namespace VozDelEsteMaui3
{
   public partial class App : Application
   {
      private readonly IServiceProvider _serviceProvider;

      public App(ISesionServicio sesionServicio, IServiceProvider serviceProvider)
      {
         _serviceProvider = serviceProvider;

         InitializeComponent();

         if (sesionServicio.EstaAutenticado)
         {
            MainPage = new AppShell();
         }
         else
         {
            MainPage = new NavigationPage(serviceProvider.GetRequiredService<Login>());
         }
      }

      public void ReiniciarApp()
      {
         MainPage = new NavigationPage(_serviceProvider.GetRequiredService<Login>());
      }
   }
}
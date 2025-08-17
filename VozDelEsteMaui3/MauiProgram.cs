using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using VozDelEsteMaui3.Data;
using VozDelEsteMaui3.Data.Interfaces;
using VozDelEsteMaui3.Data.Repositorios;
using VozDelEsteMaui3.Servicios;
using VozDelEsteMaui3.Servicios.Interfaces;
using VozDelEsteMaui3.ViewModels;
using VozDelEsteMaui3.Vistas;

namespace VozDelEsteMaui3
{
   public static class MauiProgram
   {
      public static MauiApp CreateMauiApp()
      {
         var builder = MauiApp.CreateBuilder();
         builder
             .UseMauiApp<App>()
             .UseMauiCommunityToolkit()
             .ConfigureFonts(fonts =>
             {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
             });
#if DEBUG
         builder.Logging.AddDebug();
#endif

         // ViewModels
         builder.Services.AddTransient<LoginViewModel>();
         builder.Services.AddTransient<RegistroViewModel>();
         builder.Services.AddTransient<MainPageViewModel>();

         // Vistas
         builder.Services.AddTransient<Login>();
         builder.Services.AddTransient<MainPage>();
         builder.Services.AddTransient<Registro>();
         builder.Services.AddTransient<Clima>();
         builder.Services.AddTransient<Cotizaciones>();
         builder.Services.AddTransient<Noticias>();
         builder.Services.AddTransient<Peliculas>();


         // Data
         builder.Services.AddTransient<SQLiteDbContext>();
         builder.Services.AddTransient<IUsuarioRepositorio, UsuarioRepositorio>();

         // Servicios
         builder.Services.AddSingleton<ISesionServicio,SesionServicio>();
         builder.Services.AddTransient<INavegacionServicio,NavegacionServicio>();

         return builder.Build();
      }
   }
}


using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;
using VozDelEsteMaui3.Servicios.Interfaces;
using VozDelEsteMaui3.Vistas;

namespace VozDelEsteMaui3.ViewModels
{
   public class LoginViewModel
   {
      private readonly ISesionServicio _sesionServicio;
      private readonly IServiceProvider _servicios;

      public string Usuario { get; set; }
      public string Clave { get; set; }

      public ICommand LoginCommand { get; }
      public ICommand RegistroCommand { get; }

      public LoginViewModel(ISesionServicio sesion, IServiceProvider services)
      {
         _sesionServicio = sesion;
         _servicios = services;

         LoginCommand = new Command(async () =>
         {
            var success = await _sesionServicio.LoginAsync(Usuario, Clave);
            if (success)
            {
               Application.Current.MainPage = new AppShell();
            }
            else
            {
               await Application.Current.MainPage.DisplayAlert("Error", "Usuario o clave incorrecta", "Ok");
            }
         });

         RegistroCommand = new Command(async () =>
         {
            // Navegar a la página de registro (si existe)
            var registroPage = _servicios.GetRequiredService<Registro>();
            await Application.Current.MainPage.Navigation.PushAsync(registroPage);
         });
      }
   }
}

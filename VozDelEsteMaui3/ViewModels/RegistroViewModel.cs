using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VozDelEsteMaui3.Data.Interfaces;
using VozDelEsteMaui3.Modelos;

namespace VozDelEsteMaui3.ViewModels
{
   public partial class RegistroViewModel : ObservableObject
   {
      private readonly IUsuarioRepositorio _usuarioRepositorio;

      [ObservableProperty]
      private string alias;

      [ObservableProperty]
      private string clave;

      [ObservableProperty]
      private string nombreCompleto;

      [ObservableProperty]
      private string direccion;

      [ObservableProperty]
      private string telefono;

      [ObservableProperty]
      private string email;

      [ObservableProperty]
      private string fotoUrl;

      [ObservableProperty]
      private bool esAdmin;

      public RegistroViewModel(IUsuarioRepositorio usuarioRepositorio)
      {
         this._usuarioRepositorio = usuarioRepositorio;
      }

      [RelayCommand]
      private async Task Registrar() // Genera "RegistrarCommand"
      {
         var nuevoUsuario = new Usuario
         {
            Alias = Alias,
            Clave = Clave,
            NombreCompleto = NombreCompleto,
            Direccion = Direccion,
            Telefono = Telefono,
            Email = Email,
            FotoUrl = FotoUrl,
            EsAdmin = EsAdmin
         };

         // Aquí podrías llamar a tu repositorio para guardar
         var exito = await _usuarioRepositorio.AgregarAsync(nuevoUsuario);
         if (exito) await Application.Current.MainPage.DisplayAlert("Exito","Usuario creado correctamente","OK");
         else await Application.Current.MainPage.DisplayAlert("Error", "Hubo un error", "OK");
      }
   }

}

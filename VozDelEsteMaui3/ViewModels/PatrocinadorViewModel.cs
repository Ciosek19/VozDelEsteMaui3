
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;
using VozDelEsteMaui3.Data.Interfaces;
using VozDelEsteMaui3.Modelos;
using VozDelEsteMaui3.Vistas;

namespace VozDelEsteMaui3.ViewModels
{
   public partial class PatrocinadorViewModel : ObservableObject
   {
      private readonly IPatrocinadorRepositorio _patrocinadorRepositorio;

      [ObservableProperty]
      private List<Patrocinador> patrocinadores;

      public ICommand AgregarPatrocinadorCommand { get;}

      public PatrocinadorViewModel(IPatrocinadorRepositorio patrocinadorRepositorio)
      {
         _patrocinadorRepositorio = patrocinadorRepositorio;

         AgregarPatrocinadorCommand = new Command(async () => await Shell.Current.GoToAsync(nameof(AgregarPatrocinador)));
      }

      public async Task CargarPatrocinadoresAsync()
      {
         Patrocinadores = await _patrocinadorRepositorio.ObtenerTodoAsync();
      }
   }
}

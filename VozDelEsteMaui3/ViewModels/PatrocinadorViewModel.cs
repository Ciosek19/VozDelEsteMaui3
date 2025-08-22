
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;
using VozDelEsteMaui3.Data.Interfaces;
using VozDelEsteMaui3.Modelos;
using VozDelEsteMaui3.Vistas;
using VozDelEsteMaui3.Vistas.Modales;

namespace VozDelEsteMaui3.ViewModels
{
    public partial class PatrocinadorViewModel : ObservableObject
    {
        private readonly IPatrocinadorRepositorio _patrocinadorRepositorio;

        [ObservableProperty]
        private List<Patrocinador> patrocinadores;

        public ICommand AgregarPatrocinadorCommand { get; }
        public ICommand VerUbicacionCommand { get; }
        public ICommand EditarCommand { get; }
        public ICommand EliminarCommand { get; }
        public ICommand GuardarCambiosCommand { get; }
        public ICommand CancelarCommand { get; }


        public PatrocinadorViewModel(IPatrocinadorRepositorio patrocinadorRepositorio)
        {
            _patrocinadorRepositorio = patrocinadorRepositorio;

            AgregarPatrocinadorCommand = new Command(async () => await Shell.Current.GoToAsync(nameof(AgregarPatrocinador)));
            CancelarCommand = new Command(async () => await CerrarModal());
            EditarCommand = new Command<int>(async (id) => await IrPaginaEditarPatrocinador(id));

        }

        public async Task IrPaginaEditarPatrocinador(int id)
        {
            await Shell.Current.GoToAsync($"{nameof(EditarPatrocinador)}?Id={id}");
        }

        public async Task CargarPatrocinadoresAsync()
        {
            Patrocinadores = await _patrocinadorRepositorio.ObtenerTodoAsync();
        }
        private async Task CerrarModal()
        {
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }
    }
}

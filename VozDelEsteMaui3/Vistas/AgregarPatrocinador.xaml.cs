using Microsoft.Maui.Controls.Maps;
using VozDelEsteMaui3.ViewModels;

namespace VozDelEsteMaui3.Vistas;

public partial class AgregarPatrocinador : ContentPage
{
   public AgregarPatrocinador(AgregarPatrocinadorViewModel agregarPatrocinadorViewModel)
   {
      InitializeComponent();

      BindingContext = agregarPatrocinadorViewModel;
   }

   private void OnMapClicked(object sender, MapClickedEventArgs e)
   {
      var lat = e.Location.Latitude;
      var lon = e.Location.Longitude;

      // Mostrar marcador
      Mapa.Pins.Clear();
      Mapa.Pins.Add(new Pin
      {
         Label = "Ubicacion seleccionada",
         Location = e.Location,
         Type = PinType.Place
      });

      // Delegar al ViewModel
      /*if (BindingContext is AgregarPatrocinadorViewModel vm)
      {
         vm.UbicacionSeleccionada = new Coordenadas(lat, lon);
         vm.ValidarUbicacionCommand?.Execute(null);
      }*/
   }

}
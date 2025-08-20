
using CommunityToolkit.Mvvm.ComponentModel;
using SQLite;

namespace VozDelEsteMaui3.Modelos
{
   [Table("Patrocinadores")]
   public partial class Patrocinador : ObservableObject
   {
      [PrimaryKey, AutoIncrement]
      public int Id { get; set; }

      [ObservableProperty]
      [property: NotNull]
      private string nombre;

      [ObservableProperty]
      private string logoUrl = "";

      [ObservableProperty]
      [property: Ignore]
      private Coordenadas direccion;

      public double DireccionLatitud
      {
         get => direccion?.Latitud ?? 0;
         set
         {
            if (direccion == null) direccion = new Coordenadas();
            if (direccion.Latitud != value)
            {
               direccion.Latitud = value;
               OnPropertyChanged(nameof(DireccionLatitud));
            }
         }
      }

      public double DireccionLongitud
      {
         get => direccion?.Longitud ?? 0;
         set
         {
            if (direccion == null) direccion = new Coordenadas();
            if (direccion.Longitud != value)
            {
               direccion.Longitud = value;
               OnPropertyChanged(nameof(DireccionLongitud));
            }
         }
      }

   }

   public partial class Coordenadas : ObservableObject
   {
      [ObservableProperty]
      private double latitud;

      [ObservableProperty]
      private double longitud;
   }
}

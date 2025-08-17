
using VozDelEsteMaui3.Modelos;

namespace VozDelEsteMaui3.Servicios.Interfaces
{
   public interface INavegacionServicio
   {
      void RegistrarRutas();
      Type ObtenerPagina(string ruta);
      IEnumerable<RutaNavegacion> ObtenerRutasMenu();
   }
}


using VozDelEsteMaui3.Modelos;
using VozDelEsteMaui3.Vistas;

namespace VozDelEsteMaui3.Orquestadores.Interfaces
{
   public interface IOrquestadorClima
   {
      Task<ModeloClima> ObtenerClimaActualAsync();
      Task<List<ModeloClima>> ObtenerPronosticoAsync();
   }
}

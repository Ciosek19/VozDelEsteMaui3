
using VozDelEsteMaui3.Modelos;
using VozDelEsteMaui3.Servicios.Interfaces;

namespace VozDelEsteMaui3.Servicios
{
   public class ClimaServicio : IClimaServicio
   {
      public Task<ModeloClima> ConsultarClimaActualAsync()
      {
         throw new NotImplementedException();
      }

      public Task<List<ModeloClima>> ConsultarPronosticoAsync()
      {
         throw new NotImplementedException();
      }
   }
}

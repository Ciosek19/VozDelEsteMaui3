
using VozDelEsteMaui3.Data.Interfaces;
using VozDelEsteMaui3.Modelos;

namespace VozDelEsteMaui3.Data.Repositorios
{
   public class ClimaRepositorio : IClimaRepositorio
   {
      public Task ActualizarPronosticosAsync(List<ModeloClima> nuevos)
      {
         throw new NotImplementedException();
      }

      public Task GuardarClimaActualAsync(ModeloClima modeloClima)
      {
         throw new NotImplementedException();
      }

      public Task<ModeloClima> ObtenerClimaActualAsync()
      {
         throw new NotImplementedException();
      }

      public Task<List<ModeloClima>> PronosticoFuturosAsync()
      {
         throw new NotImplementedException();
      }
   }
}

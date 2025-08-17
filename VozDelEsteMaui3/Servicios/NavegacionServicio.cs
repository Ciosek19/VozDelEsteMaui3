
using VozDelEsteMaui3.Modelos;
using VozDelEsteMaui3.Servicios.Interfaces;
using VozDelEsteMaui3.Vistas;

namespace VozDelEsteMaui3.Servicios
{
   public class NavegacionServicio : INavegacionServicio
   {
      private readonly List<RutaNavegacion> _rutas = new()
      {
         new("//Principal","Inicio","inicio.png",typeof(MainPage),false,false),
         new("//Login","Login","login.png",typeof(Login),true,false),
      };

      public void RegistrarRutas()
      {
         foreach (var ruta in _rutas)
         {
            Routing.RegisterRoute(ruta.Ruta, ruta.Pagina);
         }
      }

      public Type ObtenerPagina(string ruta)
      {
         // Si el FirstOrDefault o la Pagina da nulo, devuelve MainPage
         return _rutas.FirstOrDefault(r => r.Ruta == ruta)?.Pagina ?? typeof(MainPage);
      }

      public IEnumerable<RutaNavegacion> ObtenerRutasMenu()
      {
         return _rutas;
      }

      
   }
}

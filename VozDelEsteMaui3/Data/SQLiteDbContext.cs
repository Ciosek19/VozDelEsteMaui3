
using SQLite;

namespace VozDelEsteMaui3.Data
{
   public class SQLiteDbContext
   {
      private readonly SQLiteAsyncConnection _conexion;
      public SQLiteAsyncConnection Conexion => _conexion;

      public SQLiteDbContext()
      {
         var dbRuta = Path.Combine(FileSystem.AppDataDirectory, "vozdeleste.db3");
         _conexion = new SQLiteAsyncConnection(dbRuta);
      }
   }
}


using System.Configuration;
namespace CapaDatos
{
    class Conexion
    {
        public static string cn = ConfigurationManager.ConnectionStrings["cadena"].ToString();
    }
}

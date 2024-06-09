using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

using System.Data.SqlClient;
using System.Data;
namespace CapaDatos
{
    public class CD_Usuarios
    {
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cn))
                {
                    string query = "SELECT idUsuario, Nombres, Apellidos, Username, Correo, Clave, Reestablecer, Activo FROM Usuario;";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(
                                new Usuario()
                                {
                                    IdUsuario = Convert.ToInt32(dr["idUsuario"]),
                                    Nombres = dr["Nombres"].ToString(),
                                    Apellidos = dr["Apellidos"].ToString(),
                                    NombreUsuario = dr["Username"].ToString(),
                                    Correo = dr["Correo"].ToString(),
                                    Clave = dr["Clave"].ToString(),
                                    Reestablecer = Convert.ToBoolean(dr["Reestablecer"]),
                                    Activo = Convert.ToBoolean(dr["Activo"])
                                });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception (ex) if necessary
                lista = new List<Usuario>
                {
                    new Usuario()
                    {
                        IdUsuario = 0,
                        Nombres = "No encontrado",
                        Apellidos = "No encontrado",
                        NombreUsuario = "No encontrado",
                        Correo = "No encontrado",
                        Clave = "No encontrado",
                        Reestablecer = false,
                        Activo = false
                    }
                };
            }

            return lista;
        }
    }
}

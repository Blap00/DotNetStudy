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
    public class CD_Categoria
    {
        // READ CATEGORIA
        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cn))
                {
                    string query = "select IdCategoria, Descripcion, Activo From Categoria;";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(
                                new Categoria()
                                {
                                    IdCategoria = Convert.ToInt32(dr["IdCategoria"]),
                                    Descripcion = dr["Descripcion"].ToString(),
                                    Activo = Convert.ToBoolean(dr["Activo"])
                                });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception (ex) if necessary
                lista = new List<Categoria>
                {
                    new Categoria()
                    {
                        IdCategoria = 0,
                        Descripcion = "Error: "+ex.ToString(),
                        Activo = false
                    }
                };
            }

            return lista;
        }
        public int GuardarCategoria(Categoria obj, out string Mensaje)
        {
            int idautogenerado = 0;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconeccion = new SqlConnection(Conexion.cn))
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarCategoria", oconeccion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("@Activo", obj.Activo);


                    cmd.Parameters.Add("@Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    oconeccion.Open();
                    cmd.ExecuteNonQuery();

                    idautogenerado = Convert.ToInt32(cmd.Parameters["@Resultado"].Value);
                    Mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idautogenerado = 0;
                Mensaje = ex.Message;
            }
            return idautogenerado;
        }

        //Update Categoria
        public bool EditarCategoria(Categoria obj, out string Mensaje)
        {
            bool idautogenerado = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconeccion = new SqlConnection(Conexion.cn))
                {
                    SqlCommand cmd = new SqlCommand("sp_EditarCategoria", oconeccion);
                    cmd.Parameters.AddWithValue("IdUCategoria", obj.IdCategoria);
                    cmd.Parameters.AddWithValue("Descripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("Activo", obj.Activo);


                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconeccion.Open();

                    cmd.ExecuteNonQuery();

                    idautogenerado = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idautogenerado = false;
                Mensaje = ex.Message;
            }
            return idautogenerado;
        }
        public bool deleteCategoria(int id, out string Mensaje)
        {
            bool resultado = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconeccion = new SqlConnection(Conexion.cn))
                {
                    SqlCommand cmd = new SqlCommand("delete top(1) from Categoria where IdUCategoria = @id", oconeccion);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.CommandType = CommandType.Text;

                    oconeccion.Open();

                    resultado = cmd.ExecuteNonQuery() > 0 ? true : false;

                }
            }
            catch (Exception ex)
            {
                resultado = false;
                Mensaje = ex.Message;
            }
            return resultado;
        }
    }
}

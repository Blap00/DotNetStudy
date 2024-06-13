using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using CapaDatos;

namespace CapaNegocios
{
    public class CN_Usuarios
    {
        private CD_Usuarios objCDUsuarios = new CD_Usuarios();

        public List<Usuario> Listar()
        {
            return objCDUsuarios.Listar();
        }

        public int GuardarUsuario(Usuario obj, out string Mensaje)
        {

            Mensaje = string.Empty;
            if (string.IsNullOrEmpty(obj.Nombres) || string.IsNullOrWhiteSpace(obj.Nombres))
            {
                Mensaje = "Lo nombres de Usuario no puede estar vacio";
            }
            if (string.IsNullOrEmpty(obj.Apellidos) || string.IsNullOrWhiteSpace(obj.Apellidos))
            {
                Mensaje = "Los Apellidos de Usuario no puede estar vacio";
            }
            if (string.IsNullOrEmpty(obj.NombreUsuario) || string.IsNullOrWhiteSpace(obj.NombreUsuario))
            {
                Mensaje = "El Nombre de Usuario no puede estar vacio";
            }
            if (string.IsNullOrEmpty(obj.Correo) || string.IsNullOrWhiteSpace(obj.Correo))
            {
                Mensaje = "El correo de Usuario no puede estar vacio";
            }
            if (string.IsNullOrEmpty(Mensaje))
            {


                string KeyBasic = CN_Recursos.GenerarClave();

                string asunto = "Creación de cuentas en MVC Tienda";

                string mensaje= "<h3>" +
                                    "¡Su cuenta fue creada exitosamente!" +
                                "</h3" +
                                "</br>" +
                                "<p>" +
                                    "Su contraseña para acceder es: <strong>!clave!</strong>" +
                                "</p>";
                mensaje = mensaje.Replace("!clave!", KeyBasic);
                bool answ = CN_Recursos.SendMail(obj.Correo, asunto, mensaje);
                if (answ)
                {
                    obj.Clave = CN_Recursos.EncryptString(KeyBasic);
                    return objCDUsuarios.GuardarUsuario(obj, out Mensaje);
                }
                else
                {
                    Mensaje = "No se logro enviar el correo";
                    return 0;
                }
                
            }
            else
            {
                return 0;
            }
            
        }
        public bool EditarUsuario(Usuario obj, out string Mensaje)
        {

            Mensaje = string.Empty;
            if (string.IsNullOrEmpty(obj.Nombres) || string.IsNullOrWhiteSpace(obj.Nombres))
            {
                Mensaje = "Lo nombres de Usuario no puede estar vacio";
            }
            if (string.IsNullOrEmpty(obj.Apellidos) || string.IsNullOrWhiteSpace(obj.Apellidos))
            {
                Mensaje = "Los Apellidos de Usuario no puede estar vacio";
            }
            if (string.IsNullOrEmpty(obj.NombreUsuario) || string.IsNullOrWhiteSpace(obj.NombreUsuario))
            {
                Mensaje = "El Nombre de Usuario no puede estar vacio";
            }
            if (string.IsNullOrEmpty(obj.Correo) || string.IsNullOrWhiteSpace(obj.Correo))
            {
                Mensaje = "El correo de Usuario no puede estar vacio";
            }
            if (string.IsNullOrEmpty(Mensaje))
            {

                return objCDUsuarios.EditarUsuario(obj, out Mensaje);
            }
            else
            {
                return false;
            }

        }
        public bool EliminarUsuario(int id, out string Mensaje)
        {
            return objCDUsuarios.deleteUsuario(id, out Mensaje);
        }

    }
}

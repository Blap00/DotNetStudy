using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

using System.Net.Mail;
using System.Net;
using System.IO;

namespace CapaNegocios
{
    public class CN_Recursos
    {
        public static string GenerarClave()
        {
            try
            {
                string clave = Guid.NewGuid().ToString("N").Substring(0, 7);
                return clave;
            }
            catch (Exception ex)
            {
                // Puedes registrar o manejar la excepción según sea necesario
                throw new InvalidOperationException("Error al generar la clave única.", ex);
            }
        }

        private static readonly string key = "ABCDEFGHIJKLMNOPQRSTU19283700073"; // La clave debe tener 32 caracteres para AES-256

        public static string EncryptString(string plainText)
        {
            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }
                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }

        public static string DecryptString(string cipherText)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader(cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }
        
        public static bool SendMail(string correo, string asunto, string mensaje)
        {
            bool resultado = false;
            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(correo);
                mail.From = new MailAddress("test1ngm4il001@gmail.com");
                mail.Subject = asunto;
                mail.Body = mensaje;
                mail.IsBodyHtml = true;

                var smtp = new SmtpClient()
                {
                    Credentials = new NetworkCredential("test1ngm4il001@gmail.com", "kwqr kcbu tiub wdxa"),
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true
                };

                smtp.Send(mail);
                resultado = true;
            } catch (Exception ex) {
                var Falsa = ex.ToString();
                resultado = false;
            }
            return resultado;
        }

    }
}

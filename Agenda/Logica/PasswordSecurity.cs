using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Agenda.Logica
{
    public class PasswordSecurity
    {

        public static string GenerarHash(string pass)
        {
            // Convertir la contraseña a un arreglo de bytes
            byte[] bytesContraseña = Encoding.UTF8.GetBytes(pass);

            // Crear un objeto SHA256 para calcular el hash
            using (SHA256 sha256 = SHA256.Create())
            {
                // Calcular el hash de la contraseña
                byte[] bytesHash = sha256.ComputeHash(bytesContraseña);

                // Convertir el hash a una cadena de caracteres hexadecimal
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytesHash)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }

    }
}

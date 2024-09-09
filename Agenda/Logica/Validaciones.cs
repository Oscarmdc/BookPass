using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Agenda.Logica
{
    public class Validaciones
    {

        private static readonly Random random = new Random();

        private const string SpecialCharacters = @"!@#$%^&*()-_=+[]{}<>";
        private const string NumbersValues = "0123456789";
        private const string abc = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public static bool ValidarCorreo(string email)
        {
            string patron = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            Regex regex = new Regex(patron);
            return regex.IsMatch(email); // devuelve true si es correcto
        }

        public static string GeneratePassword(int length, bool includeSpecialChars, bool includeNumbers)
        {
            string alfabeto;
            char[] password = new char[length];

            if (includeSpecialChars && includeNumbers) // Con caracteres especiales y números
            {
                alfabeto = abc + NumbersValues + SpecialCharacters;
            }
            else if (includeSpecialChars) // Con caracteres especiales
            {
                alfabeto = abc + SpecialCharacters;
            }
            else if (includeNumbers) // Con números
            {
                alfabeto = abc + NumbersValues;
            }
            else // Puras letras
            {
                alfabeto = abc;
            }

            int largoAlfabeto = alfabeto.Length;

            for (int i = 0; i < length; i++)
            {
                password[i] = alfabeto[random.Next(0, largoAlfabeto)];
            }

            return new string(password);
        }


        public static bool ValidateNumeroTelefono(string phoneNumber)
        {
            // Eliminar espacios, guiones y paréntesis del número de teléfono
            string cleanedNumber = Regex.Replace(phoneNumber, @"[\s()-]", "");

            // Patrón de expresión regular para validar un número de teléfono de 10 dígitos
            string pattern = @"^\d{10}$";

            // Validar el número de teléfono utilizando la expresión regular
            return Regex.IsMatch(cleanedNumber, pattern);
        }

    }

    public class ValidarCarpeta {

        private string path = "C:\\Program Files\\";
        private string carpeta = "BockPass";

        public ValidarCarpeta() {

            try
            {
                if (!Directory.Exists(path + carpeta))
                {
                    Directory.CreateDirectory(path + carpeta);
                }
            }
            catch (Exception e)
            {

            }
            
        }
    
    }

    public class ValidarBD
    {
        private const string basePath = @"C:\BockPass\";
        private const string dataBasePath = "C:\\BockPass\\BOCKPASS.accdb";

        public ValidarBD()
        {
            try
            {
                if (!Directory.Exists(basePath))
                {
                    Directory.CreateDirectory(basePath);
                    Console.WriteLine("Carpeta de destino creada: " + basePath);
                }
                if (!File.Exists(dataBasePath))
                {
                    
                    createDataBase();
                    CreateTables();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"La base de datos ya existe");
            }
        }

        private void createDataBase()
        {
            try
            {
                // Crear la conexion y el archivo .accdb
                string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dataBasePath};Jet OLEDB:Engine Type=5;";
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error al crear la base de datos: {e.Message}");
            }

        }

        private void CreateTables()
        {
            // Crear las tablas necesarias en la base de datos
            try
            {
                string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dataBasePath};";
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Crear las tablas de la BD
                    string createTableQuery = @"CREATE TABLE Users (
                                            id_user AUTOINCREMENT PRIMARY KEY,
                                            nombre TEXT(255),
                                            paterno TEXT(255),
                                            materno TEXT(255),
                                            email_m TEXT(255),
                                            password_m TEXT(255),
                                            username_m TEXT(255),
                                            phone TEXT(255),
                                            habilitado YESNO
                                            )

                                            CREATE TABLE Emails(
                                            id_email AUTOINCREMENT PRIMARY KEY,
                                            id_user INTEGER,                                            
                                            email TEXT(255),
                                            CONSTRAINT FK_Emails_Users FOREIGN KEY (id_user) REFERENCES Users(id_user)
                                            )

                                            CREATE TABLE Login (
                                            id_login AUTOINCREMENT PRIMARY KEY,
                                            id_usuario INTEGER,
                                            id_correo INTEGER,
                                            password TEXT(255),
                                            username TEXT(255),
                                            web TEXT(255),
                                            descripcion TEXT(255),
                                            fecha_creacion DATETIME,
                                            habilitado YESNO,
                                            CONSTRAINT FK_Logins_Users FOREIGN KEY (id_usuario) REFERENCES Users(id_user),
                                            CONSTRAINT FK_Logins_Emails FOREIGN KEY (id_correo) REFERENCES Emails(id_email)
                                            )
                                            ";

                    using (OleDbCommand command = new OleDbCommand(createTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Tabla 'Usuarios' creada exitosamente.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear las tablas: {ex.Message}");
            }
        }
    }
}

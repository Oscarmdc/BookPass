using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using Agenda.Modelos;
using System.Data;
using System.Configuration;
using System.Configuration.Provider;

namespace Agenda.Logica
{
    public class ConsultasSQL
    {
        private string provider = "Microsoft.ACE.OLEDB.12.0";
        private string basedatos = "C:\\BockPass\\BOCKPASS.accdb";
        // D:\OscarMDC\Escritorio\Agenda\Agenda\Agenda

        private OleDbConnection conn;
        private OleDbCommand comando;

        public bool EstadoConn { get; set; }
        public string MensajeEstado { get; set; }

        public ConsultasSQL()
        {

            //var conString = ConfigurationManager.ConnectionStrings["BOCKPASS"].ConnectionString;
            //conn = new OleDbConnection(conString);
            conn = new OleDbConnection();
            conn.ConnectionString = "Provider=" + provider + ";Data Source=" + basedatos + ";Persist Security Info=False;";
        }

        private void Conectar()
        {
            try
            {
                conn.Open();
                EstadoConn = true;
                MensajeEstado = "Base de datos conectada";
            }
            catch (Exception ex)
            {
                EstadoConn = false;
                MensajeEstado = ex.ToString();
            }
        }

        private void Desconectar()
        {
            try
            {
                conn.Close();
                EstadoConn = false;
                MensajeEstado = "Base de datos desconectada";
            }
            catch (Exception ex)
            {
                EstadoConn = true;
                MensajeEstado = ex.ToString();
            }
        }

        #region Fom1(Ventana de inicio de sesion)
        // Valida que el email y password sean correctos. hace una consulta en la db, si concuerda envia el id en caso contrario envia -1
        public int ValidarInicioSesion(string email, string password)
        {
            int id = -1;
            Conectar(); // Conecto a la base de datos

            if (EstadoConn)
            {
                string hash = PasswordSecurity.GenerarHash(password);

                string consulta = "SELECT Id_user, email_m, password_m FROM Users WHERE email_m = '" + email + "' AND password_m = '" + hash + "';"; // Consulta de los datos de interes

                comando = new OleDbCommand(consulta, conn); // Creo el comando de lectura

                OleDbDataReader leedb = comando.ExecuteReader(); // Creo el objeto que tendra los datos (registros) solicitados
                bool exists = leedb.HasRows; // verifico si el objeto tiene algún registro.
                leedb.Read(); // con esta linea de codigo leo los datos y los guardo en el objeto


                if (exists)
                {
                    try
                    {
                        id = int.Parse(leedb[0].ToString());

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR: " + ex);
                    }
                }
            }
            else
            {
                MessageBox.Show(MensajeEstado);
            }
            
            Desconectar();
            return id;
        }
        #endregion

        #region FormNuevoUsuario
        // Valida si un email ya se encuentra registrado en la db
        public bool ValidarExisteCorreoMaestro(string email) // validamos por email
        {
            Conectar();
            string consulta = "SELECT email_m FROM Users WHERE email_m = '" + email + "'";
            comando = new OleDbCommand(consulta, conn);

            OleDbDataReader leerdb = comando.ExecuteReader();
            bool exists = leerdb.HasRows;

            Desconectar();
            return exists;
        }

        // Registra un nuevo usario
        public void RegistrarNuevoUsuario (UserObjeto user)
        {
            string query = @"INSERT INTO `Users` 
                            (`nombre`, `parterno`, `materno`, `email_m`, `password_m`, `username_m`, `phone_m`, `habilitado`) 
                            VALUES (@nom, @pat, @mat, @email, @pass, @usen, @pho, @hab)";
            
            try
            {
                Conectar();

                comando = new OleDbCommand(query, conn);

                comando.Parameters.AddWithValue("@nom", user.Nombre);
                comando.Parameters.AddWithValue("@pat", user.Paterno);
                comando.Parameters.AddWithValue("@mat", user.Materno);
                comando.Parameters.AddWithValue("@email", user.Email_m);
                comando.Parameters.AddWithValue("@pass", user.Password_m);
                comando.Parameters.AddWithValue("@usen", user.Username_m);
                comando.Parameters.AddWithValue("@pho", user.Phone_m);
                comando.Parameters.AddWithValue("@hab", user.Habilitado);

                int cont = comando.ExecuteNonQuery();

                if (cont > 0)
                {
                    MessageBox.Show("Registro exitoso");
                }
 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar en la base de datos: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }   
        }
        #endregion

        #region FormPrincipal --> login
        // crea un Objeto DataTable con los registros de los logins del usuario activo, retorna una tabla con todos los longis del usuario
        public DataTable ListarLoginsUsuarios(int id)
        {
            Conectar();

            string query = "SELECT Login.id_login, web, Emails.Id_email ,Emails.email, password, username, descripcion " +
                "FROM ((Login " +
                "INNER JOIN Users ON Login.id_usuario = Users.Id_user) " +
                "INNER JOIN Emails ON Login.id_correo = Emails.id_email) " +
                "WHERE Login.id_usuario = " + id + " AND Login.habilitado = true;";

            comando = new OleDbCommand(query, conn);

            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(comando);
            da.SelectCommand = comando;
            da.Fill(dt);

            Desconectar();

            return dt;
        }

        public DataTable ListarLoginsUsuarioFiltrados(int id, string cadena)
        {
            Conectar();

            string query = "SELECT Login.id_login, web, Emails.Id_email ,Emails.email, password, username, descripcion " +
                "FROM ((Login " +
                "INNER JOIN Users ON Login.id_usuario = Users.Id_user) " +
                "INNER JOIN Emails ON Login.id_correo = Emails.id_email) " +
                "WHERE Login.web LIKE '%" +cadena+ "%' OR Emails.email LIKE '%" + cadena+ "%' OR Login.descripcion LIKE '%"+cadena+"%' AND Login.id_usuario = " + id + " AND Login.habilitado = true;";

            comando = new OleDbCommand(query, conn);

            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(comando);
            da.SelectCommand = comando;
            da.Fill(dt);

            Desconectar();

            return dt;
        }

        public void DeshabilitarLogin(LoginObjeto log)
        {
            string query = "UPDATE Login SET Login.[habilitado] = @hab " +
                 "WHERE Login.[Id_login] = " + log.Id_login + ";";
            try
            {
                Conectar();

                comando = new OleDbCommand(query, conn);
                comando.Parameters.AddWithValue("@hab", log.Habilitado);

                int cont = comando.ExecuteNonQuery();

                if (cont > 0)
                {
                    MessageBox.Show("Registro actualizado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }
        #endregion

        #region PopAppLogins --> Nuevo y editar
        // Registra en la base de datos un nuevo login
        public void RegistrarNuevoLogin(LoginObjeto log)
        {
            string query = @"INSERT INTO `Login` 
                            (`id_usuario`, `id_correo`, `password`, `username`, `web`, `descripcion`, `fecha_creacion`, `habilitado`) 
                            VALUES (@id_usuario, @id_correo, @password, @username, @web, @descripcion, @fecha_creacion, @habilitado)";

            try
            {
                Conectar();

                comando = new OleDbCommand(query, conn);

                comando.Parameters.AddWithValue("@id_usuario", log.Id_usuario);
                comando.Parameters.AddWithValue("@id_correo", log.Id_correo);
                comando.Parameters.AddWithValue("@password", log.Password);
                comando.Parameters.AddWithValue("@username", log.Username);
                comando.Parameters.AddWithValue("@web", log.Web);
                comando.Parameters.AddWithValue("@descripcion", log.Descripcion);
                comando.Parameters.AddWithValue("@fecha_creacion", log.FechaCreacion);
                comando.Parameters.AddWithValue("@habilitado", log.Habilitado);

                int cont = comando.ExecuteNonQuery();

                if (cont > 0)
                {
                    MessageBox.Show("Registro exitoso");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar en la base de datos: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public void ActualizarLogin(LoginObjeto log)
        {

            string query = "UPDATE Login SET Login.[id_correo] = @cor, " +
                "Login.[password] = @pas, Login.[username] = @use, Login.[web] = @web, " +
                "Login.[descripcion] = @des WHERE Login.[Id_login] = " + log.Id_login +";";
            try
            {
                Conectar();

                comando = new OleDbCommand(query, conn);
                comando.Parameters.AddWithValue("@cor", log.Id_correo);
                comando.Parameters.AddWithValue("@pas", log.Password);
                comando.Parameters.AddWithValue("@use", log.Username);
                comando.Parameters.AddWithValue("@web", log.Web);
                comando.Parameters.AddWithValue("@des", log.Descripcion);

                int cont = comando.ExecuteNonQuery();

                if (cont > 0)
                {
                    MessageBox.Show("Registro actualizado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        // Regresa una lista de los correos del usuario en sesion
        public List<EmailObjeto> GetListaEmailsUsuario(int id)
        {
            Conectar();

            List<EmailObjeto> listaEmails = new List<EmailObjeto>();
            EmailObjeto om;

            string query = "SELECT Id_email, email FROM Emails WHERE id_user = " + id + " ;";

            comando = new OleDbCommand(query, conn);

            OleDbDataReader leedb = comando.ExecuteReader();

            bool exists = leedb.HasRows; // variable de control para saber lectura tiene 1 o mas registros

            leedb.Read(); // Nos permite leer los registros de la lectura de la base de datos

            // llenamos nuesta lista de objetos Emails con los campos que nos interesa

            while (exists)
            {
                om = new EmailObjeto();
                om.Id_email = int.Parse(leedb[0].ToString());
                om.Email = leedb[1].ToString();

                listaEmails.Add(om); // agregamos un item a nuestra lista

                exists = leedb.Read(); // Leemos la siguiente fila en caso contrario la variable cambia a false y salimos
            }

            Desconectar();

            return listaEmails;
        }
        #endregion

        #region FormNuevoCorreoElectronico --> Agrega un correo electronico al usuario
        // Valida si el correo electronico ya se encuentra registrado
        public bool ValidarCorreoExiste(string correo)
        {
            Conectar();
            string consulta = "SELECT email FROM Emails WHERE email = '" + correo + "'";
            comando = new OleDbCommand(consulta, conn);

            OleDbDataReader leerdb = comando.ExecuteReader();
            bool exists = leerdb.HasRows;

            Desconectar();

            return exists;
        } 

        // Inserta un nuevo correo electronico del usuario en sesion a la base de datos
        public void RegistrarNuevoEmail(EmailObjeto email)
        {
            string query = @"INSERT INTO `Emails` 
                            (`email`, `id_user`) 
                            VALUES (@email, @id_user)";

            try
            {
                Conectar();

                comando = new OleDbCommand(query, conn);

                comando.Parameters.AddWithValue("@email", email.Email);
                comando.Parameters.AddWithValue("@id_user", email.Id_user);

                int cont = comando.ExecuteNonQuery();

                if (cont > 0)
                {
                    MessageBox.Show("Registro exitoso");
                }

                Desconectar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar en la base de datos: " + ex.Message);
            }
        }
        #endregion

        #region PopAppCuenta --> Select[Usuario], Update[Datos Usuario] Update [Contraseña usuario], Delete[Correo], Delete[Cuenta]
        public UserObjeto GetDatosUsuario(int id) // busca en la base de datos el usuario logueado y devuelve un objeto con los datos del usuario
        {
            UserObjeto user = new UserObjeto();

            string query = "SELECT * FROM Users WHERE Id_user = " + id;

            try
            {
                Conectar();
                comando = new OleDbCommand(query, conn);
                OleDbDataReader leedb = comando.ExecuteReader();
                bool exists = leedb.HasRows;
                leedb.Read();

                user.Id_user = int.Parse(leedb[0].ToString());
                user.Nombre = leedb[1].ToString();
                user.Paterno = leedb[2].ToString();
                user.Materno = leedb[3].ToString();
                user.Email_m = leedb[4].ToString();
                user.Password_m = leedb[5].ToString();
                user.Username_m = leedb[6].ToString();
                user.Phone_m = leedb[7].ToString();
                user.Habilitado = bool.Parse(leedb[8].ToString());
                Desconectar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return user;
        }

        public void UpdateDatosCuenta(UserObjeto user)
        {
            string query = "UPDATE Users SET Users.[nombre] = @nombre, " +
                "Users.[parterno] = @paterno, Users.[materno] = @materno, Users.[email_m] = @email, " +
                "Users.[username_m] = @username, Users.[phone_m] = @phone WHERE Users.[Id_user] = " + user.Id_user + ";";
            try
            {
                Conectar();

                comando = new OleDbCommand(query, conn);
                comando.Parameters.AddWithValue("@nombre", user.Nombre);
                comando.Parameters.AddWithValue("@paterno", user.Paterno);
                comando.Parameters.AddWithValue("@materno", user.Materno); 
                comando.Parameters.AddWithValue("@email", user.Email_m);
                comando.Parameters.AddWithValue("@username_m", user.Username_m);
                comando.Parameters.AddWithValue("@phone_m", user.Phone_m);

                int cont = comando.ExecuteNonQuery();

                if (cont > 0)
                {
                    //MessageBox.Show("Registro actualizado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public void UpdatePasswordCuenta(UserObjeto user)
        {
            string query = "UPDATE Users SET Users.[password_m] = @password " +
                "WHERE Users.[Id_user] = " + user.Id_user + ";";

            string hash = PasswordSecurity.GenerarHash(user.Password_m);

            try
            {
                Conectar();

                comando = new OleDbCommand(query, conn);
                comando.Parameters.AddWithValue("@password_m", hash);


                int cont = comando.ExecuteNonQuery();

                if (cont > 0)
                {
                    //MessageBox.Show("Contraseña actualizada");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public void DeleteCuenta(int idUsuario)
        {

        }

        public void EliminarCorreo(int id)
        {
            string query = @"DELETE FROM Emails WHERE Id_email = @id";

            Conectar();

            comando = new OleDbCommand(query, conn);

            comando.Parameters.AddWithValue("@id", id);

            if (comando.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Correo eliminado");
            }
            Desconectar();
        }
        #endregion

        #region PopAppPermiso --> Validar contraseña usuario
        public bool ValidarPasswordUsuario(int id, string password)
        {
            Conectar(); // Conecto a la base de datos

            string hash = PasswordSecurity.GenerarHash(password);

            string consulta = "SELECT password_m FROM Users WHERE Id_user = " + id + " AND password_m = '" + hash + "';"; // Consulta de los datos de interes
            comando = new OleDbCommand(consulta, conn); // Creo el comando de lectura

            OleDbDataReader leedb = comando.ExecuteReader(); // Creo el objeto que tendra los datos (registros) solicitados
            bool valido = leedb.HasRows; // verifico si el objeto tiene algún registro.

            Desconectar();
            return valido;
        }
        #endregion


    }
}

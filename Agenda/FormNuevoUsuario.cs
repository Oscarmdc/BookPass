using Agenda.Logica;
using Agenda.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Agenda
{
    public partial class FormNuevoUsuario : Form
    {
        private ConsultasSQL sql = new ConsultasSQL();


        public FormNuevoUsuario()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validamos los campos nombre y apellidos
            bool nombreCorrecto = validarCampos(txtNombre, "El campo esta vacio.");
            bool peternoCorrecto = validarCampos(txtPaterno, "Este campo es obligatorio.");
            bool maternoCorrecto = validarCampos(txtMaterno, "Este campo es obligatorio.");

            // Validamos que el correo sea correcto y / o no exista en la db
            bool correoCorrecto = validarCorreo(txtEmail.Text);

            // Validamos las contraseñas
            bool passwordCorrecto = validarCampos(txtPassword, "Ingrese una contraseña.");
            bool password2Correcto = validarContraseñas(txtPassword2, "Las contraseñas no coinciden.");

            // Hacemos la insercion en la base de datos el nuevo usuario
            if (nombreCorrecto && correoCorrecto && password2Correcto 
                && peternoCorrecto && maternoCorrecto && passwordCorrecto)
            {
                UserObjeto u = new UserObjeto(); // Creamos un Objeto de tipo usuario

                // Convetimos la contraseña en un hash y la guardamos en una variable
                string hash = PasswordSecurity.GenerarHash(txtPassword.Text);

                u.Nombre = txtNombre.Text;
                u.Paterno = txtPaterno.Text;
                u.Materno = txtMaterno.Text;
                u.Email_m = txtEmail.Text;
                u.Password_m = hash;
                u.Username_m = txtUsername.Text;
                u.Phone_m = txtTelefono.Text;
                u.Habilitado = true;

                sql.RegistrarNuevoUsuario(u); // Hacemos la insercion en la base de datos
            } 
        }

        private bool validarCampos(TextBox control, string mensaje)
        {
            if (control.Text.Equals(""))
            {
                errorDato.SetError(control, mensaje);
                this.DialogResult = DialogResult.None;
                return false;
            }
            else
            {
                errorDato.SetError(control, "");
                return true;
            }
        }

        private bool validarContraseñas(TextBox control, string mensaje )
        {
            if (txtPassword2.Text.Equals(""))
            {
                errorDato.SetError(control, "Repita contraseña");
                this.DialogResult = DialogResult.None;
                return false;
            }
            else if (txtPassword.Text != txtPassword2.Text)
            {
                errorDato.SetError(control, mensaje);
                this.DialogResult = DialogResult.None;
                return false;
            }
            else
            {
                errorDato.SetError(control, "");
                return true;
            }
        }

        private bool validarCorreo(string correo)
        {
            bool correoBienEscrito = Validaciones.ValidarCorreo(correo); // validamos con expreciones regulares
            bool existe = sql.ValidarExisteCorreoMaestro(txtEmail.Text); // validamos que no este registrado en la db

            if (txtEmail.Text.Equals(""))
            {
                errorDato.SetError(txtEmail, "Este campo es obligatorio.");
                this.DialogResult = DialogResult.None;
                return false;
            }
            if (correoBienEscrito.Equals(false))
            {
                errorDato.SetError(txtEmail, "Introdusca un correo valido.");
                this.DialogResult = DialogResult.None;
                return false;
            }
            else if (existe)
            {
                errorDato.SetError(txtEmail, "El email ya se encuentra registrado.");
                this.DialogResult = DialogResult.None;
                return false;
            }
            else
            {
                errorDato.SetError(txtEmail, "");
                return true;
            }

        }
    }
}

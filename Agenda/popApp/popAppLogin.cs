using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agenda.Modelos;
using Agenda.Logica;

namespace Agenda.popAppLogin
{
    public partial class popAppLogin : Form
    {
        private ConsultasSQL sql = new ConsultasSQL();

        private LoginObjeto log = new LoginObjeto();

        public int IdUsuario { get; set; }

        public int Accion { get; set; } // 1: Nuevo login,   2: Editar login

        public popAppLogin(int id, int accion)
        {
            InitializeComponent();
            IdUsuario = id;
            Accion = accion;
        }

        public popAppLogin(int idUsuario, int accion, LoginObjeto logg)
        {
            InitializeComponent();
            IdUsuario = idUsuario;
            Accion = accion;
            log = logg;
        }

        private void popAppNuevoLogin_Load(object sender, EventArgs e)
        {
            llenarCboEmails();

            if (Accion == 1)
            {
                this.Text = "Nuevo login";
            }
            else
            {
                this.Text = "Editar login";
                // Establecemos los valores encontrados
                cboCorreos.SelectedValue = log.Id_correo;
                txtPassword1.Text = log.Password;
                txtPassword2.Text = log.Password;
                txtWeb.Text = log.Web;
                txtUsername.Text = log.Username;
                txtDescripcion.Text = log.Descripcion;
            }
        }

        private void llenarCboEmails()
        {
            cboCorreos.DataSource = sql.GetListaEmailsUsuario(IdUsuario);
            cboCorreos.DisplayMember = "Email";
            cboCorreos.ValueMember = "Id_email";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Accion == 1)
            {
                bool webCorrecto = validarCampo(txtWeb, "Campo obligatorio");
                bool password1Correcot = validarCampo(txtPassword1, "Campo obligatorio");
                bool password2Correcot = validarContraseñas(txtPassword2, "Las contraseñas no coinciden");

                if (password1Correcot && password2Correcot && webCorrecto)
                {
                    log.Id_usuario = IdUsuario;
                    log.Id_correo = (int)cboCorreos.SelectedValue;
                    log.Password = txtPassword1.Text;
                    log.Username = txtUsername.Text;
                    log.Web = txtWeb.Text;
                    log.Descripcion = txtDescripcion.Text;
                    log.FechaCreacion = DateTime.Today;
                    log.Habilitado = true;

                    sql.RegistrarNuevoLogin(log);
                }
                else
                {
                    return;
                }
            }
            else
            {
                // Creamos un nuevo objeto login con los nuevos valores
                bool webCorrecto = validarCampo(txtWeb, "Campo obligatorio");
                bool password1Correcto = validarCampo(txtPassword1, "Campo obligatorio");
                bool password2Correcto = validarContraseñas(txtPassword2, "Las contraseñas no coinciden");

                if (password1Correcto && password2Correcto && webCorrecto)
                {
                    
                    log.Id_correo = (int)cboCorreos.SelectedValue;
                    log.Password = txtPassword1.Text;
                    log.Username = txtUsername.Text;
                    log.Web = txtWeb.Text;
                    log.Descripcion = txtDescripcion.Text;

                    sql.ActualizarLogin(log);
                }
                else
                {
                    return;
                }

            }
            
        }

        private bool validarCampo(TextBox control, string mensaje)
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

        private bool validarContraseñas(TextBox control, string mensaje)
        {
            if (txtPassword2.Text.Equals(""))
            {
                errorDato.SetError(control, "Repita contraseña");
                this.DialogResult = DialogResult.None;
                return false;
            }
            else if (txtPassword1.Text != txtPassword2.Text)
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

        private void btnVerOcultarPassword1_Click(object sender, EventArgs e)
        {
            if (txtPassword1.UseSystemPasswordChar)
            {
                txtPassword1.UseSystemPasswordChar = false;
                btnVerOcultarPassword1.ImageIndex = 1;
                timer.Enabled = true;
                timer.Interval = 5000;
            }
            else
            {
                txtPassword1.UseSystemPasswordChar = true;
                btnVerOcultarPassword1.ImageIndex = 0;
            }
        }

        private void btnVerOcultarPassword2_Click(object sender, EventArgs e)
        {
            if (txtPassword2.UseSystemPasswordChar)
            {
                txtPassword2.UseSystemPasswordChar = false;
                btnVerOcultarPassword2.ImageIndex = 1;
                timer1.Enabled = true;
                timer1.Interval = 5000;
            }
            else
            {
                txtPassword2.UseSystemPasswordChar = true;
                btnVerOcultarPassword2.ImageIndex = 0;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            txtPassword1.UseSystemPasswordChar = true;
            btnVerOcultarPassword1.ImageIndex = 0;
            errorDato.SetError(txtPassword1, "");
            timer.Stop();
            timer.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtPassword2.UseSystemPasswordChar = true;
            btnVerOcultarPassword2.ImageIndex = 0;
            errorDato.SetError(txtPassword2, "");
            timer1.Stop();
            timer1.Enabled = false;
        }

        private void btnGenerarPassword_Click(object sender, EventArgs e)
        {
            int largo = (int)txtLargo.Value;
            bool includeSpecialChars = cbxEspeciales.Checked;
            bool includeNumbers = cbxNumeros.Checked;

            txtPassword1.Text = Validaciones.GeneratePassword(largo, includeSpecialChars, includeNumbers);
            txtPassword2.Text = txtPassword1.Text;
        }
    }
}

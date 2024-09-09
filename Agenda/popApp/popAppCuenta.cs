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


namespace Agenda.popApp
{
    public partial class popAppCuenta : Form
    {
        ConsultasSQL sql = new ConsultasSQL();
        UserObjeto user = new UserObjeto();
        public int Usuario_id { get; set; }

        public popAppCuenta(int id)
        {
            InitializeComponent();
            Usuario_id = id;
        }

        private void popAppCuenta_Load(object sender, EventArgs e)
        {
            user = sql.GetDatosUsuario(Usuario_id);
            LlenarCampos();
            llenarCboEmails();
            //groupBox1.Visible = false;
            txtPassword1.Enabled = false;
            txtPassword1.BackColor = Color.FromArgb(44, 44, 44);
            txtPassword2.Enabled = false;
            txtPassword2.BackColor = Color.FromArgb(44, 44, 44);

        }


        private void LlenarCampos()
        {
            txtNombre.Text = user.Nombre;
            txtPaterno.Text = user.Paterno;
            txtMaterno.Text = user.Materno;
            txtTelefono.Text = user.Phone_m;
            txtUsername.Text = user.Username_m;
            txtCorreoCuenta.Text = user.Email_m;
        }
        private void llenarCboEmails()
        {
            cboCorreos.DataSource = sql.GetListaEmailsUsuario(Usuario_id);
            cboCorreos.DisplayMember = "Email";
            cboCorreos.ValueMember = "Id_email";
        }


        private void btnGuardar_Click(object sender, EventArgs e) // Pendiente
        {
            user.Nombre = txtNombre.Text;
            user.Paterno = txtPaterno.Text;
            user.Materno = txtMaterno.Text;
            user.Phone_m = txtTelefono.Text;
            user.Username_m = txtUsername.Text;
            user.Email_m = txtCorreoCuenta.Text;
            user.Password_m = txtPassword1.Text;

            // validaciones
            bool nombre = ValidarCampo(txtNombre, "Campo obligatorio");
            bool paterno = ValidarCampo(txtPaterno, "Campo obligatorio");
            bool materno = ValidarCampo(txtMaterno, "Campo obligatorio");
            bool correo = validarCorreo(txtCorreoCuenta.Text);
            bool telefono = ValidarTelefono(txtTelefono, "Telefono no valido");
            


            if (nombre && paterno && materno && correo && telefono && txtPassword1.Enabled && txtPassword2.Enabled)
            {
                bool contras = validarContraseñas(txtPassword1, txtPassword2, "Campo obligatorio");
                
                if (contras)
                {
                    sql.UpdateDatosCuenta(user);
                    sql.UpdatePasswordCuenta(user);
                    MessageBox.Show("Contraseña actualizada");

                }
            }
            else if (nombre && paterno && materno && correo && telefono )
            {
                sql.UpdateDatosCuenta(user);
                MessageBox.Show("Datos actualizados");
            }
            else
            {
                //sql.UpdateDatosCuenta(user);
                MessageBox.Show("Error al actualizar los datos");
            }
        }

        private void lblEliminarCuenta_Click(object sender, EventArgs e) // Pendiente
        {

        }
        private void btnEliminarCorreo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar el correo asociado?","Aviso de eliminación", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            {
                sql.EliminarCorreo((int)cboCorreos.SelectedValue);
                llenarCboEmails();
            }
        }
        
        private void btnCambiarContra_Click(object sender, EventArgs e) // Pendiente
        {
            popAppPermiso pop = new popAppPermiso(Usuario_id);
            pop.ShowDialog();
            if (pop.DialogResult.Equals(DialogResult.Yes))
            {

                txtPassword1.Enabled = true; 
                txtPassword1.BackColor = Color.FromArgb(64, 64, 64);
                txtPassword2.Enabled = true;
                txtPassword2.BackColor = Color.FromArgb(64, 64, 64);

            }
        }


        #region Validaciones
        private bool ValidarCampo(TextBox control, string mensaje)
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

        private bool ValidarTelefono(TextBox control, string mensaje) // Pendiente
        {
            bool telefono = Validaciones.ValidateNumeroTelefono(txtTelefono.Text);
            if (telefono == false)
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
            bool existe = sql.ValidarExisteCorreoMaestro(txtCorreoCuenta.Text); // validamos que no este registrado en la db

            if (txtCorreoCuenta.Text.Equals(""))
            {
                errorDato.SetError(txtCorreoCuenta, "Este campo es obligatorio.");
                this.DialogResult = DialogResult.None;
                return false;
            }
            else if (correoBienEscrito.Equals(false))
            {
                errorDato.SetError(txtCorreoCuenta, "Introdusca un correo valido.");
                this.DialogResult = DialogResult.None;
                return false;
            }
            else if (existe)
            {
                if (txtCorreoCuenta.Text.Equals(txtCorreoCuenta.Text))
                {
                    return true;
                }
                else
                {
                    errorDato.SetError(txtCorreoCuenta, "El email ya se encuentra registrado.");
                    this.DialogResult = DialogResult.None;
                    return false;
                }
                
            }
            else
            {
                errorDato.SetError(txtCorreoCuenta, "");
                return true;
            }

        }

        private bool validarContraseñas(TextBox control1, TextBox control2, string mensaje)
        {
            if (control1.Text.Equals(""))
            {
                errorDato.SetError(control1, mensaje);
                this.DialogResult = DialogResult.None;
                return false;
            }
            else
            {
                errorDato.SetError(control1, "");
            }

             if (control2.Text.Equals(""))
            {
                errorDato.SetError(control2, mensaje);
                this.DialogResult = DialogResult.None;
                return false;
            }
            else
            {
                errorDato.SetError(control2, "");
            }
             
            if (control1.Text != control2.Text)
            {
                
                errorDato.SetError(control2, "Las contraseñas no coinciden");
                this.DialogResult = DialogResult.None;
                return false;
            }
            else
            { 
                errorDato.SetError(control1, "");
                errorDato.SetError(control2, "");
                return true;
            }
        }

        private void btnVerOcultarPassword1_Click(object sender, EventArgs e)
        {
            validarBotonPassword(txtPassword1, timer1, btnVerOcultarPassword1);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer(txtPassword1, timer1, btnVerOcultarPassword1, errorDato);
        }

        private void btnVerOcultarPassword2_Click(object sender, EventArgs e)
        {
            validarBotonPassword(txtPassword2, timer2, btnVerOcultarPassword2);
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer(txtPassword2, timer2, btnVerOcultarPassword2, errorDato);
        }

        private void validarBotonPassword(TextBox txt, Timer tim, Button btn)
        {
            if (txt.UseSystemPasswordChar)
            {
                txt.UseSystemPasswordChar = false;
                btn.ImageIndex = 1;
                tim.Enabled = true;
                tim.Interval = 5000;
            }
            else
            {
                txt.UseSystemPasswordChar = true;
                btn.ImageIndex = 0;
            }
        }
        private void timer(TextBox txt, Timer tim, Button btn, ErrorProvider err)
        {
            txt.UseSystemPasswordChar = true;
            btn.ImageIndex = 0;
            err.SetError(txt, "");
            tim.Stop();
            tim.Enabled = false;
        }
        #endregion

    }
}

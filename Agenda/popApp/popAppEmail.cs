using Agenda.Modelos;
using Agenda.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda.popAppLogin
{
    public partial class popAppEmail : Form
    {
        ConsultasSQL sql = new ConsultasSQL();

        private int IdUsuario;

        public popAppEmail(int id)
        {
            InitializeComponent();
            IdUsuario = id;
            lblAviso.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultasSQL sql = new ConsultasSQL();
            EmailObjeto email = new EmailObjeto();

            // validar que el correo no exista en la base de datos y que este bien escrito
            if (validarCorreo(txtCorreo.Text))
            {
                email.Email = txtCorreo.Text;
                email.Id_user = IdUsuario;

                sql.RegistrarNuevoEmail(email);
            }
            else
            {
                lblAviso.Visible = true;
                timer.Enabled = true;
                timer.Interval = 4000;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblAviso.Visible = false;
            timer.Stop();
            timer.Enabled = false;
        }

        private bool validarCorreo(string correo)
        {
            bool correoBienEscrito = Validaciones.ValidarCorreo(correo); // validamos con expreciones regulares
            bool existe = sql.ValidarCorreoExiste(txtCorreo.Text); // validamos que no este registrado en la db

            if (txtCorreo.Text.Equals(""))
            {
                errorDato.SetError(txtCorreo, "Este campo es obligatorio.");
                this.DialogResult = DialogResult.None;
                return false;
            }
            else if (correoBienEscrito.Equals(false))
            {
                errorDato.SetError(txtCorreo, "Introdusca un correo valido.");
                this.DialogResult = DialogResult.None;
                return false;
            }
            else if (existe)
            {
                errorDato.SetError(txtCorreo, "El email ya se encuentra registrado.");
                this.DialogResult = DialogResult.None;
                return false;
            }
            else
            {
                errorDato.SetError(txtCorreo, "");
                return true;
            }
        }
    }
}

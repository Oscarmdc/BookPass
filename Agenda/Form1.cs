using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Agenda.Logica;

namespace Agenda
{
    public partial class Form1 : Form
    {

        private int Usuario_id { get; set; }

        public Form1()
        {
            InitializeComponent();
            ValidarBD validarDB = new ValidarBD();
            lblError.Visible = false;
        }

        private void lblNuevaCuenta_Click(object sender, EventArgs e)
        {
            FormNuevoUsuario pop = new FormNuevoUsuario();
            pop.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtUsuario.Text;
            string pass = txtPassword.Text;

            Logica.ConsultasSQL sql = new Logica.ConsultasSQL();

            Usuario_id = sql.ValidarInicioSesion(email, pass); // Validamos sesion y rescatamos el id del usuario

            if (Usuario_id != -1)
            {
                this.Hide();
                FormPrincipal formPrincipal = new FormPrincipal(Usuario_id);
                formPrincipal.ShowDialog();
                if (formPrincipal.DialogResult.Equals(DialogResult.OK))
                {
                    this.Show();
                }
                txtPassword.Clear();
            }
            else
            {
                lblError.Visible = true;
                timer.Enabled = true;
                timer.Interval = 4000;
            } 
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblError.Visible = false;
            timer.Stop();
            timer.Enabled = false;
        }
    }
}

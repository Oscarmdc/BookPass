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

namespace Agenda.popApp
{
    public partial class popAppPermiso : Form
    {
        private int idUsuario;
        private int intentos = 3;

        public popAppPermiso(int id)
        {
            InitializeComponent();
            this.idUsuario = id;
            lblAviso.Text = $"Contraseña incorrecta, intentos restantes: {intentos}";
            lblAviso.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ConsultasSQL sql = new ConsultasSQL();
            bool valido = sql.ValidarPasswordUsuario(idUsuario, txtPass.Text);

            if (intentos == 0)
            {
                btnAceptar.BackColor = Color.DarkOliveGreen;
                btnAceptar.ForeColor = Color.DarkGreen;
                btnAceptar.Enabled = false;
                lblAviso.Text = "Ha alcanzado el número de intentos permitidos";
                timer.Enabled = true;
                timer.Interval = 3000;
                timer.Start();
                
            }
            else if (valido == false)
            {
                intentos--;
                lblAviso.Visible = true;
                lblAviso.Text = $"Contraseña incorrecta, intentos restantes: {intentos}";
            }
            else
            {
                this.DialogResult = DialogResult.Yes;
            }
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Enabled = false;
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

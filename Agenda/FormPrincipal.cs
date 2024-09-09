using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agenda.Logica;
using Agenda.Modelos;
using Agenda.popApp;
using Agenda.popAppLogin;

namespace Agenda
{
    public partial class FormPrincipal : Form
    {

        ConsultasSQL sql = new ConsultasSQL();

        private int Usuario_id { get; set; } // Id del usuario actual. 
        private bool SesionActiva { get; set; } // Si es true la sesion esta activa

        public FormPrincipal( int id)
        {
            Usuario_id = id;
            SesionActiva = true;
            InitializeComponent();
        }

        private int SumarDosNumeros(int num1, int num2)
        {
            return num1 * num2; 
            
        }


        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            ListarLogins();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            txtFiltro.Clear();
            ListarLogins();
        }

        private void btnNuevoLogin_Click(object sender, EventArgs e)
        {
            popAppLogin.popAppLogin pop = new popAppLogin.popAppLogin(Usuario_id, 1);
            
            pop.ShowDialog();
            if (pop.DialogResult.Equals(DialogResult.OK))
            {
                ListarLogins();
            }
        }

        private void btnEditarLogin_Click(object sender, EventArgs e) 
        {
            if (dgvListaLogins.CurrentRow != null )
            {
                LoginObjeto log = new LoginObjeto
                {
                    Id_usuario = Usuario_id,
                    Id_login = (int)dgvListaLogins.CurrentRow.Cells["id"].Value,
                    Web = dgvListaLogins.CurrentRow.Cells["Web"].Value.ToString(),
                    Id_correo = (int)dgvListaLogins.CurrentRow.Cells["id_correo"].Value,
                    Password = dgvListaLogins.CurrentRow.Cells["Contraseña"].Value.ToString(),
                    Username = dgvListaLogins.CurrentRow.Cells["Username"].Value.ToString(),
                    Descripcion = dgvListaLogins.CurrentRow.Cells["Descripción"].Value.ToString(),
                };

                popAppLogin.popAppLogin pop = new popAppLogin.popAppLogin(Usuario_id, 2, log);

                pop.ShowDialog();
                if (pop.DialogResult.Equals(DialogResult.OK))
                {
                    ListarLogins();
                }
            }
        }

        private void btnEliminarLogin_Click(object sender, EventArgs e) // Pendiente
        {
            if (dgvListaLogins.CurrentRow != null)
            {

                if (MessageBox.Show("Deseas eliminar la entrada", "Aviso de eliminación", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
                {
                    LoginObjeto log = new LoginObjeto
                    {
                        Id_login = (int)dgvListaLogins.CurrentRow.Cells["id"].Value,
                        Habilitado = false
                    };

                    sql.DeshabilitarLogin(log);
                    txtCorreo.Clear();
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtDescripcion.Clear();
                    txtWeb.Clear();
                    ListarLogins();
                }
            }
        }

        private void btnAgregarEmail_Click(object sender, EventArgs e)
        {
            popAppEmail pop = new popAppEmail(Usuario_id);
            pop.Show();
            
        }

        private void btnConfCuenta_Click(object sender, EventArgs e) // Pendiente
        {
            popAppCuenta pop = new popAppCuenta(Usuario_id);
            pop.ShowDialog();

        } 

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseas cerrar sesión", "Cerrar sesion", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            {
                this.DialogResult = DialogResult.OK;
            }


        }

        private void dgbListaLogins_CellClick(object sender, DataGridViewCellEventArgs e) // llena los campos del login escogido de la lista
        {
            txtWeb.UseSystemPasswordChar = false;
            lblVerOcultarPassword.Text = "Ver contraseña";

            if (e.RowIndex >= 0 && e.RowIndex < dgvListaLogins.Rows.Count)
            {
                string web = dgvListaLogins.CurrentRow.Cells["Web"].Value.ToString();
                string correo = dgvListaLogins.CurrentRow.Cells["Correo"].Value.ToString();
                string password = dgvListaLogins.CurrentRow.Cells["Contraseña"].Value.ToString();
                string username = dgvListaLogins.CurrentRow.Cells["Username"].Value.ToString();
                string descripcion = dgvListaLogins.CurrentRow.Cells["Descripción"].Value.ToString();

                txtCorreo.Text = correo;
                txtPassword.Text = password;
                txtUsername.Text = username;
                txtWeb.Text = web;
                txtDescripcion.Text = descripcion;
            }
        }

        private void btnVerOcultarPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
                lblVerOcultarPassword.Text = "Ocultar contraseña";
                btnVerOcultarPassword.ImageIndex = 1;
                timer.Enabled = true;
                timer.Interval = 5000;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                lblVerOcultarPassword.Text = "Ver contraseña";
                btnVerOcultarPassword.ImageIndex = 0;
            }
        } // Oculta o muestra la contraseña

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dtTem = new DataTable();

            dtTem.Columns.Add("id", typeof(int));               // 0
            dtTem.Columns.Add("Web", typeof(string));           // 1
            dtTem.Columns.Add("id_correo", typeof(int));        // 2
            dtTem.Columns.Add("Correo", typeof(string));        // 3
            dtTem.Columns.Add("Contraseña", typeof(string));    // 4
            dtTem.Columns.Add("Username", typeof(string));      // 5
            dtTem.Columns.Add("Descripción", typeof(string));   // 6

            foreach (DataRow row in sql.ListarLoginsUsuarioFiltrados(Usuario_id, txtFiltro.Text).Rows)
            {
                int id = Convert.ToInt32(row["id_login"]);
                string web = row["web"].ToString();
                int idCorreo = Convert.ToInt32(row["Id_email"]);
                string usuario = row["email"].ToString();
                string contrasena = row["password"].ToString();
                string userName = row["username"].ToString();
                string descripcion = row["descripcion"].ToString();

                dtTem.Rows.Add(id, web, idCorreo, usuario, contrasena, userName, descripcion);
            }

            dgvListaLogins.DataSource = dtTem;
            dgvListaLogins.Columns[0].Visible = false;
            dgvListaLogins.Columns[2].Visible = false;
            dgvListaLogins.Columns[4].Visible = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            lblVerOcultarPassword.Text = "Ver contraseña";
            btnVerOcultarPassword.ImageIndex = 0;
            timer.Stop();
            timer.Enabled = false;
        }

        private void ListarLogins()
        {

            DataTable dtTem = new DataTable();

            dtTem.Columns.Add("id", typeof(int));               // 0
            dtTem.Columns.Add("Web", typeof(string));           // 1
            dtTem.Columns.Add("id_correo", typeof(int));        // 2
            dtTem.Columns.Add("Correo", typeof(string));        // 3
            dtTem.Columns.Add("Contraseña", typeof(string));    // 4
            dtTem.Columns.Add("Username", typeof(string));      // 5
            dtTem.Columns.Add("Descripción", typeof(string));   // 6

            foreach (DataRow row in sql.ListarLoginsUsuarios(Usuario_id).Rows)
            {
                int id = Convert.ToInt32(row["id_login"]);
                string web = row["web"].ToString();
                int idCorreo = Convert.ToInt32(row["Id_email"]);
                string usuario = row["email"].ToString();
                string contrasena = row["password"].ToString();
                string userName = row["username"].ToString();
                string descripcion = row["descripcion"].ToString();

                dtTem.Rows.Add(id, web, idCorreo, usuario, contrasena, userName, descripcion);
            }

            dgvListaLogins.DataSource = dtTem;
            dgvListaLogins.Columns[0].Visible = false;
            dgvListaLogins.Columns[2].Visible = false;
            dgvListaLogins.Columns[4].Visible = false;
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}

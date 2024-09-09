
namespace Agenda
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.imageListBotones = new System.Windows.Forms.ImageList(this.components);
            this.btnEditarLogin = new System.Windows.Forms.Button();
            this.btnConfCuenta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminarLogin = new System.Windows.Forms.Button();
            this.btnAgregarEmail = new System.Windows.Forms.Button();
            this.btnNuevoLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlCabezera = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dgvListaLogins = new System.Windows.Forms.DataGridView();
            this.pnlPieDePagina = new System.Windows.Forms.Panel();
            this.lblVerOcultarPassword = new System.Windows.Forms.Label();
            this.btnVerOcultarPassword = new System.Windows.Forms.Button();
            this.imageListPassword = new System.Windows.Forms.ImageList(this.components);
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWeb = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlCabezera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaLogins)).BeginInit();
            this.pnlPieDePagina.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnLogin);
            this.pnlHeader.Controls.Add(this.btnEditarLogin);
            this.pnlHeader.Controls.Add(this.btnConfCuenta);
            this.pnlHeader.Controls.Add(this.btnSalir);
            this.pnlHeader.Controls.Add(this.btnEliminarLogin);
            this.pnlHeader.Controls.Add(this.btnAgregarEmail);
            this.pnlHeader.Controls.Add(this.btnNuevoLogin);
            this.pnlHeader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(194, 544);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.DarkGray;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.ImageKey = "sopa.png";
            this.btnLogin.ImageList = this.imageListBotones;
            this.btnLogin.Location = new System.Drawing.Point(15, 11);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(169, 68);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // imageListBotones
            // 
            this.imageListBotones.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListBotones.ImageStream")));
            this.imageListBotones.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListBotones.Images.SetKeyName(0, "ajustes.png");
            this.imageListBotones.Images.SetKeyName(1, "basura_64.png");
            this.imageListBotones.Images.SetKeyName(2, "editar.png");
            this.imageListBotones.Images.SetKeyName(3, "en.png");
            this.imageListBotones.Images.SetKeyName(4, "globo.png");
            this.imageListBotones.Images.SetKeyName(5, "salir-alt_64.png");
            this.imageListBotones.Images.SetKeyName(6, "sopa.png");
            // 
            // btnEditarLogin
            // 
            this.btnEditarLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditarLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarLogin.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarLogin.ForeColor = System.Drawing.Color.DarkGray;
            this.btnEditarLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarLogin.ImageKey = "editar.png";
            this.btnEditarLogin.ImageList = this.imageListBotones;
            this.btnEditarLogin.Location = new System.Drawing.Point(15, 159);
            this.btnEditarLogin.Name = "btnEditarLogin";
            this.btnEditarLogin.Size = new System.Drawing.Size(169, 68);
            this.btnEditarLogin.TabIndex = 6;
            this.btnEditarLogin.Text = "Editar Login";
            this.btnEditarLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarLogin.UseVisualStyleBackColor = false;
            this.btnEditarLogin.Click += new System.EventHandler(this.btnEditarLogin_Click);
            // 
            // btnConfCuenta
            // 
            this.btnConfCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConfCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfCuenta.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfCuenta.ForeColor = System.Drawing.Color.DarkGray;
            this.btnConfCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfCuenta.ImageKey = "ajustes.png";
            this.btnConfCuenta.ImageList = this.imageListBotones;
            this.btnConfCuenta.Location = new System.Drawing.Point(15, 381);
            this.btnConfCuenta.Name = "btnConfCuenta";
            this.btnConfCuenta.Size = new System.Drawing.Size(169, 68);
            this.btnConfCuenta.TabIndex = 2;
            this.btnConfCuenta.Text = "Cuenta";
            this.btnConfCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfCuenta.UseVisualStyleBackColor = false;
            this.btnConfCuenta.Click += new System.EventHandler(this.btnConfCuenta_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.DarkGray;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.ImageKey = "salir-alt_64.png";
            this.btnSalir.ImageList = this.imageListBotones;
            this.btnSalir.Location = new System.Drawing.Point(15, 455);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(169, 68);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Cerrar sesión";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminarLogin
            // 
            this.btnEliminarLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminarLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarLogin.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarLogin.ForeColor = System.Drawing.Color.DarkGray;
            this.btnEliminarLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarLogin.ImageKey = "basura_64.png";
            this.btnEliminarLogin.ImageList = this.imageListBotones;
            this.btnEliminarLogin.Location = new System.Drawing.Point(15, 233);
            this.btnEliminarLogin.Name = "btnEliminarLogin";
            this.btnEliminarLogin.Size = new System.Drawing.Size(169, 68);
            this.btnEliminarLogin.TabIndex = 4;
            this.btnEliminarLogin.Text = "Eliminar Login";
            this.btnEliminarLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarLogin.UseVisualStyleBackColor = false;
            this.btnEliminarLogin.Click += new System.EventHandler(this.btnEliminarLogin_Click);
            // 
            // btnAgregarEmail
            // 
            this.btnAgregarEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregarEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarEmail.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEmail.ForeColor = System.Drawing.Color.DarkGray;
            this.btnAgregarEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarEmail.ImageKey = "en.png";
            this.btnAgregarEmail.ImageList = this.imageListBotones;
            this.btnAgregarEmail.Location = new System.Drawing.Point(15, 307);
            this.btnAgregarEmail.Name = "btnAgregarEmail";
            this.btnAgregarEmail.Size = new System.Drawing.Size(169, 68);
            this.btnAgregarEmail.TabIndex = 3;
            this.btnAgregarEmail.Text = "Agregar email";
            this.btnAgregarEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarEmail.UseVisualStyleBackColor = false;
            this.btnAgregarEmail.Click += new System.EventHandler(this.btnAgregarEmail_Click);
            // 
            // btnNuevoLogin
            // 
            this.btnNuevoLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNuevoLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevoLogin.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoLogin.ForeColor = System.Drawing.Color.DarkGray;
            this.btnNuevoLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoLogin.ImageKey = "globo.png";
            this.btnNuevoLogin.ImageList = this.imageListBotones;
            this.btnNuevoLogin.Location = new System.Drawing.Point(15, 85);
            this.btnNuevoLogin.Name = "btnNuevoLogin";
            this.btnNuevoLogin.Size = new System.Drawing.Size(169, 68);
            this.btnNuevoLogin.TabIndex = 2;
            this.btnNuevoLogin.Text = "Nuevo Login";
            this.btnNuevoLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoLogin.UseVisualStyleBackColor = false;
            this.btnNuevoLogin.Click += new System.EventHandler(this.btnNuevoLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aplication / Web:";
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.pnlCabezera);
            this.pnlBody.Controls.Add(this.dgvListaLogins);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(194, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(833, 544);
            this.pnlBody.TabIndex = 1;
            // 
            // pnlCabezera
            // 
            this.pnlCabezera.Controls.Add(this.btnBuscar);
            this.pnlCabezera.Controls.Add(this.txtFiltro);
            this.pnlCabezera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabezera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabezera.Name = "pnlCabezera";
            this.pnlCabezera.Size = new System.Drawing.Size(833, 53);
            this.pnlCabezera.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(734, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 26);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.ForeColor = System.Drawing.Color.White;
            this.txtFiltro.Location = new System.Drawing.Point(11, 14);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(717, 24);
            this.txtFiltro.TabIndex = 2;
            // 
            // dgvListaLogins
            // 
            this.dgvListaLogins.AllowUserToAddRows = false;
            this.dgvListaLogins.AllowUserToDeleteRows = false;
            this.dgvListaLogins.AllowUserToOrderColumns = true;
            this.dgvListaLogins.AllowUserToResizeColumns = false;
            this.dgvListaLogins.AllowUserToResizeRows = false;
            this.dgvListaLogins.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaLogins.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.dgvListaLogins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaLogins.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListaLogins.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaLogins.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvListaLogins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaLogins.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvListaLogins.EnableHeadersVisualStyles = false;
            this.dgvListaLogins.Location = new System.Drawing.Point(6, 59);
            this.dgvListaLogins.Name = "dgvListaLogins";
            this.dgvListaLogins.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaLogins.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvListaLogins.RowHeadersVisible = false;
            this.dgvListaLogins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaLogins.Size = new System.Drawing.Size(811, 321);
            this.dgvListaLogins.TabIndex = 0;
            this.dgvListaLogins.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbListaLogins_CellClick);
            // 
            // pnlPieDePagina
            // 
            this.pnlPieDePagina.Controls.Add(this.lblVerOcultarPassword);
            this.pnlPieDePagina.Controls.Add(this.btnVerOcultarPassword);
            this.pnlPieDePagina.Controls.Add(this.txtDescripcion);
            this.pnlPieDePagina.Controls.Add(this.label5);
            this.pnlPieDePagina.Controls.Add(this.txtUsername);
            this.pnlPieDePagina.Controls.Add(this.label4);
            this.pnlPieDePagina.Controls.Add(this.txtWeb);
            this.pnlPieDePagina.Controls.Add(this.txtCorreo);
            this.pnlPieDePagina.Controls.Add(this.txtPassword);
            this.pnlPieDePagina.Controls.Add(this.label3);
            this.pnlPieDePagina.Controls.Add(this.label2);
            this.pnlPieDePagina.Controls.Add(this.label1);
            this.pnlPieDePagina.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPieDePagina.Location = new System.Drawing.Point(194, 353);
            this.pnlPieDePagina.Name = "pnlPieDePagina";
            this.pnlPieDePagina.Size = new System.Drawing.Size(833, 191);
            this.pnlPieDePagina.TabIndex = 2;
            // 
            // lblVerOcultarPassword
            // 
            this.lblVerOcultarPassword.AutoSize = true;
            this.lblVerOcultarPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerOcultarPassword.Location = new System.Drawing.Point(390, 88);
            this.lblVerOcultarPassword.Name = "lblVerOcultarPassword";
            this.lblVerOcultarPassword.Size = new System.Drawing.Size(99, 16);
            this.lblVerOcultarPassword.TabIndex = 10;
            this.lblVerOcultarPassword.Text = "Ver contraseña";
            // 
            // btnVerOcultarPassword
            // 
            this.btnVerOcultarPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVerOcultarPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerOcultarPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerOcultarPassword.ImageKey = "ojo_24.png";
            this.btnVerOcultarPassword.ImageList = this.imageListPassword;
            this.btnVerOcultarPassword.Location = new System.Drawing.Point(352, 84);
            this.btnVerOcultarPassword.Name = "btnVerOcultarPassword";
            this.btnVerOcultarPassword.Size = new System.Drawing.Size(32, 24);
            this.btnVerOcultarPassword.TabIndex = 6;
            this.btnVerOcultarPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerOcultarPassword.UseVisualStyleBackColor = false;
            this.btnVerOcultarPassword.Click += new System.EventHandler(this.btnVerOcultarPassword_Click);
            // 
            // imageListPassword
            // 
            this.imageListPassword.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListPassword.ImageStream")));
            this.imageListPassword.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListPassword.Images.SetKeyName(0, "ojo_24.png");
            this.imageListPassword.Images.SetKeyName(1, "ojo-cruzado_24.png");
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.White;
            this.txtDescripcion.Location = new System.Drawing.Point(541, 30);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(276, 137);
            this.txtDescripcion.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(536, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Descripción:";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(352, 30);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(178, 24);
            this.txtUsername.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(347, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Username:";
            // 
            // txtWeb
            // 
            this.txtWeb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtWeb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeb.ForeColor = System.Drawing.Color.White;
            this.txtWeb.Location = new System.Drawing.Point(11, 143);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.ReadOnly = true;
            this.txtWeb.Size = new System.Drawing.Size(519, 24);
            this.txtWeb.TabIndex = 5;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.White;
            this.txtCorreo.Location = new System.Drawing.Point(11, 30);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ReadOnly = true;
            this.txtCorreo.Size = new System.Drawing.Size(330, 24);
            this.txtCorreo.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(11, 84);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(330, 24);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Correo:";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1027, 544);
            this.Controls.Add(this.pnlPieDePagina);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookPass";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlCabezera.ResumeLayout(false);
            this.pnlCabezera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaLogins)).EndInit();
            this.pnlPieDePagina.ResumeLayout(false);
            this.pnlPieDePagina.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnAgregarEmail;
        private System.Windows.Forms.Button btnNuevoLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlPieDePagina;
        private System.Windows.Forms.Button btnEliminarLogin;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvListaLogins;
        private System.Windows.Forms.Button btnConfCuenta;
        private System.Windows.Forms.Label lblVerOcultarPassword;
        private System.Windows.Forms.Button btnVerOcultarPassword;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWeb;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditarLogin;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ImageList imageListBotones;
        private System.Windows.Forms.Panel pnlCabezera;
        private System.Windows.Forms.ImageList imageListPassword;
    }
}
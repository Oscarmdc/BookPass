
namespace Agenda.popAppLogin
{
    partial class popAppLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(popAppLogin));
            this.cboCorreos = new System.Windows.Forms.ComboBox();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.txtWeb = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorDato = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnVerOcultarPassword1 = new System.Windows.Forms.Button();
            this.btnVerOcultarPassword2 = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageListPassword = new System.Windows.Forms.ImageList(this.components);
            this.btnGenerarPassword = new System.Windows.Forms.Button();
            this.cbxNumeros = new System.Windows.Forms.CheckBox();
            this.cbxEspeciales = new System.Windows.Forms.CheckBox();
            this.txtLargo = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorDato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLargo)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCorreos
            // 
            this.cboCorreos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboCorreos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCorreos.ForeColor = System.Drawing.Color.White;
            this.cboCorreos.FormattingEnabled = true;
            this.cboCorreos.Location = new System.Drawing.Point(12, 36);
            this.cboCorreos.Name = "cboCorreos";
            this.cboCorreos.Size = new System.Drawing.Size(472, 26);
            this.cboCorreos.TabIndex = 0;
            // 
            // txtPassword1
            // 
            this.txtPassword1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword1.ForeColor = System.Drawing.Color.White;
            this.txtPassword1.Location = new System.Drawing.Point(12, 101);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.Size = new System.Drawing.Size(220, 24);
            this.txtPassword1.TabIndex = 1;
            this.txtPassword1.UseSystemPasswordChar = true;
            // 
            // txtPassword2
            // 
            this.txtPassword2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword2.ForeColor = System.Drawing.Color.White;
            this.txtPassword2.Location = new System.Drawing.Point(264, 101);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(220, 24);
            this.txtPassword2.TabIndex = 2;
            this.txtPassword2.UseSystemPasswordChar = true;
            // 
            // txtWeb
            // 
            this.txtWeb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtWeb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWeb.ForeColor = System.Drawing.Color.White;
            this.txtWeb.Location = new System.Drawing.Point(12, 240);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(472, 24);
            this.txtWeb.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(12, 305);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(217, 24);
            this.txtUsername.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.ForeColor = System.Drawing.Color.White;
            this.txtDescripcion.Location = new System.Drawing.Point(12, 370);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(472, 73);
            this.txtDescripcion.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnGuardar.Location = new System.Drawing.Point(373, 463);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(111, 57);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.Location = new System.Drawing.Point(247, 463);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 57);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Correo electronico:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Repetir contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Página web / Aplicación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Username:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Descripción:";
            // 
            // errorDato
            // 
            this.errorDato.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorDato.ContainerControl = this;
            // 
            // btnVerOcultarPassword1
            // 
            this.btnVerOcultarPassword1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVerOcultarPassword1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerOcultarPassword1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerOcultarPassword1.ForeColor = System.Drawing.Color.DimGray;
            this.btnVerOcultarPassword1.ImageKey = "ojo_24.png";
            this.btnVerOcultarPassword1.ImageList = this.imageListPassword;
            this.btnVerOcultarPassword1.Location = new System.Drawing.Point(201, 101);
            this.btnVerOcultarPassword1.Name = "btnVerOcultarPassword1";
            this.btnVerOcultarPassword1.Size = new System.Drawing.Size(31, 24);
            this.btnVerOcultarPassword1.TabIndex = 14;
            this.btnVerOcultarPassword1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerOcultarPassword1.UseVisualStyleBackColor = false;
            this.btnVerOcultarPassword1.Click += new System.EventHandler(this.btnVerOcultarPassword1_Click);
            // 
            // btnVerOcultarPassword2
            // 
            this.btnVerOcultarPassword2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVerOcultarPassword2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerOcultarPassword2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerOcultarPassword2.ForeColor = System.Drawing.Color.DimGray;
            this.btnVerOcultarPassword2.ImageKey = "ojo_24.png";
            this.btnVerOcultarPassword2.ImageList = this.imageListPassword;
            this.btnVerOcultarPassword2.Location = new System.Drawing.Point(453, 101);
            this.btnVerOcultarPassword2.Name = "btnVerOcultarPassword2";
            this.btnVerOcultarPassword2.Size = new System.Drawing.Size(31, 24);
            this.btnVerOcultarPassword2.TabIndex = 15;
            this.btnVerOcultarPassword2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerOcultarPassword2.UseVisualStyleBackColor = false;
            this.btnVerOcultarPassword2.Click += new System.EventHandler(this.btnVerOcultarPassword2_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageListPassword
            // 
            this.imageListPassword.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListPassword.ImageStream")));
            this.imageListPassword.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListPassword.Images.SetKeyName(0, "ojo_24.png");
            this.imageListPassword.Images.SetKeyName(1, "ojo-cruzado_24.png");
            // 
            // btnGenerarPassword
            // 
            this.btnGenerarPassword.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnGenerarPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerarPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarPassword.Location = new System.Drawing.Point(13, 141);
            this.btnGenerarPassword.Name = "btnGenerarPassword";
            this.btnGenerarPassword.Size = new System.Drawing.Size(162, 26);
            this.btnGenerarPassword.TabIndex = 16;
            this.btnGenerarPassword.Text = "Generar contraseña";
            this.btnGenerarPassword.UseVisualStyleBackColor = false;
            this.btnGenerarPassword.Click += new System.EventHandler(this.btnGenerarPassword_Click);
            // 
            // cbxNumeros
            // 
            this.cbxNumeros.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbxNumeros.Location = new System.Drawing.Point(291, 141);
            this.cbxNumeros.Name = "cbxNumeros";
            this.cbxNumeros.Size = new System.Drawing.Size(80, 75);
            this.cbxNumeros.TabIndex = 17;
            this.cbxNumeros.Text = "Números";
            this.cbxNumeros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbxNumeros.UseVisualStyleBackColor = true;
            // 
            // cbxEspeciales
            // 
            this.cbxEspeciales.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbxEspeciales.Location = new System.Drawing.Point(388, 141);
            this.cbxEspeciales.Name = "cbxEspeciales";
            this.cbxEspeciales.Size = new System.Drawing.Size(92, 75);
            this.cbxEspeciales.TabIndex = 18;
            this.cbxEspeciales.Text = "Caracteres especiales";
            this.cbxEspeciales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cbxEspeciales.UseVisualStyleBackColor = true;
            // 
            // txtLargo
            // 
            this.txtLargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLargo.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtLargo.ForeColor = System.Drawing.Color.White;
            this.txtLargo.Location = new System.Drawing.Point(181, 141);
            this.txtLargo.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.txtLargo.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.txtLargo.Name = "txtLargo";
            this.txtLargo.Size = new System.Drawing.Size(91, 24);
            this.txtLargo.TabIndex = 19;
            this.txtLargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLargo.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(183, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 35);
            this.label7.TabIndex = 20;
            this.label7.Text = "Tamaño";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // popAppLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(492, 532);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLargo);
            this.Controls.Add(this.cbxEspeciales);
            this.Controls.Add(this.cbxNumeros);
            this.Controls.Add(this.btnGenerarPassword);
            this.Controls.Add(this.btnVerOcultarPassword2);
            this.Controls.Add(this.btnVerOcultarPassword1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtWeb);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.txtPassword1);
            this.Controls.Add(this.cboCorreos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "popAppLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.popAppNuevoLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorDato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLargo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCorreos;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.TextBox txtWeb;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorDato;
        private System.Windows.Forms.Button btnVerOcultarPassword2;
        private System.Windows.Forms.Button btnVerOcultarPassword1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageListPassword;
        private System.Windows.Forms.Button btnGenerarPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txtLargo;
        private System.Windows.Forms.CheckBox cbxEspeciales;
        private System.Windows.Forms.CheckBox cbxNumeros;
    }
}
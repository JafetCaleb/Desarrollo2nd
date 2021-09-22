
namespace Tutoria
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltutoria = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblTipoIngreso = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.rjcbTIpo = new Tutoria.RJCONTROLES.RJComboBox();
            this.llblRecuperacion = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbltutoria
            // 
            this.lbltutoria.AutoSize = true;
            this.lbltutoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lbltutoria.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbltutoria.Location = new System.Drawing.Point(89, 94);
            this.lbltutoria.Name = "lbltutoria";
            this.lbltutoria.Size = new System.Drawing.Size(164, 37);
            this.lbltutoria.TabIndex = 0;
            this.lbltutoria.Text = "TUTORIA";
            this.lbltutoria.Click += new System.EventHandler(this.lbltutoria_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUsuario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUsuario.Location = new System.Drawing.Point(10, 282);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 20);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblContraseña.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblContraseña.Location = new System.Drawing.Point(6, 317);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(92, 20);
            this.lblContraseña.TabIndex = 4;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.MediumBlue;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUsuario.ForeColor = System.Drawing.Color.Silver;
            this.txtUsuario.Location = new System.Drawing.Point(135, 282);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(169, 19);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Text = "Ingrese Usuario";
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.MediumBlue;
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtContraseña.ForeColor = System.Drawing.Color.Silver;
            this.txtContraseña.Location = new System.Drawing.Point(135, 317);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(169, 19);
            this.txtContraseña.TabIndex = 3;
            this.txtContraseña.Text = "Ingrese Contraseña";
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // lblTipoIngreso
            // 
            this.lblTipoIngreso.AutoSize = true;
            this.lblTipoIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTipoIngreso.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTipoIngreso.Location = new System.Drawing.Point(10, 244);
            this.lblTipoIngreso.Name = "lblTipoIngreso";
            this.lblTipoIngreso.Size = new System.Drawing.Size(119, 20);
            this.lblTipoIngreso.TabIndex = 5;
            this.lblTipoIngreso.Text = "Tipo de Ingreso";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(118, 346);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(88, 33);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCerrar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCerrar.Location = new System.Drawing.Point(283, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(32, 32);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // rjcbTIpo
            // 
            this.rjcbTIpo.BackColor = System.Drawing.Color.MediumBlue;
            this.rjcbTIpo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rjcbTIpo.BorderSize = 0;
            this.rjcbTIpo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjcbTIpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjcbTIpo.ForeColor = System.Drawing.Color.Silver;
            this.rjcbTIpo.IconColor = System.Drawing.Color.Silver;
            this.rjcbTIpo.Items.AddRange(new object[] {
            "Tutor",
            "Alumno",
            "Administrador"});
            this.rjcbTIpo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjcbTIpo.ListTextColor = System.Drawing.Color.Silver;
            this.rjcbTIpo.Location = new System.Drawing.Point(135, 245);
            this.rjcbTIpo.MinimumSize = new System.Drawing.Size(169, 19);
            this.rjcbTIpo.Name = "rjcbTIpo";
            this.rjcbTIpo.Size = new System.Drawing.Size(169, 19);
            this.rjcbTIpo.TabIndex = 1;
            this.rjcbTIpo.Texts = "";
            this.rjcbTIpo.OnSelectedIndexChanged += new System.EventHandler(this.rjComboBox1_OnSelectedIndexChanged);
            // 
            // llblRecuperacion
            // 
            this.llblRecuperacion.AutoSize = true;
            this.llblRecuperacion.Location = new System.Drawing.Point(93, 387);
            this.llblRecuperacion.Name = "llblRecuperacion";
            this.llblRecuperacion.Size = new System.Drawing.Size(133, 13);
            this.llblRecuperacion.TabIndex = 8;
            this.llblRecuperacion.TabStop = true;
            this.llblRecuperacion.Text = "¿Se olvido su contraseña?";
            this.llblRecuperacion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblRecuperacion_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(316, 409);
            this.Controls.Add(this.llblRecuperacion);
            this.Controls.Add(this.rjcbTIpo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblTipoIngreso);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lbltutoria);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltutoria;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblTipoIngreso;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCerrar;
        private RJCONTROLES.RJComboBox rjcbTIpo;
        private System.Windows.Forms.LinkLabel llblRecuperacion;
    }
}


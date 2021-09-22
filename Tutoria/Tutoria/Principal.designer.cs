
namespace Tutoria
{
    partial class Principal
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.Meno = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnActividades = new System.Windows.Forms.Button();
            this.btnTutorias = new System.Windows.Forms.Button();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.btnTutores = new System.Windows.Forms.Button();
            this.lblMaterno = new System.Windows.Forms.Label();
            this.lblPaterno = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.dgvTutores = new System.Windows.Forms.DataGridView();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCambiarContraseña = new System.Windows.Forms.Button();
            this.Meno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LightCyan;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLogout.ForeColor = System.Drawing.Color.DarkRed;
            this.btnLogout.Location = new System.Drawing.Point(11, 350);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(159, 32);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Salir";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Meno
            // 
            this.Meno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Meno.BackColor = System.Drawing.Color.Navy;
            this.Meno.Controls.Add(this.btnCambiarContraseña);
            this.Meno.Controls.Add(this.btnEditar);
            this.Meno.Controls.Add(this.btnActividades);
            this.Meno.Controls.Add(this.btnTutorias);
            this.Meno.Controls.Add(this.btnAlumnos);
            this.Meno.Controls.Add(this.btnTutores);
            this.Meno.Controls.Add(this.lblMaterno);
            this.Meno.Controls.Add(this.lblPaterno);
            this.Meno.Controls.Add(this.lblNombres);
            this.Meno.Controls.Add(this.lblCodigo);
            this.Meno.Controls.Add(this.btnLogout);
            this.Meno.Location = new System.Drawing.Point(0, 0);
            this.Meno.Name = "Meno";
            this.Meno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Meno.Size = new System.Drawing.Size(182, 394);
            this.Meno.TabIndex = 9;
            this.Meno.Paint += new System.Windows.Forms.PaintEventHandler(this.Meno_Paint);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.LightCyan;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEditar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnEditar.Location = new System.Drawing.Point(11, 268);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(160, 32);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.Text = "Editar Datos";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnActividades
            // 
            this.btnActividades.BackColor = System.Drawing.Color.LightCyan;
            this.btnActividades.FlatAppearance.BorderSize = 0;
            this.btnActividades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnActividades.ForeColor = System.Drawing.Color.DarkRed;
            this.btnActividades.Location = new System.Drawing.Point(11, 198);
            this.btnActividades.Name = "btnActividades";
            this.btnActividades.Size = new System.Drawing.Size(159, 32);
            this.btnActividades.TabIndex = 16;
            this.btnActividades.Text = "Actividades";
            this.btnActividades.UseVisualStyleBackColor = false;
            this.btnActividades.Click += new System.EventHandler(this.btnProximas_Click);
            // 
            // btnTutorias
            // 
            this.btnTutorias.BackColor = System.Drawing.Color.LightCyan;
            this.btnTutorias.FlatAppearance.BorderSize = 0;
            this.btnTutorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTutorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTutorias.ForeColor = System.Drawing.Color.DarkRed;
            this.btnTutorias.Location = new System.Drawing.Point(12, 161);
            this.btnTutorias.Name = "btnTutorias";
            this.btnTutorias.Size = new System.Drawing.Size(159, 32);
            this.btnTutorias.TabIndex = 15;
            this.btnTutorias.Text = "Tutorias";
            this.btnTutorias.UseVisualStyleBackColor = false;
            this.btnTutorias.Click += new System.EventHandler(this.btnTutorias_Click);
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.BackColor = System.Drawing.Color.LightCyan;
            this.btnAlumnos.FlatAppearance.BorderSize = 0;
            this.btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAlumnos.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAlumnos.Location = new System.Drawing.Point(11, 121);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(159, 32);
            this.btnAlumnos.TabIndex = 14;
            this.btnAlumnos.Text = "Alumnos";
            this.btnAlumnos.UseVisualStyleBackColor = false;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // btnTutores
            // 
            this.btnTutores.BackColor = System.Drawing.Color.LightCyan;
            this.btnTutores.FlatAppearance.BorderSize = 0;
            this.btnTutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTutores.ForeColor = System.Drawing.Color.DarkRed;
            this.btnTutores.Location = new System.Drawing.Point(11, 84);
            this.btnTutores.Name = "btnTutores";
            this.btnTutores.Size = new System.Drawing.Size(159, 32);
            this.btnTutores.TabIndex = 13;
            this.btnTutores.Text = "Turores";
            this.btnTutores.UseVisualStyleBackColor = false;
            this.btnTutores.Click += new System.EventHandler(this.btnTutores_Click);
            // 
            // lblMaterno
            // 
            this.lblMaterno.AutoSize = true;
            this.lblMaterno.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMaterno.ForeColor = System.Drawing.Color.White;
            this.lblMaterno.Location = new System.Drawing.Point(12, 63);
            this.lblMaterno.Name = "lblMaterno";
            this.lblMaterno.Size = new System.Drawing.Size(69, 21);
            this.lblMaterno.TabIndex = 12;
            this.lblMaterno.Text = "Materno";
            // 
            // lblPaterno
            // 
            this.lblPaterno.AutoSize = true;
            this.lblPaterno.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPaterno.ForeColor = System.Drawing.Color.White;
            this.lblPaterno.Location = new System.Drawing.Point(12, 45);
            this.lblPaterno.Name = "lblPaterno";
            this.lblPaterno.Size = new System.Drawing.Size(63, 21);
            this.lblPaterno.TabIndex = 11;
            this.lblPaterno.Text = "Paterno";
            this.lblPaterno.Click += new System.EventHandler(this.lblPaterno_Click);
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNombres.ForeColor = System.Drawing.Color.White;
            this.lblNombres.Location = new System.Drawing.Point(12, 27);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(75, 21);
            this.lblNombres.TabIndex = 10;
            this.lblNombres.Text = "Nombres";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(12, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(60, 21);
            this.lblCodigo.TabIndex = 9;
            this.lblCodigo.Text = "Codigo";
            // 
            // dgvTutores
            // 
            this.dgvTutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTutores.Location = new System.Drawing.Point(187, 62);
            this.dgvTutores.Name = "dgvTutores";
            this.dgvTutores.ReadOnly = true;
            this.dgvTutores.RowTemplate.Height = 25;
            this.dgvTutores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTutores.Size = new System.Drawing.Size(529, 320);
            this.dgvTutores.TabIndex = 10;
            this.dgvTutores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTutores_CellContentClick);
            this.dgvTutores.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvTutores_MouseDoubleClick);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblBuscar.Location = new System.Drawing.Point(231, 16);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(56, 21);
            this.lblBuscar.TabIndex = 11;
            this.lblBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBuscar.Location = new System.Drawing.Point(284, 14);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(151, 29);
            this.txtBuscar.TabIndex = 12;
            this.txtBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAgregar.Location = new System.Drawing.Point(582, 9);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 33);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.BackColor = System.Drawing.Color.LightCyan;
            this.btnCambiarContraseña.FlatAppearance.BorderSize = 0;
            this.btnCambiarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCambiarContraseña.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCambiarContraseña.Location = new System.Drawing.Point(11, 309);
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.Size = new System.Drawing.Size(160, 32);
            this.btnCambiarContraseña.TabIndex = 19;
            this.btnCambiarContraseña.Text = "Contraseña";
            this.btnCambiarContraseña.UseVisualStyleBackColor = false;
            this.btnCambiarContraseña.Click += new System.EventHandler(this.btnCambiarContraseña_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(719, 394);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.dgvTutores);
            this.Controls.Add(this.Meno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.Meno.ResumeLayout(false);
            this.Meno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel Meno;
        private System.Windows.Forms.Label lblMaterno;
        private System.Windows.Forms.Label lblPaterno;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnActividades;
        private System.Windows.Forms.Button btnTutorias;
        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.Button btnTutores;
        private System.Windows.Forms.DataGridView dgvTutores;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCambiarContraseña;
    }
}
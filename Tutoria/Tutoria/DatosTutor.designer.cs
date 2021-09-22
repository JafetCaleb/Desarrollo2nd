
namespace Tutoria
{
    partial class DatosTutor
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
            this.btCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblCodTutor = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblPaterno = new System.Windows.Forms.Label();
            this.lblMaterno = new System.Windows.Forms.Label();
            this.lblSituacion = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCodTutor = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtPaterno = new System.Windows.Forms.TextBox();
            this.txtMaterno = new System.Windows.Forms.TextBox();
            this.rjcbSituacion = new Tutoria.RJCONTROLES.RJComboBox();
            this.rjcbEstado = new Tutoria.RJCONTROLES.RJComboBox();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btCancelar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btCancelar.ForeColor = System.Drawing.Color.Navy;
            this.btCancelar.Location = new System.Drawing.Point(12, 202);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(88, 28);
            this.btCancelar.TabIndex = 0;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnGuardar.ForeColor = System.Drawing.Color.Navy;
            this.btnGuardar.Location = new System.Drawing.Point(207, 202);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 28);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblCodTutor
            // 
            this.lblCodTutor.AutoSize = true;
            this.lblCodTutor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCodTutor.ForeColor = System.Drawing.Color.White;
            this.lblCodTutor.Location = new System.Drawing.Point(10, 16);
            this.lblCodTutor.Name = "lblCodTutor";
            this.lblCodTutor.Size = new System.Drawing.Size(75, 21);
            this.lblCodTutor.TabIndex = 2;
            this.lblCodTutor.Text = "CodTutor";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNombres.ForeColor = System.Drawing.Color.White;
            this.lblNombres.Location = new System.Drawing.Point(10, 46);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(75, 21);
            this.lblNombres.TabIndex = 3;
            this.lblNombres.Text = "Nombres";
            // 
            // lblPaterno
            // 
            this.lblPaterno.AutoSize = true;
            this.lblPaterno.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPaterno.ForeColor = System.Drawing.Color.White;
            this.lblPaterno.Location = new System.Drawing.Point(10, 76);
            this.lblPaterno.Name = "lblPaterno";
            this.lblPaterno.Size = new System.Drawing.Size(124, 21);
            this.lblPaterno.TabIndex = 4;
            this.lblPaterno.Text = "Apellido Paterno";
            // 
            // lblMaterno
            // 
            this.lblMaterno.AutoSize = true;
            this.lblMaterno.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMaterno.ForeColor = System.Drawing.Color.White;
            this.lblMaterno.Location = new System.Drawing.Point(10, 106);
            this.lblMaterno.Name = "lblMaterno";
            this.lblMaterno.Size = new System.Drawing.Size(130, 21);
            this.lblMaterno.TabIndex = 5;
            this.lblMaterno.Text = "Apellido Materno";
            // 
            // lblSituacion
            // 
            this.lblSituacion.AutoSize = true;
            this.lblSituacion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSituacion.ForeColor = System.Drawing.Color.White;
            this.lblSituacion.Location = new System.Drawing.Point(11, 136);
            this.lblSituacion.Name = "lblSituacion";
            this.lblSituacion.Size = new System.Drawing.Size(74, 21);
            this.lblSituacion.TabIndex = 6;
            this.lblSituacion.Text = "Situacion";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(11, 166);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(56, 21);
            this.lblEstado.TabIndex = 7;
            this.lblEstado.Text = "Estado";
            // 
            // txtCodTutor
            // 
            this.txtCodTutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtCodTutor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodTutor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCodTutor.ForeColor = System.Drawing.Color.Silver;
            this.txtCodTutor.Location = new System.Drawing.Point(140, 12);
            this.txtCodTutor.Name = "txtCodTutor";
            this.txtCodTutor.Size = new System.Drawing.Size(152, 22);
            this.txtCodTutor.TabIndex = 8;
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombres.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNombres.ForeColor = System.Drawing.Color.Silver;
            this.txtNombres.Location = new System.Drawing.Point(140, 42);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(152, 22);
            this.txtNombres.TabIndex = 9;
            // 
            // txtPaterno
            // 
            this.txtPaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtPaterno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPaterno.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPaterno.ForeColor = System.Drawing.Color.Silver;
            this.txtPaterno.Location = new System.Drawing.Point(140, 73);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(152, 22);
            this.txtPaterno.TabIndex = 10;
            // 
            // txtMaterno
            // 
            this.txtMaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtMaterno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaterno.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMaterno.ForeColor = System.Drawing.Color.Silver;
            this.txtMaterno.Location = new System.Drawing.Point(140, 102);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(152, 22);
            this.txtMaterno.TabIndex = 11;
            // 
            // rjcbSituacion
            // 
            this.rjcbSituacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rjcbSituacion.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjcbSituacion.BorderSize = 0;
            this.rjcbSituacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjcbSituacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjcbSituacion.ForeColor = System.Drawing.Color.Silver;
            this.rjcbSituacion.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjcbSituacion.Items.AddRange(new object[] {
            "Contratado",
            "Nombrado"});
            this.rjcbSituacion.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjcbSituacion.ListTextColor = System.Drawing.Color.DimGray;
            this.rjcbSituacion.Location = new System.Drawing.Point(139, 134);
            this.rjcbSituacion.MinimumSize = new System.Drawing.Size(152, 22);
            this.rjcbSituacion.Name = "rjcbSituacion";
            this.rjcbSituacion.Size = new System.Drawing.Size(152, 22);
            this.rjcbSituacion.TabIndex = 12;
            this.rjcbSituacion.Texts = "";
            // 
            // rjcbEstado
            // 
            this.rjcbEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rjcbEstado.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjcbEstado.BorderSize = 0;
            this.rjcbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjcbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjcbEstado.ForeColor = System.Drawing.Color.Silver;
            this.rjcbEstado.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjcbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.rjcbEstado.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjcbEstado.ListTextColor = System.Drawing.Color.DimGray;
            this.rjcbEstado.Location = new System.Drawing.Point(140, 164);
            this.rjcbEstado.MinimumSize = new System.Drawing.Size(152, 22);
            this.rjcbEstado.Name = "rjcbEstado";
            this.rjcbEstado.Size = new System.Drawing.Size(152, 22);
            this.rjcbEstado.TabIndex = 13;
            this.rjcbEstado.Texts = "";
            // 
            // DatosTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(305, 243);
            this.Controls.Add(this.rjcbEstado);
            this.Controls.Add(this.rjcbSituacion);
            this.Controls.Add(this.txtMaterno);
            this.Controls.Add(this.txtPaterno);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtCodTutor);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblSituacion);
            this.Controls.Add(this.lblMaterno);
            this.Controls.Add(this.lblPaterno);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblCodTutor);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatosTutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatosTutor";
            this.Load += new System.EventHandler(this.DatosTutor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblCodTutor;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblPaterno;
        private System.Windows.Forms.Label lblMaterno;
        private System.Windows.Forms.Label lblSituacion;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCodTutor;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtPaterno;
        private System.Windows.Forms.TextBox txtMaterno;
        private RJCONTROLES.RJComboBox rjcbSituacion;
        private RJCONTROLES.RJComboBox rjcbEstado;
    }
}
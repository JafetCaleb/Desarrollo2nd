
namespace Tutoria
{
    partial class DatosAlumno
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
            this.txtMaterno = new System.Windows.Forms.TextBox();
            this.txtPaterno = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtCodAlumno = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblSituacion = new System.Windows.Forms.Label();
            this.lblMaterno = new System.Windows.Forms.Label();
            this.lblPaterno = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblCodAlumno = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.lclCodTutor = new System.Windows.Forms.Label();
            this.rjcbSituacion = new Tutoria.RJCONTROLES.RJComboBox();
            this.rjcbEstado = new Tutoria.RJCONTROLES.RJComboBox();
            this.rjcbCodTutor = new Tutoria.RJCONTROLES.RJComboBox();
            this.cbVacio = new System.Windows.Forms.CheckBox();
            this.rjcbNombreTutor = new Tutoria.RJCONTROLES.RJComboBox();
            this.SuspendLayout();
            // 
            // txtMaterno
            // 
            this.txtMaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtMaterno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaterno.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMaterno.ForeColor = System.Drawing.Color.Silver;
            this.txtMaterno.Location = new System.Drawing.Point(143, 117);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(165, 22);
            this.txtMaterno.TabIndex = 29;
            // 
            // txtPaterno
            // 
            this.txtPaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtPaterno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPaterno.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPaterno.ForeColor = System.Drawing.Color.Silver;
            this.txtPaterno.Location = new System.Drawing.Point(143, 82);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(165, 22);
            this.txtPaterno.TabIndex = 28;
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombres.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNombres.ForeColor = System.Drawing.Color.Silver;
            this.txtNombres.Location = new System.Drawing.Point(143, 47);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(165, 22);
            this.txtNombres.TabIndex = 27;
            // 
            // txtCodAlumno
            // 
            this.txtCodAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtCodAlumno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodAlumno.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCodAlumno.ForeColor = System.Drawing.Color.Silver;
            this.txtCodAlumno.Location = new System.Drawing.Point(143, 12);
            this.txtCodAlumno.Name = "txtCodAlumno";
            this.txtCodAlumno.Size = new System.Drawing.Size(165, 22);
            this.txtCodAlumno.TabIndex = 26;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(9, 190);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(56, 21);
            this.lblEstado.TabIndex = 25;
            this.lblEstado.Text = "Estado";
            // 
            // lblSituacion
            // 
            this.lblSituacion.AutoSize = true;
            this.lblSituacion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSituacion.ForeColor = System.Drawing.Color.White;
            this.lblSituacion.Location = new System.Drawing.Point(10, 155);
            this.lblSituacion.Name = "lblSituacion";
            this.lblSituacion.Size = new System.Drawing.Size(74, 21);
            this.lblSituacion.TabIndex = 24;
            this.lblSituacion.Text = "Situacion";
            // 
            // lblMaterno
            // 
            this.lblMaterno.AutoSize = true;
            this.lblMaterno.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMaterno.ForeColor = System.Drawing.Color.White;
            this.lblMaterno.Location = new System.Drawing.Point(10, 120);
            this.lblMaterno.Name = "lblMaterno";
            this.lblMaterno.Size = new System.Drawing.Size(130, 21);
            this.lblMaterno.TabIndex = 23;
            this.lblMaterno.Text = "Apellido Materno";
            // 
            // lblPaterno
            // 
            this.lblPaterno.AutoSize = true;
            this.lblPaterno.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPaterno.ForeColor = System.Drawing.Color.White;
            this.lblPaterno.Location = new System.Drawing.Point(9, 85);
            this.lblPaterno.Name = "lblPaterno";
            this.lblPaterno.Size = new System.Drawing.Size(124, 21);
            this.lblPaterno.TabIndex = 22;
            this.lblPaterno.Text = "Apellido Paterno";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNombres.ForeColor = System.Drawing.Color.White;
            this.lblNombres.Location = new System.Drawing.Point(9, 50);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(75, 21);
            this.lblNombres.TabIndex = 21;
            this.lblNombres.Text = "Nombres";
            // 
            // lblCodAlumno
            // 
            this.lblCodAlumno.AutoSize = true;
            this.lblCodAlumno.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCodAlumno.ForeColor = System.Drawing.Color.White;
            this.lblCodAlumno.Location = new System.Drawing.Point(9, 15);
            this.lblCodAlumno.Name = "lblCodAlumno";
            this.lblCodAlumno.Size = new System.Drawing.Size(93, 21);
            this.lblCodAlumno.TabIndex = 20;
            this.lblCodAlumno.Text = "CodAlumno";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnGuardar.ForeColor = System.Drawing.Color.Navy;
            this.btnGuardar.Location = new System.Drawing.Point(197, 295);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(111, 28);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btCancelar.ForeColor = System.Drawing.Color.Navy;
            this.btCancelar.Location = new System.Drawing.Point(12, 295);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(88, 28);
            this.btCancelar.TabIndex = 18;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // lclCodTutor
            // 
            this.lclCodTutor.AutoSize = true;
            this.lclCodTutor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lclCodTutor.ForeColor = System.Drawing.Color.White;
            this.lclCodTutor.Location = new System.Drawing.Point(9, 224);
            this.lclCodTutor.Name = "lclCodTutor";
            this.lclCodTutor.Size = new System.Drawing.Size(75, 21);
            this.lclCodTutor.TabIndex = 34;
            this.lclCodTutor.Text = "CodTutor";
            // 
            // rjcbSituacion
            // 
            this.rjcbSituacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rjcbSituacion.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjcbSituacion.BorderSize = 0;
            this.rjcbSituacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjcbSituacion.ForeColor = System.Drawing.Color.Silver;
            this.rjcbSituacion.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjcbSituacion.Items.AddRange(new object[] {
            "Riesgo",
            "No riesgo"});
            this.rjcbSituacion.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjcbSituacion.ListTextColor = System.Drawing.Color.DimGray;
            this.rjcbSituacion.Location = new System.Drawing.Point(143, 152);
            this.rjcbSituacion.MinimumSize = new System.Drawing.Size(152, 22);
            this.rjcbSituacion.Name = "rjcbSituacion";
            this.rjcbSituacion.Size = new System.Drawing.Size(165, 22);
            this.rjcbSituacion.TabIndex = 36;
            this.rjcbSituacion.Texts = "";
            // 
            // rjcbEstado
            // 
            this.rjcbEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rjcbEstado.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjcbEstado.BorderSize = 0;
            this.rjcbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjcbEstado.ForeColor = System.Drawing.Color.Silver;
            this.rjcbEstado.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjcbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.rjcbEstado.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjcbEstado.ListTextColor = System.Drawing.Color.DimGray;
            this.rjcbEstado.Location = new System.Drawing.Point(142, 187);
            this.rjcbEstado.MinimumSize = new System.Drawing.Size(152, 22);
            this.rjcbEstado.Name = "rjcbEstado";
            this.rjcbEstado.Size = new System.Drawing.Size(165, 22);
            this.rjcbEstado.TabIndex = 37;
            this.rjcbEstado.Texts = "";
            // 
            // rjcbCodTutor
            // 
            this.rjcbCodTutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rjcbCodTutor.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjcbCodTutor.BorderSize = 0;
            this.rjcbCodTutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjcbCodTutor.ForeColor = System.Drawing.Color.Silver;
            this.rjcbCodTutor.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjcbCodTutor.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjcbCodTutor.ListTextColor = System.Drawing.Color.DimGray;
            this.rjcbCodTutor.Location = new System.Drawing.Point(143, 223);
            this.rjcbCodTutor.MinimumSize = new System.Drawing.Size(152, 22);
            this.rjcbCodTutor.Name = "rjcbCodTutor";
            this.rjcbCodTutor.Size = new System.Drawing.Size(165, 22);
            this.rjcbCodTutor.TabIndex = 38;
            this.rjcbCodTutor.Texts = "";
            this.rjcbCodTutor.OnSelectedIndexChanged += new System.EventHandler(this.rjcbCodTutor_OnSelectedIndexChanged);
            // 
            // cbVacio
            // 
            this.cbVacio.AutoSize = true;
            this.cbVacio.Location = new System.Drawing.Point(118, 231);
            this.cbVacio.Name = "cbVacio";
            this.cbVacio.Size = new System.Drawing.Size(15, 14);
            this.cbVacio.TabIndex = 40;
            this.cbVacio.UseVisualStyleBackColor = true;
            this.cbVacio.CheckedChanged += new System.EventHandler(this.cbVacio_CheckedChanged);
            // 
            // rjcbNombreTutor
            // 
            this.rjcbNombreTutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rjcbNombreTutor.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjcbNombreTutor.BorderSize = 0;
            this.rjcbNombreTutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjcbNombreTutor.ForeColor = System.Drawing.Color.Silver;
            this.rjcbNombreTutor.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjcbNombreTutor.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.rjcbNombreTutor.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjcbNombreTutor.ListTextColor = System.Drawing.Color.DimGray;
            this.rjcbNombreTutor.Location = new System.Drawing.Point(14, 251);
            this.rjcbNombreTutor.MinimumSize = new System.Drawing.Size(152, 22);
            this.rjcbNombreTutor.Name = "rjcbNombreTutor";
            this.rjcbNombreTutor.Size = new System.Drawing.Size(293, 22);
            this.rjcbNombreTutor.TabIndex = 41;
            this.rjcbNombreTutor.Texts = "";
            this.rjcbNombreTutor.OnSelectedIndexChanged += new System.EventHandler(this.rjcbNombreTutor_OnSelectedIndexChanged);
            // 
            // DatosAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(319, 340);
            this.Controls.Add(this.rjcbNombreTutor);
            this.Controls.Add(this.cbVacio);
            this.Controls.Add(this.rjcbCodTutor);
            this.Controls.Add(this.rjcbEstado);
            this.Controls.Add(this.rjcbSituacion);
            this.Controls.Add(this.lclCodTutor);
            this.Controls.Add(this.txtMaterno);
            this.Controls.Add(this.txtPaterno);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtCodAlumno);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblSituacion);
            this.Controls.Add(this.lblMaterno);
            this.Controls.Add(this.lblPaterno);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblCodAlumno);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btCancelar);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatosAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatosAlumno";
            this.Load += new System.EventHandler(this.DatosAlumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMaterno;
        private System.Windows.Forms.TextBox txtPaterno;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtCodAlumno;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblSituacion;
        private System.Windows.Forms.Label lblMaterno;
        private System.Windows.Forms.Label lblPaterno;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblCodAlumno;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label lclCodTutor;
        private RJCONTROLES.RJComboBox rjcbSituacion;
        private RJCONTROLES.RJComboBox rjcbEstado;
        private RJCONTROLES.RJComboBox rjcbCodTutor;
        private System.Windows.Forms.CheckBox cbVacio;
        private RJCONTROLES.RJComboBox rjcbNombreTutor;
    }
}
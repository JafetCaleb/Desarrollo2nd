
namespace Tutoria
{
    partial class Recuperacion
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
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblTipoIngreso = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnVerPregunta = new System.Windows.Forms.Button();
            this.rjcbTIpo = new Tutoria.RJCONTROLES.RJComboBox();
            this.SuspendLayout();
            // 
            // txtPregunta
            // 
            this.txtPregunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtPregunta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPregunta.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPregunta.ForeColor = System.Drawing.Color.Silver;
            this.txtPregunta.Location = new System.Drawing.Point(15, 118);
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(373, 22);
            this.txtPregunta.TabIndex = 91;
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPregunta.ForeColor = System.Drawing.Color.White;
            this.lblPregunta.Location = new System.Drawing.Point(12, 84);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(126, 21);
            this.lblPregunta.TabIndex = 90;
            this.lblPregunta.Text = "Pregunta secreta";
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtRespuesta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRespuesta.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtRespuesta.ForeColor = System.Drawing.Color.Silver;
            this.txtRespuesta.Location = new System.Drawing.Point(179, 146);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(208, 22);
            this.txtRespuesta.TabIndex = 89;
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblRespuesta.ForeColor = System.Drawing.Color.White;
            this.lblRespuesta.Location = new System.Drawing.Point(10, 146);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(81, 21);
            this.lblRespuesta.TabIndex = 88;
            this.lblRespuesta.Text = "Respuesta";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUsuario.ForeColor = System.Drawing.Color.Silver;
            this.txtUsuario.Location = new System.Drawing.Point(179, 52);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(208, 22);
            this.txtUsuario.TabIndex = 93;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(11, 52);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 21);
            this.lblUsuario.TabIndex = 92;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblTipoIngreso
            // 
            this.lblTipoIngreso.AutoSize = true;
            this.lblTipoIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTipoIngreso.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTipoIngreso.Location = new System.Drawing.Point(11, 10);
            this.lblTipoIngreso.Name = "lblTipoIngreso";
            this.lblTipoIngreso.Size = new System.Drawing.Size(119, 20);
            this.lblTipoIngreso.TabIndex = 95;
            this.lblTipoIngreso.Text = "Tipo de Ingreso";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnConsultar.ForeColor = System.Drawing.Color.Navy;
            this.btnConsultar.Location = new System.Drawing.Point(276, 194);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(111, 28);
            this.btnConsultar.TabIndex = 96;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancelar.ForeColor = System.Drawing.Color.Navy;
            this.btnCancelar.Location = new System.Drawing.Point(14, 194);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 28);
            this.btnCancelar.TabIndex = 97;
            this.btnCancelar.Text = "X";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnVerPregunta
            // 
            this.btnVerPregunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnVerPregunta.FlatAppearance.BorderSize = 0;
            this.btnVerPregunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPregunta.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnVerPregunta.ForeColor = System.Drawing.Color.Navy;
            this.btnVerPregunta.Location = new System.Drawing.Point(276, 84);
            this.btnVerPregunta.Name = "btnVerPregunta";
            this.btnVerPregunta.Size = new System.Drawing.Size(111, 28);
            this.btnVerPregunta.TabIndex = 98;
            this.btnVerPregunta.Text = "Ver Pregunta";
            this.btnVerPregunta.UseVisualStyleBackColor = false;
            this.btnVerPregunta.Click += new System.EventHandler(this.btnVerPregunta_Click);
            // 
            // rjcbTIpo
            // 
            this.rjcbTIpo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
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
            this.rjcbTIpo.Location = new System.Drawing.Point(179, 11);
            this.rjcbTIpo.MinimumSize = new System.Drawing.Size(169, 19);
            this.rjcbTIpo.Name = "rjcbTIpo";
            this.rjcbTIpo.Size = new System.Drawing.Size(208, 19);
            this.rjcbTIpo.TabIndex = 94;
            this.rjcbTIpo.Texts = "";
            this.rjcbTIpo.OnSelectedIndexChanged += new System.EventHandler(this.rjcbTIpo_OnSelectedIndexChanged);
            // 
            // Recuperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(404, 234);
            this.Controls.Add(this.btnVerPregunta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.rjcbTIpo);
            this.Controls.Add(this.lblTipoIngreso);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtPregunta);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.lblRespuesta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Recuperacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperacion";
            this.Load += new System.EventHandler(this.Recuperacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private RJCONTROLES.RJComboBox rjcbTIpo;
        private System.Windows.Forms.Label lblTipoIngreso;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnVerPregunta;
    }
}
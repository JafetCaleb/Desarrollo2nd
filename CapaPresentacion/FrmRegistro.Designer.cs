﻿
namespace CapaPresentacion
{
    partial class FrmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistro));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegistrarEstudianteATutoria = new Bunifu.Framework.UI.BunifuThinButton2();
            this.TablaRegistro = new System.Windows.Forms.DataGridView();
            this.EDITAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.flowLayoutPanel1.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.Panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1249, 612);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 82);
            this.panel2.TabIndex = 1;
            // 
            // Panel1
            // 
            this.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel1.BackgroundImage")));
            this.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel1.Controls.Add(this.textBuscar);
            this.Panel1.Controls.Add(this.pictureBox2);
            this.Panel1.Controls.Add(this.pictureBox1);
            this.Panel1.Controls.Add(this.btnRegistrarEstudianteATutoria);
            this.Panel1.Controls.Add(this.TablaRegistro);
            this.Panel1.Location = new System.Drawing.Point(3, 91);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1246, 571);
            this.Panel1.TabIndex = 0;
            // 
            // textBuscar
            // 
            this.textBuscar.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscar.Location = new System.Drawing.Point(73, 82);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(235, 21);
            this.textBuscar.TabIndex = 4;
            this.textBuscar.TextChanged += new System.EventHandler(this.textBuscar_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(32, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegistrarEstudianteATutoria
            // 
            this.btnRegistrarEstudianteATutoria.ActiveBorderThickness = 1;
            this.btnRegistrarEstudianteATutoria.ActiveCornerRadius = 20;
            this.btnRegistrarEstudianteATutoria.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.btnRegistrarEstudianteATutoria.ActiveForecolor = System.Drawing.Color.White;
            this.btnRegistrarEstudianteATutoria.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnRegistrarEstudianteATutoria.BackColor = System.Drawing.SystemColors.Control;
            this.btnRegistrarEstudianteATutoria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistrarEstudianteATutoria.BackgroundImage")));
            this.btnRegistrarEstudianteATutoria.ButtonText = "Registrar Estudiante a Tutoria";
            this.btnRegistrarEstudianteATutoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarEstudianteATutoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarEstudianteATutoria.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnRegistrarEstudianteATutoria.IdleBorderThickness = 1;
            this.btnRegistrarEstudianteATutoria.IdleCornerRadius = 20;
            this.btnRegistrarEstudianteATutoria.IdleFillColor = System.Drawing.Color.White;
            this.btnRegistrarEstudianteATutoria.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnRegistrarEstudianteATutoria.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnRegistrarEstudianteATutoria.Location = new System.Drawing.Point(22, 23);
            this.btnRegistrarEstudianteATutoria.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnRegistrarEstudianteATutoria.Name = "btnRegistrarEstudianteATutoria";
            this.btnRegistrarEstudianteATutoria.Size = new System.Drawing.Size(245, 41);
            this.btnRegistrarEstudianteATutoria.TabIndex = 1;
            this.btnRegistrarEstudianteATutoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegistrarEstudianteATutoria.Click += new System.EventHandler(this.btnRegistrarEstudianteATutoria_Click);
            // 
            // TablaRegistro
            // 
            this.TablaRegistro.AllowUserToAddRows = false;
            this.TablaRegistro.AllowUserToOrderColumns = true;
            this.TablaRegistro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaRegistro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TablaRegistro.BackgroundColor = System.Drawing.Color.White;
            this.TablaRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaRegistro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TablaRegistro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TablaRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaRegistro.ColumnHeadersVisible = false;
            this.TablaRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EDITAR,
            this.ELIMINAR});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablaRegistro.DefaultCellStyle = dataGridViewCellStyle1;
            this.TablaRegistro.Location = new System.Drawing.Point(22, 122);
            this.TablaRegistro.Name = "TablaRegistro";
            this.TablaRegistro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TablaRegistro.RowHeadersVisible = false;
            this.TablaRegistro.RowHeadersWidth = 51;
            this.TablaRegistro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.TablaRegistro.Size = new System.Drawing.Size(1194, 343);
            this.TablaRegistro.TabIndex = 0;
            this.TablaRegistro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaRegistro_CellContentClick);
            // 
            // EDITAR
            // 
            this.EDITAR.HeaderText = "EDITAR";
            this.EDITAR.Image = ((System.Drawing.Image)(resources.GetObject("EDITAR.Image")));
            this.EDITAR.MinimumWidth = 6;
            this.EDITAR.Name = "EDITAR";
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.HeaderText = "ELIMINAR";
            this.ELIMINAR.Image = ((System.Drawing.Image)(resources.GetObject("ELIMINAR.Image")));
            this.ELIMINAR.MinimumWidth = 6;
            this.ELIMINAR.Name = "ELIMINAR";
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 612);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistro";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaRegistro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRegistrarEstudianteATutoria;
        private System.Windows.Forms.DataGridView TablaRegistro;
        private System.Windows.Forms.DataGridViewImageColumn EDITAR;
        private System.Windows.Forms.DataGridViewImageColumn ELIMINAR;
    }
}
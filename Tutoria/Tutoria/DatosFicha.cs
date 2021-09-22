using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UsuarioCache;

namespace Tutoria
{
    public partial class DatosFicha : Form
    {
        Metodos metodos = new Metodos();
        public DatosFicha()
        {
            InitializeComponent();
        }
        public DatosFicha(List<string> valores)
        {
            InitializeComponent();
            txtCodAlumno.Text = valores[0];
            txtCodAlumno.Enabled = false;
            txtCodTutor.Text = valores[1];
            txtCodTutor.Enabled = false;
            txtCodFicha.Text = valores[2];
            txtCodFicha.Enabled = false;
            txtCelular.Text = valores[3];
            txtDireccion.Text = valores[4];
            txtEmail.Text = valores[5];
        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<string> valores = new List<string>();
            valores.Add(txtCodTutor.Text);
            valores.Add(txtCodAlumno.Text);
            valores.Add(txtCodFicha.Text);
            valores.Add(txtCelular.Text);
            valores.Add(txtDireccion.Text);
            valores.Add(txtEmail.Text);
            metodos.Actualizar(valores);
            Aviso aviso = new Aviso("Ficha Actualizada", true);
            aviso.ShowDialog();
            Close();
        }

        private void DatosFicha_Load(object sender, EventArgs e)
        {
        }
    }
}

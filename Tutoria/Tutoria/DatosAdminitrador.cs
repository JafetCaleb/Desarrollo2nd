using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsuarioCache;

namespace Tutoria
{
    public partial class DatosAdminitrador : Form
    {
        Metodos metodos = new Metodos();
        public DatosAdminitrador()
        {
            InitializeComponent();
        }
        public DatosAdminitrador(List<string> valores)
        {
            InitializeComponent();
            txtCodAdmin.Text = valores[0];
            txtCodAdmin.Enabled = false;
            txtNombres.Text = valores[1];
            txtPaterno.Text = valores[2];
            txtMaterno.Text = valores[3];
        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text != "" && txtPaterno.Text != "" && txtMaterno.Text != "")
            {
                List<string> valores = new List<string>();
                valores.Add(txtCodAdmin.Text);
                valores.Add(txtNombres.Text);
                valores.Add(txtPaterno.Text);
                valores.Add(txtMaterno.Text);
                metodos.Actualizar(valores);
                Aviso aviso = new Aviso("Admintrador Actualizado", true);
                aviso.ShowDialog();
                if (Cache.Completo == true)
                {
                    Cache.Nombres = txtNombres.Text;
                    Cache.Paterno = txtPaterno.Text;
                    Cache.Materno = txtMaterno.Text;
                    Cache.Completo = false;
                }

                Close();
            }
            else
            {
                Aviso aviso = new Aviso("Error: Faltan Ingresar Datos Necesarios", false);
                aviso.ShowDialog();
            }
        }
    }
}

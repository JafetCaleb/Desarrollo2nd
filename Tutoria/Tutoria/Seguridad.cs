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

namespace Tutoria
{
    public partial class Seguridad : Form
    {
        Metodos metodos = new Metodos();
        public Seguridad()
        {
            InitializeComponent();
        }
        public Seguridad(List<string> valores)
        {
            InitializeComponent();
            txtContraseña.Text = valores[0];
            txtPregunta.Text = valores[1];
            txtRespuesta.Text = valores[2];
        }

        private void Seguridad_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtRespuesta.Text != "" && txtPregunta.Text == "")
            {
                Aviso aviso = new Aviso("Es necesario poner su pregunta secreta", false);
                aviso.ShowDialog();
            }
            else
            {
                
                List<string> valores = new List<string>();
                if (txtNuevaContraseña.Text == "")
                {
                    valores.Add(txtContraseña.Text);
                }
                else
                {
                    valores.Add(txtNuevaContraseña.Text);
                }
                valores.Add(txtPregunta.Text);
                valores.Add(txtRespuesta.Text);
                if (txtPregunta.Text == "")
                {

                }
                metodos.ActualizarContraseña(valores);
                Aviso aviso = new Aviso("Contraseña Actualizada", true);
                aviso.ShowDialog();
                Close();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

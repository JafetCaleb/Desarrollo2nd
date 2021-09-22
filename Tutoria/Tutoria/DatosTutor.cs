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
    public partial class DatosTutor : Form
    {
        Metodos metodos = new Metodos();
        public DatosTutor()
        {
            InitializeComponent();
        }
        public DatosTutor(List<string> valores)
        {
            InitializeComponent();
            txtCodTutor.Text = valores[0];
            txtCodTutor.Enabled = false;
            txtNombres.Text = valores[1];
            txtPaterno.Text = valores[2];
            txtMaterno.Text = valores[3];
            rjcbSituacion.Texts = valores[4];
            rjcbEstado.Texts = valores[5];
            if (Cache.Completo == true)
            {
                rjcbSituacion.Enabled = false;
                rjcbEstado.Enabled = false;
            }
            else
            {
                rjcbSituacion.Enabled = true;
                rjcbEstado.Enabled = true;
            }
        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCodTutor.Text != "" && txtNombres.Text != "" && txtPaterno.Text != "" && txtMaterno.Text != "" && rjcbSituacion.Texts != "" && rjcbEstado.Texts != "")
            {
                List<string> valores = new List<string>();
                valores.Add(txtCodTutor.Text);
                valores.Add(txtNombres.Text);
                valores.Add(txtPaterno.Text);
                valores.Add(txtMaterno.Text);
                valores.Add(rjcbSituacion.Texts);
                valores.Add(rjcbEstado.Texts);
                if (txtCodTutor.Enabled == true)
                {
                    metodos.Agregar(valores);
                    Aviso aviso = new Aviso("Tutor Agregado",true);
                    aviso.ShowDialog();
                }
                else
                {
                    metodos.Actualizar(valores);
                    Aviso aviso = new Aviso("Tutor Actualizado", true);
                    aviso.ShowDialog();
                }
                if (Cache.Completo == true)
                {
                    Cache.Nombres = txtNombres.Text;
                    Cache.Paterno = txtPaterno.Text;
                    Cache.Materno = txtMaterno.Text;
                    Cache.Completo = false;
                }
                Close();
            }
            else { 
            Aviso aviso = new Aviso("Error: Faltan Ingresar Datos Necesarios", false);
            aviso.ShowDialog();
        }
    }

        private void DatosTutor_Load(object sender, EventArgs e)
        {
            
        }
    }
}

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
    public partial class DatosAlumno : Form
    {
        Metodos metodos = new Metodos();
        public DatosAlumno()
        {
            InitializeComponent();
            string aux = Cache.Modo;
            Cache.Modo = "Tutor";
            rjcbCodTutor.DataSource = metodos.codigo_nombre();
            rjcbCodTutor.DisplayMember = "CodTutor";
            rjcbNombreTutor.DataSource = metodos.codigo_nombre();
            rjcbNombreTutor.DisplayMember = "Nombre";
            Cache.Modo = aux;
        }
        public DatosAlumno(List<string> valores)
        {
            InitializeComponent();
            string aux = Cache.Modo;
            Cache.Modo = "Tutor";
            rjcbCodTutor.DataSource = metodos.codigo_nombre();
            rjcbCodTutor.DisplayMember = "CodTutor";
            rjcbNombreTutor.DataSource = metodos.codigo_nombre();
            rjcbNombreTutor.DisplayMember = "Nombre";
            Cache.Modo = aux;
            txtCodAlumno.Text = valores[0];
            txtCodAlumno.Enabled = false;
            txtNombres.Text = valores[1];
            txtPaterno.Text = valores[2];
            txtMaterno.Text = valores[3];
            rjcbSituacion.Texts = valores[4];
            if (valores[5] == "")
            {
                cbVacio.Checked = true;
                rjcbCodTutor.SelectedIndex=0;
            }
            else
            {
                rjcbCodTutor.SelectedIndex=Int32.Parse(valores[5])-1;
            }
            if (Cache.Completo == true)
            {
                rjcbSituacion.Enabled = false;
                rjcbEstado.Enabled = false;
                rjcbCodTutor.Enabled = false;
                rjcbNombreTutor.Enabled = false;
                cbVacio.Enabled = false;
            }
            else
            {
                rjcbSituacion.Enabled = true;
                rjcbEstado.Enabled = true;
                rjcbCodTutor.Enabled = true;
                rjcbNombreTutor.Enabled = true;
                cbVacio.Enabled = true;
            }
            rjcbEstado.Texts = valores[6];
        }
        private void DatosAlumno_Load(object sender, EventArgs e)
        {
            var mensajeVacio = new ToolTip();
            mensajeVacio.SetToolTip(cbVacio, "Seleccion para Tutor sin definir");
            
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCodAlumno.Text != "" && txtNombres.Text != "" && txtPaterno.Text != "" && txtMaterno.Text != "" && rjcbSituacion.Texts != "" && rjcbEstado.Texts != "")
            {
                List<string> valores = new List<string>();
                valores.Add(txtCodAlumno.Text);
                valores.Add(txtNombres.Text);
                valores.Add(txtPaterno.Text);
                valores.Add(txtMaterno.Text);
                valores.Add(rjcbSituacion.Texts);
                valores.Add(rjcbCodTutor.Texts);
                valores.Add(rjcbEstado.Texts);
                if (txtCodAlumno.Enabled == true)
                {
                    metodos.Agregar(valores);
                    Aviso aviso = new Aviso("Alumno Agregado", true);
                    aviso.ShowDialog();
                }
                else
                {
                    metodos.Actualizar(valores);
                    Aviso aviso = new Aviso("Alumno Actualizado", true);
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
            else
            {
                Aviso aviso = new Aviso("Error: Faltan Ingresar Datos Necesarios", false);
                aviso.ShowDialog();
            }
        }

        private void cbVacio_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVacio.Checked == true)
            {
                rjcbCodTutor.Texts = "";
                rjcbCodTutor.Enabled = false;
                rjcbNombreTutor.Texts = "";
                rjcbNombreTutor.Enabled = false;
            }
            else
            {
                rjcbCodTutor.Enabled = true;
                rjcbNombreTutor.Enabled = true;
                
            }
        }

        private void rjcbCodTutor_OnSelectedIndexChanged(object sender, EventArgs e)
        {

            rjcbNombreTutor.SelectedIndex = rjcbCodTutor.SelectedIndex;
        }

        private void rjcbNombreTutor_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            rjcbCodTutor.SelectedIndex = rjcbNombreTutor.SelectedIndex;
        }
    }
}

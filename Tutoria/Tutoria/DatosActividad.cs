using Dominio;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UsuarioCache;

namespace Tutoria
{
    public partial class DatosActividad : Form
    {
        Metodos metodos = new Metodos();   
        public DatosActividad()
        {
            InitializeComponent();
        }
        public DatosActividad(List<string> valores)
        {
            InitializeComponent();
            rjcbCodFicha.Texts = valores[0];
            rjcbCodFicha.Enabled = false;
            txtNumero.Text = valores[1];
            txtCodActividad.Text = valores[2];
            //fecha
            rjdtFecha.Text = valores[3].Split()[0];
            rjcbHora.Texts = valores[3].Split()[1].Split(':')[0];
            rjcbMinuto.Texts = valores[3].Split()[1].Split(':')[1];
            rjcbAM.Texts = valores[3].Split()[2];
            //
            txtTipoTutoria.Text = valores[4];
            txtDescripcion.Text = valores[5];
            txtReferencias.Text = valores[6];
            txtObservaciones.Text = valores[7];
        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtTipoTutoria.Text != "")
            {
                List<string> valores = new List<string>();
            valores.Add(rjcbCodFicha.Texts);
            valores.Add(txtNumero.Text);
            valores.Add(txtCodActividad.Text);
            valores.Add(rjdtFecha.Text+" "+rjcbHora.Texts+":"+rjcbMinuto.Texts+" "+rjcbAM.Texts);
            valores.Add(txtTipoTutoria.Text);
            valores.Add(txtDescripcion.Text);
            valores.Add(txtReferencias.Text);
            valores.Add(txtObservaciones.Text);
            
                if (rjcbCodFicha.Enabled == true)
                {
                    metodos.Agregar(valores);
                    Aviso aviso = new Aviso("Actividad Agregada", true);
                    aviso.ShowDialog();
                }
                else
                {
                    metodos.Actualizar(valores);
                    Aviso aviso = new Aviso("Actividad Actualizada", true);
                    aviso.ShowDialog();
                }
                Close();
            }
            else
            {
                Aviso aviso = new Aviso("Debe ingresar el Tipo de Tutoria", false);
                aviso.ShowDialog();
            }
            

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DatosActividad_Load(object sender, EventArgs e)
        {
            if(rjcbCodFicha.Enabled == true) {
                string aux = Cache.Modo;
                Cache.Modo = "FichaTutoria";
                rjcbCodFicha.DataSource = metodos.Mostrar("");
                rjcbCodFicha.DisplayMember = "CodFicha";
                Cache.Modo = aux;
                txtNumero.Text = "";
                txtCodActividad.Text = "";
            }
        }

        private void rjcbCodFicha_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            
            DataTable aux2 = metodos.Mostrar(rjcbCodFicha.Texts);
            txtNumero.Text = (aux2.Rows.Count+1).ToString();
            txtCodActividad.Text = rjcbCodFicha.Texts+"-"+txtNumero.Text;
        }

        private void rjdtFecha_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}

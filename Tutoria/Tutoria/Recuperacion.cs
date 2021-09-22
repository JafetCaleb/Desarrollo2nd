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
    public partial class Recuperacion : Form
    {
        string pregunta = "";
        string respuesta = "";
        string contraseña = "";
        public Recuperacion()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (respuesta==txtRespuesta.Text)
            {
                Aviso aviso = new Aviso("Su contraseña es: " + contraseña,true);
                aviso.ShowDialog();
            }
            else
            {
                Aviso aviso = new Aviso("Ocurrio un error",false);
                aviso.ShowDialog();
            }
            Cache.Completo = false;
            Close();
        }

        private void rjcbTIpo_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVerPregunta_Click(object sender, EventArgs e)
        {
            Metodos metodos = new Metodos();
            Cache.Tipo = "Administrador";
            Cache.Modo = rjcbTIpo.Texts;
            Cache.Completo = true;
            DataTable aux = metodos.Mostrar(txtUsuario.Text);
            pregunta = aux.Rows[0]["Pregunta"].ToString();
            respuesta = aux.Rows[0]["Respuesta"].ToString();
            contraseña = aux.Rows[0]["Contraseña"].ToString();
            txtPregunta.Text = pregunta;
        }

        private void Recuperacion_Load(object sender, EventArgs e)
        {

        }
    }
}

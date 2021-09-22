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
    public partial class Aviso : Form
    {
        public Aviso()
        {
            InitializeComponent();
        }
        public Aviso(string mensaje,bool tipo)
        {
            InitializeComponent();
            lblMensaje.Text = mensaje;
            if (tipo == false)
            {
                btnAceptar.BackColor = Color.Red;
            } 
        }
        private void Aviso_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.OK;
        }
    }
}

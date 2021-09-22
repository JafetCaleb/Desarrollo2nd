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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void nuevo()
        {
            txtUsuario.Text = "Ingrese Usuario";
            txtContraseña.Text = "Ingrese Contraseña";
        }
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Ingrese Usuario")
            {
                txtUsuario.Text = "";
            }

            txtUsuario.ForeColor = Color.Black;
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals(""))
            {
               txtUsuario.Text = "Ingrese Usuario";
            }
            txtUsuario.ForeColor = Color.Silver;
        }

        private void Login_Load(object sender, EventArgs e)
        {


        }
        private void cbTipoLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUsuario.Text = "Ingrese Usuario";
            txtContraseña.Text = "Ingrese Contraseña";
            txtContraseña.UseSystemPasswordChar = false;
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text=="Ingrese Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.UseSystemPasswordChar = true;
            }
            txtContraseña.ForeColor = Color.Black;
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Equals(""))
            {
                txtContraseña.Text = "Ingrese Contraseña";
                txtContraseña.UseSystemPasswordChar = false;
            }
            txtContraseña.ForeColor = Color.Silver;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Ingreso login = new Ingreso();
            if (login.Login(txtUsuario.Text, txtContraseña.Text, rjcbTIpo.Texts)){
                Aviso aviso=new Aviso("Login Exitoso",true);
                aviso.ShowDialog();
                Principal general = new Principal();
                Program.login.Hide();
                txtUsuario.Text = "Ingrese Usuario";
                txtContraseña.Text = "Ingrese Contraseña";
                txtContraseña.UseSystemPasswordChar = false;
                general.Show();
            }
            else
            {
                Aviso aviso = new Aviso("Datos Incorrectos",false);
                aviso.ShowDialog();
                txtUsuario.Text = "Ingrese Usuario";
                txtContraseña.Text = "Ingrese Contraseña";
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbltutoria_Click(object sender, EventArgs e)
        {

        }

        private void rjComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            txtUsuario.Text = "Ingrese Usuario";
            txtContraseña.Text = "Ingrese Contraseña";
            txtContraseña.UseSystemPasswordChar = false;
        }

        private void llblRecuperacion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Recuperacion recuperacion = new Recuperacion();
            recuperacion.Show();
        }
    }
}

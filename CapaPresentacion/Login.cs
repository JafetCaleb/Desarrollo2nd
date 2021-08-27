using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public string usuario;
        public Login()
        {
            InitializeComponent();
            buttonIngresar.Focus();
            
        }

        public bool logins(string usuario, string contraseña)
        {
            bool aux = false;
            try
            {

                using (SqlConnection conexion = new SqlConnection("Server=tcp:dtutorias.database.windows.net,1433;Initial Catalog=BDTutoria;Persist Security Info=False;User ID=desarrollo;Password=Unsaac2017;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * from Logins  WHERE Logins.Usuario='" + usuario + "' AND Logins.Contraseña='" + contraseña + "'", conexion))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("Login exitoso.");
                            obtenerusuario();
                            Close();
                            aux = true;
                            //FrmMain aea = new FrmMain();
                            //aea.ShowDialog();
                            
                        }
                        else
                        {
                            MessageBox.Show("Datos incorrectos.");
                            txtusuario.Text = "";
                            txtcontraseña.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return aux;
        }
        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            logins(txtusuario.Text,txtcontraseña.Text);
        }
        public string obtenerusuario()
        {
            usuario = txtusuario.Text;
            return usuario;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta opción estara disponible muy pronto :v");
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

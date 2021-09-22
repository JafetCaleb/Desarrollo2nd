using System;
using Dominio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsuarioCache;

namespace Tutoria { 
    public partial class Principal : Form
    {
        Metodos metodo = new Metodos();
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            lblCodigo.Text = Cache.id;
            lblNombres.Text = Cache.Nombres;
            lblPaterno.Text = Cache.Paterno;
            lblMaterno.Text = Cache.Materno;
            if (Cache.Tipo == "Tutor")
            {
                btnTutores.Visible = false;
            }
            if (Cache.Tipo == "Alumno")
            {
                btnTutores.Visible = false;
                btnAlumnos.Visible = false;
            }
            lblBuscar.Visible = false;
            txtBuscar.Visible = false;
            btnAgregar.Visible = false;
            dgvTutores.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
            Program.login.Show();
        }

        private void btnTutores_Click(object sender, EventArgs e)
        {
            Cache.Modo = "Tutor";
            //modificaciones en el dasborad
            lblBuscar.Visible = true;
            txtBuscar.Visible = true;
            btnAgregar.Visible = true;
            dgvTutores.Visible = true;
            dgvTutores.DataSource = new DataTable();
            dgvTutores.DataSource = metodo.Mostrar("");
            //modificaciones en los botones
            btnAlumnos.BackColor = Color.LightCyan;
            btnTutorias.BackColor = Color.LightCyan;
            btnActividades.BackColor = Color.LightCyan;
            btnTutores.BackColor = Color.SkyBlue;
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            Cache.Modo = "Alumno";
            lblBuscar.Visible = true;
            txtBuscar.Visible = true;
            if (Cache.Tipo == "Administrador")
            {
                btnAgregar.Visible = true;
            }
            else
            {
                btnAgregar.Visible = false;
            }
            dgvTutores.Visible = true;
            dgvTutores.DataSource = new DataTable();
            dgvTutores.DataSource = metodo.Mostrar("");
            //modificaciones en los botones
            btnAlumnos.BackColor = Color.SkyBlue;
            btnTutorias.BackColor = Color.LightCyan;
            btnActividades.BackColor = Color.LightCyan;
            btnTutores.BackColor = Color.LightCyan;
        }

        private void btnTutorias_Click(object sender, EventArgs e)
        {
            Cache.Modo = "FichaTutoria";
            lblBuscar.Visible = true;
            txtBuscar.Visible = true;
            btnAgregar.Visible = false;
            dgvTutores.Visible = true;
            dgvTutores.DataSource = new DataTable();
            dgvTutores.DataSource = metodo.Mostrar("");
            //modificaciones en los botones
            btnAlumnos.BackColor = Color.LightCyan;
            btnTutorias.BackColor = Color.SkyBlue;
            btnActividades.BackColor = Color.LightCyan;
            btnTutores.BackColor = Color.LightCyan;
        }

        private void btnProximas_Click(object sender, EventArgs e)
        {
            Cache.Modo = "ActividadTutoria";
            lblBuscar.Visible = true;
            txtBuscar.Visible = true;
            btnAgregar.Visible = true;
            dgvTutores.Visible = true;
            dgvTutores.DataSource = new DataTable();
            dgvTutores.DataSource = metodo.Mostrar("");
            if (Cache.Tipo != "Alumno")
            {
                btnAgregar.Visible = true;
            }
            else
            {
                btnAgregar.Visible = false;
            }
            //modificaciones en los botones
            btnAlumnos.BackColor = Color.LightCyan;
            btnTutorias.BackColor = Color.LightCyan;
            btnActividades.BackColor = Color.SkyBlue;
            btnTutores.BackColor = Color.LightCyan;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvTutores.DataSource = metodo.Mostrar(txtBuscar.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Cache.Modo == "Tutor")
            {
                DatosTutor datostutor = new DatosTutor();
                datostutor.ShowDialog();
                dgvTutores.DataSource = metodo.Mostrar("");
            }
            if (Cache.Modo == "Alumno")
            {
                DatosAlumno datosalumno = new DatosAlumno();
                datosalumno.ShowDialog();
                dgvTutores.DataSource = metodo.Mostrar("");
            }
            if (Cache.Modo == "ActividadTutoria")
            {
                DatosActividad datosactividad = new DatosActividad();
                datosactividad.ShowDialog();
                dgvTutores.DataSource = metodo.Mostrar("");
            }
            txtBuscar.Text = "";
        }

        private void dgvTutores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvTutores_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Cache.Modo == "Tutor" && Cache.Tipo=="Administrador")
            {
                List<string> valores = new List<string>();
                valores.Add(dgvTutores.CurrentRow.Cells["CodTutor"].Value.ToString());
                valores.Add(dgvTutores.CurrentRow.Cells["Nombres"].Value.ToString());
                valores.Add(dgvTutores.CurrentRow.Cells["Apellido_Paterno"].Value.ToString());
                valores.Add(dgvTutores.CurrentRow.Cells["Apellido_Materno"].Value.ToString());
                valores.Add(dgvTutores.CurrentRow.Cells["Situacion"].Value.ToString());
                valores.Add(dgvTutores.CurrentRow.Cells["Estado"].Value.ToString());
                DatosTutor datostutor = new DatosTutor(valores);
                datostutor.ShowDialog();
                dgvTutores.DataSource = metodo.Mostrar("");
            }
            if (Cache.Modo == "Alumno" && Cache.Tipo=="Administrador")
            {
                List<string> valores = new List<string>();
                valores.Add(dgvTutores.CurrentRow.Cells["CodAlumno"].Value.ToString());
                valores.Add(dgvTutores.CurrentRow.Cells["Nombres"].Value.ToString());
                valores.Add(dgvTutores.CurrentRow.Cells["Apellido_Paterno"].Value.ToString());
                valores.Add(dgvTutores.CurrentRow.Cells["Apellido_Materno"].Value.ToString());
                valores.Add(dgvTutores.CurrentRow.Cells["Situacion"].Value.ToString());
                valores.Add(dgvTutores.CurrentRow.Cells["CodTutor"].Value.ToString());
                valores.Add(dgvTutores.CurrentRow.Cells["Estado"].Value.ToString());
                DatosAlumno datosalumno = new DatosAlumno(valores);
                datosalumno.ShowDialog();
                dgvTutores.DataSource = metodo.Mostrar("");
            }
            if (Cache.Modo == "FichaTutoria" &&Cache.Tipo!="Alumno")
            {
                List<string> valores = new List<string>();
                valores.Add(dgvTutores.CurrentRow.Cells["CodAlumno"].Value.ToString());
                valores.Add(dgvTutores.CurrentRow.Cells["CodTutor"].Value.ToString());
                valores.Add(dgvTutores.CurrentRow.Cells["CodFicha"].Value.ToString());
                valores.Add(dgvTutores.CurrentRow.Cells["Celular"].Value.ToString());
                valores.Add(dgvTutores.CurrentRow.Cells["Direccion"].Value.ToString());
                valores.Add(dgvTutores.CurrentRow.Cells["Email"].Value.ToString());
                DatosFicha datosficha = new DatosFicha(valores);
                datosficha.ShowDialog();
                dgvTutores.DataSource = metodo.Mostrar("");
            }
            if (Cache.Modo == "ActividadTutoria" &&Cache.Tipo!="Alumno")
            {
                List<string> valores = new List<string>();
                valores.Add(dgvTutores.CurrentRow.Cells["CodFicha"].Value.ToString());
                valores.Add(dgvTutores.CurrentRow.Cells["Numero"].Value.ToString());
                valores.Add(dgvTutores.CurrentRow.Cells["CodActividad"].Value.ToString());
                valores.Add(dgvTutores.CurrentRow.Cells["Fecha"].Value.ToString());
                valores.Add(dgvTutores.CurrentRow.Cells["Tipo_Tutoria"].Value.ToString());
                valores.Add(dgvTutores.CurrentRow.Cells["Descripcion"].Value.ToString());
                valores.Add(dgvTutores.CurrentRow.Cells["Referencia"].Value.ToString());
                valores.Add(dgvTutores.CurrentRow.Cells["Observaciones"].Value.ToString());
                DatosActividad datosactividad = new DatosActividad(valores);
                datosactividad.ShowDialog();
                dgvTutores.DataSource = metodo.Mostrar("");
            }
            txtBuscar.Text = "";
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnTutores_Enter(object sender, EventArgs e)
        {
            btnTutores.ForeColor = Color.Cyan;
        }

        private void lblPaterno_Click(object sender, EventArgs e)
        {

        }


        private void Meno_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Cache.Tipo == "Administrador")
            {
                string aux = Cache.Tipo;
                string aux2 = Cache.Modo;
                Cache.Tipo = "Administrador";
                Cache.Modo = "Administrador";
                List<string> valores= new List<string>();
                valores.Add(Cache.id);
                valores.Add(Cache.Nombres);
                valores.Add(Cache.Paterno);
                valores.Add(Cache.Materno);
                DatosAdminitrador datosAdminitrador = new DatosAdminitrador(valores);
                datosAdminitrador.ShowDialog();
                Cache.Tipo = aux;
                Cache.Modo = aux2;
            }
            if (Cache.Tipo == "Alumno")
            {
                string aux = Cache.Tipo;
                string aux2 = Cache.Modo;
                Cache.Tipo = "Administrador";
                Cache.Modo = "Alumno";
                DataTable alumno = metodo.Mostrar(Cache.id);
                List<string> valores = new List<string>();
                valores.Add(alumno.Rows[0]["CodAlumno"].ToString());
                valores.Add(alumno.Rows[0]["Nombres"].ToString());
                valores.Add(alumno.Rows[0]["Apellido_Paterno"].ToString());
                valores.Add(alumno.Rows[0]["Apellido_Materno"].ToString());
                valores.Add(alumno.Rows[0]["Situacion"].ToString());
                valores.Add(alumno.Rows[0]["CodTutor"].ToString());
                valores.Add(alumno.Rows[0]["Estado"].ToString());
                Cache.Completo = true;
                DatosAlumno datosalumno = new DatosAlumno(valores);
                datosalumno.ShowDialog();
                Cache.Tipo = aux;
                Cache.Modo = aux2;
                Cache.Completo = false;
            }
            if (Cache.Tipo == "Tutor")
            {
                string aux = Cache.Tipo;
                string aux2 = Cache.Modo;
                Cache.Tipo = "Administrador";
                Cache.Modo = "Tutor";
                DataTable alumno = metodo.Mostrar(Cache.id);
                List<string> valores = new List<string>();
                valores.Add(alumno.Rows[0]["CodTutor"].ToString());
                valores.Add(alumno.Rows[0]["Nombres"].ToString());
                valores.Add(alumno.Rows[0]["Apellido_Paterno"].ToString());
                valores.Add(alumno.Rows[0]["Apellido_Materno"].ToString());
                valores.Add(alumno.Rows[0]["Situacion"].ToString());
                valores.Add(alumno.Rows[0]["Estado"].ToString());
                Cache.Completo = true;
                DatosTutor datostutor = new DatosTutor(valores);
                datostutor.ShowDialog();
                Cache.Tipo = aux;
                Cache.Modo = aux2;
                Cache.Completo = false;
            }
            lblNombres.Text = Cache.Nombres;
            lblPaterno.Text = Cache.Paterno;
            lblMaterno.Text = Cache.Materno;
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            if (Cache.Tipo == "Administrador")
            {
                string aux = Cache.Tipo;
                string aux2 = Cache.Modo;
                Cache.Tipo = "Administrador";
                Cache.Modo = "Administrador";
                List<string> valores = new List<string>();
                Metodos metodos = new Metodos();
                Cache.Completo = true;
                DataTable seguro = metodos.Mostrar(Cache.id);
                valores.Add(seguro.Rows[0]["Contraseña"].ToString());
                valores.Add(seguro.Rows[0]["Pregunta"].ToString());
                valores.Add(seguro.Rows[0]["Respuesta"].ToString());
                
                Seguridad seguridad = new Seguridad(valores);
                seguridad.ShowDialog();
                Cache.Tipo = aux;
                Cache.Modo = aux2;
                Cache.Completo = false;
            }
            if (Cache.Tipo == "Tutor")
            {
                string aux = Cache.Tipo;
                string aux2 = Cache.Modo;
                Cache.Tipo = "Administrador";
                Cache.Modo = "Tutor";
                List<string> valores = new List<string>();
                Metodos metodos = new Metodos();
                Cache.Completo = true;
                DataTable seguro = metodos.Mostrar(Cache.id);
                valores.Add(seguro.Rows[0]["Contraseña"].ToString());
                valores.Add(seguro.Rows[0]["Pregunta"].ToString());
                valores.Add(seguro.Rows[0]["Respuesta"].ToString());
                Seguridad seguridad = new Seguridad(valores);
                seguridad.ShowDialog();
                Cache.Tipo = aux;
                Cache.Modo = aux2;
                Cache.Completo = false;
            }
            if (Cache.Tipo == "Alumno")
            {
                string aux = Cache.Tipo;
                string aux2 = Cache.Modo;
                Cache.Tipo = "Administrador";
                Cache.Modo = "Alumno";
                List<string> valores = new List<string>();
                Metodos metodos = new Metodos();
                Cache.Completo = true;
                DataTable seguro = metodos.Mostrar(Cache.id);
                valores.Add(seguro.Rows[0]["Contraseña"].ToString());
                valores.Add(seguro.Rows[0]["Pregunta"].ToString());
                valores.Add(seguro.Rows[0]["Respuesta"].ToString());
                Seguridad seguridad = new Seguridad(valores);
                seguridad.ShowDialog();
                Cache.Tipo = aux;
                Cache.Modo = aux2;
                Cache.Completo = false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using UsuarioCache;
using System.Globalization;

namespace Datos
{
    public class Logueo:Conexion
    {
        public bool Login(string usuario, string contraseña, string tipo)
        {
            using(var conexion = get())
            {
                conexion.Open();
                using(var comando= new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "select * from "+tipo+" where Cod"+tipo+"='" + usuario + "' and convert(varchar,Contraseña)='" + contraseña + "'";
                    SqlDataReader reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Cache.id = reader.GetString(0);
                            Cache.Nombres = reader.GetString(1);
                            Cache.Paterno = reader.GetString(2);
                            Cache.Materno = reader.GetString(3);
                            Cache.Tipo = tipo;
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
        }
        public bool Existe(string usuario,string tipo)
        {
            using (var conexion = get())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    if (tipo == "Alumno" || tipo == "Tutor")
                    {
                        comando.CommandText = "select * from " + tipo + " where Cod" + tipo + "='" + usuario + "'";
                    }
                    else
                    {
                        comando.CommandText = "select * from " + tipo + "Tutoria where Cod" + tipo + "='" + usuario + "'";
                    }
                    SqlDataReader reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
        }
        public bool AgregarFicha(string codtutor,string codalumno)
        {
            using (var conexion = get())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    if (Existe(codtutor + codalumno, "Ficha"))
                    {
                        return false;
                    }
                    else { 
                    comando.Connection = conexion;

                    comando.CommandText = "INSERT INTO FichaTutoria Values('" + codtutor + @"'
                                            ,'" + codalumno + "',null,null,null)";
                    comando.ExecuteNonQuery();
                    conexion.Close();
                    return true;
                }
                }
            }
        }
        public bool Agregar(List<string> valores)
        {
            using (var conexion = get())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    
                        if ((Cache.Modo == "Alumno"))
                        {
                        comando.Connection = conexion;
                        comando.CommandText = "INSERT INTO " + Cache.Modo + " Values('" + valores[0] + "','" + valores[1] + "','" + valores[2] + "','" + valores[3] + "','" + valores[4]+"',";
                            if (valores[5] == "")
                            {
                                comando.CommandText = comando.CommandText + "null,";
                            }
                            else
                            {
                                comando.CommandText = comando.CommandText + "'" + valores[5] + "',";
                                AgregarFicha(valores[5], valores[0]);
                            }
                            comando.CommandText = comando.CommandText + "convert(varbinary,'"+valores[0]+"'),null,null,'" + valores[6] + "')";
                        }
                        if ((Cache.Modo == "Tutor"))
                        {
                        comando.Connection = conexion;
                        comando.CommandText = "INSERT INTO " + Cache.Modo + " Values('" + valores[0] + "','" + valores[1] + "','" + valores[2] + "','" + valores[3] + "','" + valores[4] + "',";
                        comando.CommandText = comando.CommandText + "convert(varbinary,'" + valores[0] + "'),null,null,'" + valores[5] + "')"; ;
                    }
                        if ((Cache.Modo == "ActividadTutoria"))
                        {
                        comando.Connection = conexion;
                        comando.CommandText = "INSERT INTO " + Cache.Modo + " Values('"+valores[0]+"','" + valores[1] + "'," +"convert(datetime,'" + valores[3] + "',103),'" + valores[4] + "','" + valores[5] + "',";
                            comando.CommandText = comando.CommandText + "'" + valores[6] + "','" + valores[7] + "')";
                        }

                    comando.ExecuteNonQuery();
                    conexion.Close();
                    return true;
                }
            }
        }
        public bool Actualizar(List<string> valores)
        {
            using (var conexion = get())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    if (Cache.Modo == "Administrador")
                    {
                        comando.CommandText = "UPDATE " + Cache.Modo + @" SET
                                                Nombres='" + valores[1] + @"',
                                                Apellido_Paterno='" + valores[2] + @"',
                                                Apellido_Materno='" + valores[3] + @"'
                                                 WHERE CodAdministrador='" + valores[0] + "'";
                    }
                    if (Cache.Modo == "Tutor")
                    {
                        comando.CommandText = "UPDATE " + Cache.Modo + @" SET
                                                Nombres='" + valores[1] + @"',
                                                Apellido_Paterno='" + valores[2] + @"',
                                                Apellido_Materno='" + valores[3] + @"',
                                                Situacion='" + valores[4] + @"',
                                                Estado='" + valores[5] + @"'
                                                WHERE CodTutor='" + valores[0] + "'";
                    }
                    if (Cache.Modo == "Alumno")
                    {
                        comando.CommandText = "UPDATE " + Cache.Modo + @" SET
                                                Nombres='" + valores[1] + @"',
                                                Apellido_Paterno='" + valores[2] + @"',
                                                Apellido_Materno='" + valores[3] + @"',
                                                Situacion='" + valores[4] + @"',";
                        if (valores[5] == "")
                        {
                            comando.CommandText = comando.CommandText + "CodTutor = null,";
                        }
                        else
                        {
                            comando.CommandText = comando.CommandText + "CodTutor = '" + valores[5] + @"',";
                            AgregarFicha(valores[5], valores[0]);
                        }
                        comando.CommandText = comando.CommandText + "Estado='" + valores[6] + @"'
                                                WHERE CodAlumno='" + valores[0] + "'";
                    }
                    if (Cache.Modo == "FichaTutoria")
                    {
                        comando.CommandText = "UPDATE " + Cache.Modo + " SET Celular = '" + valores[3] + @"',
                                                                Direccion = '" + valores[4] + @"',
                                                                Email = '" + valores[5] + @"'
                                                                WHERE CodFicha='" + valores[2] + "'";

                    }
                    if (Cache.Modo == "ActividadTutoria")
                    {
                        comando.CommandText = "UPDATE " + Cache.Modo + @" SET 
                                                Fecha=convert(datetime,'" + valores[3] + @"',103),
                                                Tipo_Tutoria ='" + valores[4] + @"',
                                                Descripcion='" + valores[5] + @"',
                                                Referencia='" + valores[6] + @"',
                                                Observaciones='" + valores[7] + @"'
                                                WHERE CodActividad='" + valores[2] + "'";
                    }
                    comando.ExecuteNonQuery();
                    conexion.Close();
                    return true;
                }
            }
        }
        public DataTable CodigoNombre()
        {
            using (var conexion = get())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;

                    comando.CommandText = "SELECT Cod" + Cache.Modo + @"
                                            ,CONCAT(Nombres,' '
                                            ,Apellido_Paterno,' '
                                            ,Apellido_Materno) Nombre
                                            FROM " + Cache.Modo;
                    DataTable tabla = new DataTable();
                    SqlDataReader reader = comando.ExecuteReader();
                    tabla.Load(reader);
                    conexion.Close();
                    return tabla;
                }
            }
        }
        public bool ActualizarSeguridad(List<string> valores)
        {
            using (var conexion = get())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "Update "+Cache.Tipo+" Set Pregunta='" + valores[1] + @"',
                                                    Respuesta='" + valores[2] + @"',
                                                    Contraseña=convert(varbinary,'" + valores[0] + @"')
                                                     where Cod" + Cache.Tipo + "='" + Cache.id + "'";
                    comando.ExecuteNonQuery();
                    conexion.Close();
                    return true;
                }
            }
        }

    }
}

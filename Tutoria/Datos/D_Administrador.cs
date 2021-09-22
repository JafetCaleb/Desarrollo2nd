using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using UsuarioCache;

namespace Datos
{
    public class D_Administrador:Conexion
    {
        public DataTable Buscar(string buscar)
        {
            using (var conexion = get())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    if (Cache.Modo == "Administrador")
                    {
                        comando.CommandText = @"SELECT CodAdministrador
                                            ,Nombres
                                            ,Apellido_Paterno
                                            ,Apellido_Materno";
                        if (Cache.Completo)
                        {
                            comando.CommandText = comando.CommandText + ",convert(varchar,Contraseña) as Contraseña,Pregunta,Respuesta";
                        }
                        else { }
                        comando.CommandText = comando.CommandText + " from Administrador Where CodAdministrador='" + buscar + "'";
                    }
                    else
                    {
                        if (Cache.Modo == "Alumno" || Cache.Modo == "Tutor")
                        {
                            comando.CommandText = "SELECT Cod" + Cache.Modo + @"
                                            ,Nombres
                                            ,Apellido_Paterno
                                            ,Apellido_Materno
                                            ,Situacion";

                            if (Cache.Modo == "Alumno")
                            {
                                comando.CommandText = comando.CommandText + ",CodTutor";
                            }
                            else { }
                            if (Cache.Completo)
                            {
                                comando.CommandText = comando.CommandText + ",convert(varchar,Contraseña) as Contraseña,Pregunta,Respuesta";
                            }
                            else { }
                            comando.CommandText = comando.CommandText + @",Estado 
                                 FROM " + Cache.Modo + @" 
                                 WHERE Cod" + Cache.Modo + @" like '%" + buscar + @"%' or
                                            Nombres like '%" + buscar + @"%' or
                                            Apellido_Paterno like '%" + buscar + @"%' or
                                            Apellido_Materno like '%" + buscar + @"%' or
                                            Situacion like '%" + buscar + @"%' or";
                            if (Cache.Modo == "Alumno")
                            {
                                comando.CommandText = comando.CommandText + " CodTutor like '%" + buscar + @"%' or";
                            }
                            else { }
                            comando.CommandText = comando.CommandText + " Estado like '%" + buscar + @"%'";
                        }
                        else
                        {
                            if (Cache.Modo == "FichaTutoria")
                            {
                                comando.CommandText = "SELECT * FROM " + Cache.Modo;
                                comando.CommandText = comando.CommandText + " WHERE CodTutor like '%" + buscar + @"%' or
                                             CodAlumno like '%" + buscar + @"%' or
                                             CodFicha like '%" + buscar + @"%' or
                                             Celular like '%" + buscar + @"%' or
                                             Direccion like '%" + buscar + @"%' or
                                             Email like '%" + buscar + @"%'";
                            }
                            else
                            {
                                comando.CommandText = @"SELECT CodFicha,Numero,CodActividad,FORMAT(Fecha,'dd/MM/yyyy hh:mm:ss tt') as Fecha,Tipo_Tutoria,
                                                    Descripcion,Referencia,Observaciones FROM " + Cache.Modo;
                                comando.CommandText = comando.CommandText + " WHERE CodActividad like '%" + buscar + @"%' or
                                              Fecha like '%" + buscar + @"%' or
                                              Tipo_Tutoria like '%" + buscar + @"%' or
                                              Descripcion like '%" + buscar + @"%' or
                                              Referencia like '%" + buscar + @"%' or
                                              Observaciones like '%" + buscar + @"%' or
                                              CodFicha like '%" + buscar + @"%' ";
                            }
                        }
                    }
                    DataTable tabla = new DataTable();
                    SqlDataReader reader = comando.ExecuteReader();
                    tabla.Load(reader);
                    conexion.Close();
                    return tabla;
                }
            }
        }

        
    }
}

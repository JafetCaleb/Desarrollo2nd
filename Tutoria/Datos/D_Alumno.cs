using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using UsuarioCache;

namespace Datos
{
    public class D_Alumno:Conexion
    {
        Conexion conexion = new Conexion();
        public DataTable Buscar(string buscar)
        {
            using (var conexion = get())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    if (Cache.Modo == "ActividadTutoria")
                    {
                        comando.CommandText = @"SELECT A.CodFicha,Numero,
                                        CodActividad,
                                        FORMAT(Fecha,'dd/MM/yyyy hh:mm:ss tt') as Fecha,
                                        Tipo_Tutoria,
                                        Descripcion,
                                        Referencia,
                                        Observaciones
                                        FROM FichaTutoria AS F inner join ActividadTutoria AS A
                                            ON F.CodFicha=A.CodFicha
                                            Where F.CodAlumno = '" + Cache.id + "'";
                        comando.CommandText = comando.CommandText + " and( CodActividad like '%" + buscar + @"%' or
                                              Fecha like '%" + buscar + @"%' or
                                              Tipo_Tutoria like '%" + buscar + @"%' or
                                              Descripcion like '%" + buscar + @"%' or
                                              Referencia like '%" + buscar + @"%' or
                                              Observaciones like '%" + buscar + @"%' or
                                              convert(varchar,Numero) like '%" + buscar + @"%' or
                                              F.CodFicha like '%" + buscar + @"%')";
                    }
                    if (Cache.Modo == "FichaTutoria")
                    {
                        comando.CommandText = @"SELECT *
                                        FROM FichaTutoria
                                        Where CodAlumno = '" + Cache.id + "'";
                        comando.CommandText = comando.CommandText + " and( CodTutor like '%" + buscar + @"%' or
                                             CodAlumno like '%" + buscar + @"%' or
                                             CodFicha like '%" + buscar + @"%' or
                                             Celular like '%" + buscar + @"%' or
                                             Direccion like '%" + buscar + @"%' or
                                             Email like '%" + buscar + @"%')";
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

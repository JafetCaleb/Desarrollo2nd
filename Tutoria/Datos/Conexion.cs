using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Conexion
    {
        string conexionstring;
        public Conexion()
        {
            conexionstring= "Server=tcp:dtutorias.database.windows.net,1433;Initial Catalog=Tutoria;Persist Security Info=False;User ID=desarrollo;Password=Unsaac2017;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        }
        public SqlConnection get()
        {
            return new SqlConnection(conexionstring);
        }

    }
}

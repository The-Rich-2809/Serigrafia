using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectoaula
{
    public class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection conexion;
            SqlConnectionStringBuilder CadenaConexion = new SqlConnectionStringBuilder();
            CadenaConexion.DataSource = @"(localdb)\MSSQLLocalDB";
            CadenaConexion.IntegratedSecurity = true;
            CadenaConexion.InitialCatalog = "Proyectoaula";
            conexion = new SqlConnection(CadenaConexion.ConnectionString);
            return conexion;
        }
    }
}

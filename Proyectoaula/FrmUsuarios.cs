using Proyectoaula.ProyectoaulaDataSetTableAdapters;
using Proyectoaula;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyectoaula
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        SqlConnection cadenaConexion = new SqlConnection("Data Source=EVELINAKKO;Initial Catalog=Proyectoaula;Integrated Security=True");

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            string consulta = "select * from Usuarios";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, cadenaConexion);
        }
    }
}

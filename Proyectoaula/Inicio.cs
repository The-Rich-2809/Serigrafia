using Proyectoaula;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectoaula
{

    public partial class Inicio : Form
    {
        private int idRolUsuario;

        public Inicio(int idRolUsuario)
        {
            InitializeComponent();
            this.idRolUsuario = idRolUsuario;
            CargarMenu();
        }

        private void CargarMenu()
        {
            // Implementa la lógica para cargar el menú según el IdRolUsuario
            List<string> opcionesDeMenu = ObtenerOpcionesDeMenu(idRolUsuario);

            // Mostrar u ocultar elementos de menú según las opciones obtenidas
            foreach (ToolStripItem menuItem in Menuu.Items)
            {
                if (menuItem is ToolStripMenuItem)
                {
                    menuItem.Visible = opcionesDeMenu.Contains(menuItem.Name);
                }
            }
        }

        private List<string> ObtenerOpcionesDeMenu(int idRol)
        {
            // Implementa la lógica para obtener las opciones de menú asociadas al rol desde la base de datos
            List<string> opcionesDeMenu = new List<string>();

            using (SqlConnection con = Conexion.Conectar())
            {
                SqlDataReader lector;
                SqlCommand consulta;
                string sentenciaSql;

                sentenciaSql = @"SELECT NombreMenu FROM Permiso WHERE Id_Rol = @IdRol";

                consulta = new SqlCommand(sentenciaSql, con);
                consulta.Parameters.AddWithValue("@IdRol", idRol);

                try
                {
                    con.Open();
                    lector = consulta.ExecuteReader();

                    while (lector.Read())
                    {
                        opcionesDeMenu.Add(lector["NombreMenu"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return opcionesDeMenu;
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private ToolStripMenuItem MenuActivo;
        private Form FormularioActivo;
        private void AbrirFormulario(ToolStripMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.Silver;
            }

            MenuActivo = menu;
            MenuActivo.BackColor = Color.White;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            // Agregar el formulario al panel o control donde deseas mostrarlo
            // Por ejemplo, si tienes un panel llamado panelContenedor:
            panelContenedor.Controls.Add(formulario);

            formulario.Show();
        }

        private void menuusuarios_Click(object sender, EventArgs e)
        {
                if (sender is ToolStripMenuItem menuItem)
                {
                    AbrirFormulario(menuItem, new FrmUsuarios());
                }
            
        }
        private void MenuCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new FrmCategoria());
        }

        private void MenuProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new FrmProducto());
        }
        private void MenuVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new FrmVenta());
        }

        private void MenuDetalle_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new FrmDetalleVenta());
        }

        private void menuclientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new FrmClientes());
        }

        private void menureportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new FrmReportes());
        }

        private void menuacercade_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new FrmAcercade());
        }


    }
}
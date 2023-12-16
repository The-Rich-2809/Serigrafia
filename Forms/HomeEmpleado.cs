using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serigrafia.Forms
{
    public partial class HomeEmpleado : Form
    {
        private Form Hijo = null;
        public HomeEmpleado()
        {
            InitializeComponent();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbrirHijo(Form Hijito)
        {
            if (Hijo != null)
                Hijo.Close();
            else
            {
                Hijo = Hijito;
                Hijito.TopLevel = false;
                Hijito.FormBorderStyle = FormBorderStyle.None;
                Hijito.Dock = DockStyle.Fill;
                PnlForm.Controls.Add(Hijito);
                PnlForm.Tag = Hijito;
                Hijito.BringToFront();
                Hijito.Show();
                Hijo = null;
            }
        }
        public void inicio()
        {
            Menus interfaz_Home = new Menus();
            AbrirHijo(interfaz_Home);
        }

        private void BtnHome_Click_1(object sender, EventArgs e)
        {
            inicio();
        }

        private void HomeEmpleado_Load(object sender, EventArgs e)
        {
            inicio();
        }

        private void MenuVenta_Click(object sender, EventArgs e)
        {
            AbrirHijo(new Ventas());
        }

        private void MenuVentasRealizadas_Click(object sender, EventArgs e)
        {
            AbrirHijo(new VentasRealizadas());
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

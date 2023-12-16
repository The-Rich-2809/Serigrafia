using Serigrafia.Clases;
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
    public partial class HomeAdmin : Form
    {
        private Form Hijo = null; 
        public HomeAdmin()
        {
            InitializeComponent();
            inicio();
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

        private void menuusuarios_Click(object sender, EventArgs e)
        {
            AbrirHijo(new Usuarios());
        }

        private void HomeAdmin_Load(object sender, EventArgs e)
        {
            inicio();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            inicio();
        }
        public void inicio()
        {
            Menus interfaz_Home = new Menus();
            AbrirHijo(interfaz_Home);
        }

        private void menuclientes_Click(object sender, EventArgs e)
        {
            AbrirHijo(new Clientes());
        }
    }
}

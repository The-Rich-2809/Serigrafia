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
    public partial class Menus : Form
    {
        public Menus()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Hora.Text = DateTime.Now.ToString("HH:mm:ss");
            Fecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}

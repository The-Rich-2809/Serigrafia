﻿using Serigrafia.Clases;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "" && TxtContraseña.Text == "")
            {
                MessageBox.Show("Campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (InicioSesion.IniciaSesion(TxtUsuario.Text, TxtContraseña.Text))
                {
                    TxtContraseña.Text = "";
                    TxtUsuario.Text = "";
                    //this.Hide();

                    if (InicioSesion.nivel == 1)
                    {
                        MessageBox.Show("Entro al sistema", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (InicioSesion.nivel == 2)
                    {
                        MessageBox.Show("Entro al sistema", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                //this.Show();
            }
        }
    }
}

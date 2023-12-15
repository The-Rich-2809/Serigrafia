/*
 * Integrante de equipo no. 5 López Montero Evelyn Sarabi
 * Proyecto aula Avance del 15/12/2023
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Proyectoaula;

namespace Proyectoaula
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void IniciarSesion()
        {
            if (TxtUsuario.Text.Length > 0 && TxtContraseña.Text.Length > 0)
            {
                using (SqlConnection con = Conexion.Conectar())
                {
                    SqlDataReader lector;
                    SqlCommand consulta;
                    string sentenciaSql;

                    sentenciaSql = @"SELECT Id_Rol FROM Usuario WHERE Usuario = @Usuario AND Contraseña = @Contraseña";

                    consulta = new SqlCommand(sentenciaSql, con);
                    consulta.Parameters.AddWithValue("@Usuario", TxtUsuario.Text);
                    consulta.Parameters.AddWithValue("@Contraseña", TxtContraseña.Text);

                    try
                    {
                        con.Open();
                        lector = consulta.ExecuteReader();

                        if (lector.HasRows)
                        {
                            lector.Read();
                            int idRolUsuario = lector.GetInt32(0);

                            // Realiza la carga del formulario principal (Inicio)
                            CargarFormularioPrincipal(idRolUsuario);
                        }
                        else
                        {
                            MessageBox.Show("Usuario y/o contraseña inválidos");
                            TxtUsuario.Text = "";
                            TxtContraseña.Text = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("No puede haber campos en blanco");
                TxtUsuario.Text = "";
                TxtContraseña.Text = "";
            }
        }

        private void CargarFormularioPrincipal(int idRolUsuario)
        {
            // Crear una instancia del formulario principal (Inicio)
            Inicio Inicia = new Inicio(idRolUsuario);

            // Mostrar el formulario principal
            Inicia.Show();

            // Cerrar el formulario actual de inicio de sesión
            this.Hide();
        }
    }
}
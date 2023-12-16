﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Serigrafia.Clases
{
    internal class InicioSesion
    {
        public static int nivel { get; set; }
        public static int usuario { get; set; }

        public static bool IniciaSesion(string Usuario, string Contaseña)
        {
            DataTable UsuariosDT = new DataTable();
            using (SqlConnection Conectar = Conexion.Conectar())
            {
                string Cadena;
                SqlCommand CmdSQL;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                Cadena = @"Select * from Usuario where Usuario = @idusuario and Contrasena = @contra";

                CmdSQL = new SqlCommand(Cadena, Conectar);

                CmdSQL.Parameters.AddWithValue("@idusuario", Usuario);
                CmdSQL.Parameters.AddWithValue("@contra", Contaseña);

                try
                {
                    Conectar.Open();

                    sqlDataAdapter.SelectCommand = CmdSQL;

                    sqlDataAdapter.Fill(UsuariosDT);

                    if (UsuariosDT.Rows.Count > 0)
                    {
                        nivel = Convert.ToInt32(UsuariosDT.Rows[0]["Id_Rol"]);
                        usuario = Convert.ToInt32(UsuariosDT.Rows[0]["Id_Usuario"]);

                        return true;
                    }
                    else
                        MessageBox.Show("Usuario y/p Contraseña son invalidos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return false;
        }
    }
}

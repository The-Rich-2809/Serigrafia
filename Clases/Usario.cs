using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serigrafia.Clases;

namespace Serigrafia.Clases
{
    public class Usario
    {
        public int idusuario { get; set; }
        public string usuario { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public string Contraseña { get; set; }
        public int idrol { get; set; }
        public string Mensaje { get; set; }

        public bool Insertar()
        {
            bool Exito = false;
            using (SqlConnection Con = Conexion.Conectar())
            {
                SqlCommand CMDSql;

                int resultado;
                string Sentencia;

                Sentencia = @"insert into Usuario values (@Usuario, @Nombre, @Correo,@Contrasena,@Id_Rol)";
                CMDSql = new SqlCommand(Sentencia, Con);

                CMDSql.Parameters.AddWithValue("@Usuario", usuario);
                CMDSql.Parameters.AddWithValue("@Nombre", nombre);
                CMDSql.Parameters.AddWithValue("@Correo", correo);
                CMDSql.Parameters.AddWithValue("@Contrasena", Contraseña);
                CMDSql.Parameters.AddWithValue("@Id_Rol", idrol);

                try
                {
                    Con.Open();

                    resultado = CMDSql.ExecuteNonQuery();
                    if (resultado > 0)
                    {

                        Exito = true;
                    }
                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                }
            }
            return Exito;
        }

        public bool Modificar()
        {
            bool Exito = false;
            using (SqlConnection Con = Conexion.Conectar())
            {
                SqlCommand CMDSql;

                int resultado;
                string Sentencia;

                Sentencia = @"update Usuario set Usuario = @Usuario, Nombre = @Nombre, Correo = @Correo, Contrasena = @Contrasena, Id_Rol = @Id_Rol where Id_Usuario = @Id_Usuario";
                CMDSql = new SqlCommand(Sentencia, Con);

                CMDSql.Parameters.AddWithValue("@Usuario", usuario);
                CMDSql.Parameters.AddWithValue("@Nombre", nombre);
                CMDSql.Parameters.AddWithValue("@Correo", correo);
                CMDSql.Parameters.AddWithValue("@Contrasena", Contraseña);
                CMDSql.Parameters.AddWithValue("@Id_Rol", idrol);
                CMDSql.Parameters.AddWithValue("Id_Usuario", idusuario);


                try
                {
                    Con.Open();

                    resultado = CMDSql.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        Exito = true;
                    }
                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                }
            }
            return Exito;
        }

        public bool Eliminar()
        {
            bool Exito = false;
            using (SqlConnection Con = Conexion.Conectar())
            {
                SqlCommand CMDSql;

                int resultado;
                string Sentencia;

                Sentencia = @"delete from Usuario where Id_Usuario = @Id_Usuario";
                CMDSql = new SqlCommand(Sentencia, Con);

                CMDSql.Parameters.AddWithValue("@Id_Usuario", idusuario);


                try
                {
                    Con.Open();

                    resultado = CMDSql.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        Mensaje = "Se agrego el nuevo tipo de madera";
                        Exito = true;
                    }
                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                }
            }
            return Exito;
        }


        public DataTable MostrarUsuarios()
        {
            DataTable Usuario = new DataTable();

            using (SqlConnection Conectar = Conexion.Conectar())
            {
                string Cadena;
                SqlCommand CmdSQL;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                Cadena = @"Select * from Usuario";

                CmdSQL = new SqlCommand(Cadena, Conectar);

                try
                {
                    Conectar.Open();

                    sqlDataAdapter.SelectCommand = CmdSQL;

                    sqlDataAdapter.Fill(Usuario);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return Usuario;
        }
    }
}

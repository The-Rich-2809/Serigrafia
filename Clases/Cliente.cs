using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serigrafia.Clases
{
    internal class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }


        public DataTable MostrarClientes()
        {
            DataTable Almacen = new DataTable();

            using (SqlConnection Conectar = Conexion.Conectar())
            {
                string Cadena;
                SqlCommand CmdSQL;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                Cadena = @"Select * from Producto";

                CmdSQL = new SqlCommand(Cadena, Conectar);

                try
                {
                    Conectar.Open();

                    sqlDataAdapter.SelectCommand = CmdSQL;

                    sqlDataAdapter.Fill(Almacen);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return Almacen;
        }
        public bool InsertarClientes()
        {
            bool Exito = false;
            using (SqlConnection Con = Conexion.Conectar())
            {
                SqlCommand CMDSql;

                int resultado;
                string Sentencia;

                Sentencia = @"insert into Cliente values (@Nombre, @Direccion, @Telefono)";
                CMDSql = new SqlCommand(Sentencia, Con);

                CMDSql.Parameters.AddWithValue("@Nombre", Nombre);
                CMDSql.Parameters.AddWithValue("@Direccion", Direccion);
                CMDSql.Parameters.AddWithValue("@Telefono", Telefono);

                try
                {
                    Con.Open();

                    resultado = CMDSql.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        Exito = true;
                        MessageBox.Show("Agregado el cliente");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return Exito;
        }
        public bool ModificarClientes()
        {
            bool Exito = false;
            using (SqlConnection Con = Conexion.Conectar())
            {
                SqlCommand CMDSql;

                int resultado;
                string Sentencia;

                Sentencia = @"update Cliente set Nombre = @Nombre, Dirrecion = @Direccion, Telefono = @Telefono where Id_Cliente = @IdCliente";
                CMDSql = new SqlCommand(Sentencia, Con);

                CMDSql.Parameters.AddWithValue("@Nombre", Nombre);
                CMDSql.Parameters.AddWithValue("@Direccion", Direccion);
                CMDSql.Parameters.AddWithValue("@Telefono", Telefono);
                CMDSql.Parameters.AddWithValue("@IdCliente", IdCliente);


                try
                {
                    Con.Open();

                    resultado = CMDSql.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        MessageBox.Show("Se modifico el cliente");
                        Exito = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return Exito;
        }
        public bool Eliminar_Tabla(int i)
        {
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdCreate;
                int filasafectadas;
                string sentencia = @"delete from Cliente where Id_Cliente = @id";
                cmdCreate = new SqlCommand(sentencia, conexion);
                cmdCreate.Parameters.AddWithValue("@id", Convert.ToString(i));
                try
                {
                    conexion.Open();
                    filasafectadas = cmdCreate.ExecuteNonQuery();
                    if (filasafectadas > 0)
                    {
                        MessageBox.Show("Elimidano el cliente");
                        return true;
                    }
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

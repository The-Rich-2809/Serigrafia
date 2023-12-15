using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Serigrafia.Clases
{
    internal class Producto
    {
        public int Id_Producto { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Id_Catalogo { get; set; }
        public int Stock { get; set; }
        public double Precio_Compra { get; set; }
        public double Precio_Venta { get; set; }
        public string Mensaje { get; set; }
        public bool Insertar()
        {
            bool Exito = false;
            using (SqlConnection Con = Conexion.Conectar())
            {
                SqlCommand CMDSql;

                int resultado;
                string Sentencia;

                Sentencia = @"insert into Producto values (@Codigo, @Nombre, @Descripcion, @Id_Catalogo, @Stock, @Precio_Compra, @Precio_Venta)";
                CMDSql = new SqlCommand(Sentencia, Con);

                CMDSql.Parameters.AddWithValue("@Codigo", Codigo);
                CMDSql.Parameters.AddWithValue("@Nombre", Nombre);
                CMDSql.Parameters.AddWithValue("@Descripcion", Descripcion);
                CMDSql.Parameters.AddWithValue("@Id_Catalogo", Id_Catalogo);
                CMDSql.Parameters.AddWithValue("@Stock", Stock);
                CMDSql.Parameters.AddWithValue("@Precio_Compra", Precio_Compra);
                CMDSql.Parameters.AddWithValue("@Precio_Venta", Precio_Venta);


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

                Sentencia = @"update Producto set Codigo = @Codigo,  Nombre = @Nombre,  Descripcion = @Descripcion,  Id_Catalogo = @Id_Catalogo,  Stock = @Stock,  Precio_Compra = @Precio_Compra,  Precio_Venta = @Precio_Venta where Id_Producto = @Id_Producto";
                CMDSql = new SqlCommand(Sentencia, Con);

                
                CMDSql.Parameters.AddWithValue("@Codigo", Codigo);
                CMDSql.Parameters.AddWithValue("@Nombre", Nombre);
                CMDSql.Parameters.AddWithValue("@Descripcion", Descripcion);
                CMDSql.Parameters.AddWithValue("@Id_Catalogo", Id_Catalogo);
                CMDSql.Parameters.AddWithValue("@Stock", Stock);
                CMDSql.Parameters.AddWithValue("@Precio_Compra", Precio_Compra);
                CMDSql.Parameters.AddWithValue("@Precio_Venta", Precio_Venta);
                CMDSql.Parameters.AddWithValue("@Id_Producto", Id_Producto);


                try
                {
                    Con.Open();

                    resultado = CMDSql.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        Mensaje = "Se agrego el nuevo producto";
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

                Sentencia = @"delete from Producto where Id_Producto = @Id_Producto";
                CMDSql = new SqlCommand(Sentencia, Con);

                CMDSql.Parameters.AddWithValue("@Id_Producto", Id_Producto);


                try
                {
                    Con.Open();

                    resultado = CMDSql.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        Mensaje = "Se agrego el nuevo producto";
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

        public DataTable MostrarProductos()
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
    }
}

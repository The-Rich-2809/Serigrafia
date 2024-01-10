using iText.Kernel.Geom;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using Serigrafia.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Layout;

namespace Serigrafia.Forms
{
    public partial class Ventas : Form
    {
        public HomeEmpleado Home = new HomeEmpleado();
        static DataTable Venta = new DataTable();
        public Ventas()
        {
            InitializeComponent();
            this.Dgv_ProductosSeleccionados.ColumnCount = 8;
            label3.Text = InicioSesion.usuario.ToString();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            MostrarTabla();
            MostrarClientes();
        }
        public void MostrarTabla()
        {
            Dgv_Ventas.DataSource = MostrarT();
        }
        public DataTable MostrarT()
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

        private void MostrarClientes()
        {
            DataTable Almacen = new DataTable();

            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapterLibros = new SqlDataAdapter();

                string sentencia = "Select * from Cliente";

                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    adapterLibros.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapterLibros.Fill(Almacen);
                    Cb_Clientes.DataSource = Almacen;
                    Cb_Clientes.DisplayMember = Almacen.Columns[1].ToString();
                    Cb_Clientes.ValueMember = Almacen.Columns[0].ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Btn_Terminar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            double Total = 0;
            string Id;
            int cantidaIncial = 0;
            int cantidadParcial = 0;
            int cantidadFinal = 0;
            string NomUser = "";
            //int RenglonSeleccionado = Dgv_Ventas.CurrentRow.Index;
            //string h = Dgv_Ventas.Rows[RenglonSeleccionado].Cells[7].Value.ToString();

            DialogResult Resultado = MessageBox.Show("¿Desea terminar la venta?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resultado == DialogResult.Yes)
            {
                for (int i = 0; i < Dgv_ProductosSeleccionados.Rows.Count - 1; i++)
                {
                    Total += Convert.ToDouble(Dgv_ProductosSeleccionados.Rows[i].Cells[7].Value.ToString()) *
                        Convert.ToDouble(Dgv_ProductosSeleccionados.Rows[i].Cells[5].Value.ToString());
                    Id = Dgv_ProductosSeleccionados.Rows[i].Cells[0].Value.ToString();
                    cantidadParcial = Convert.ToInt32(Dgv_ProductosSeleccionados.Rows[i].Cells[5].Value.ToString());

                    producto.Id_Producto = Convert.ToInt32(Id);
                    cantidaIncial = producto.SacarExistencia();
                    cantidadFinal = cantidaIncial - cantidadParcial;
                    producto.ModificarStock(cantidadFinal);
                }

                label4.Text = Convert.ToString(Total);
                NomUser = producto.SacarNomUser(label3.Text);
                Insertar(NomUser);
                IPDF(NomUser);
                Home.MenuVenta_Click(this, EventArgs.Empty);
                MessageBox.Show("Se realizo la venta adecuadamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dgv_ProductosSeleccionados.Rows.Clear();
                MostrarTabla();
            }
        }

        public bool Insertar(string NomUser)
        {
            bool Exito = false;
            using (SqlConnection Con = Conexion.Conectar())
            {
                SqlCommand CMDSql;

                int resultado;
                string Sentencia;

                Sentencia = @"insert into Venta values (@Id_Usuario, @NomUser,@NombreCliente, @MontoTotal)";
                CMDSql = new SqlCommand(Sentencia, Con);

                CMDSql.Parameters.AddWithValue("@Id_Usuario", label3.Text);
                CMDSql.Parameters.AddWithValue("@NomUser", NomUser);
                CMDSql.Parameters.AddWithValue("@NombreCliente", Cb_Clientes.Text);
                CMDSql.Parameters.AddWithValue("@MontoTotal", Convert.ToDouble(label4.Text));


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
                    MessageBox.Show(ex.Message);
                }
            }
            return Exito;
        }
        public DataTable Mostar_Id()
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

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            string[] producto = new string[8];
            int RenglonSeleccionado = Dgv_Ventas.CurrentRow.Index;
            for(int i = 0; i < 8; i++ )
            {
                producto[i] = Dgv_Ventas.Rows[RenglonSeleccionado].Cells[i].Value.ToString();
            }
            producto[5] = numericUpDown1.Value.ToString();
            object[] array = producto;
            Dgv_ProductosSeleccionados.Rows.Add(array);
            numericUpDown1.Value = 1;
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            int RenglonSeleccionado = Dgv_ProductosSeleccionados.CurrentRow.Index;
            DialogResult Resultado = MessageBox.Show("¿Desea eliminar el producto?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resultado == DialogResult.Yes)
            {
                if (RenglonSeleccionado >= 0)
                {
                    Dgv_ProductosSeleccionados.Rows.RemoveAt(RenglonSeleccionado);
                    MessageBox.Show("Se elimino el producto adecuadamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
               

        }

        public void IPDF(string NomUser)
        {

            int RenglonSeleccionado = Dgv_Ventas.CurrentRow.Index;
            SaveFileDialog GuardaArchivoPdf = new SaveFileDialog();
            int cant = Convert.ToInt32(numericUpDown1.Value);
            string rp = @"Factura Nº " + EncontrarIDMax();
            GuardaArchivoPdf.Filter = "Archivos PDF|*.pdf";
            GuardaArchivoPdf.FileName = @"Factura Nº " + EncontrarIDMax();
            if (GuardaArchivoPdf.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(GuardaArchivoPdf.FileName, FileMode.Create))
                {
                    PdfWriter pdfWriter = new PdfWriter(stream);
                    PdfDocument pdfDocument = new PdfDocument(pdfWriter);
                    PageSize pageSize = PageSize.A7.Rotate();

                    Document MiDocumento = new Document(pdfDocument);
                    PdfCanvas canvas = new PdfCanvas(pdfDocument.AddNewPage());

                    string nombrep = Dgv_Ventas.Rows[RenglonSeleccionado].Cells[1].Value.ToString();

                    MiDocumento.Add(new Paragraph("************************************************"));
                    MiDocumento.Add(new Paragraph("Factura Nº: " + EncontrarIDMax()));
                    MiDocumento.Add(new Paragraph("Fecha: " + DateTime.Now));
                    MiDocumento.Add(new Paragraph("************************************************"));
                    MiDocumento.Add(new Paragraph(NomUser));



                    MiDocumento.Add(new Paragraph("Cantidad      Producto              "));
                    for (int i = 0; i < Dgv_ProductosSeleccionados.RowCount - 1; i++)
                    {
                        MiDocumento.Add(new Paragraph(Dgv_ProductosSeleccionados.Rows[i].Cells[5].Value.ToString() + "            " + Dgv_ProductosSeleccionados.Rows[i].Cells[2].Value.ToString()));
                    }

                    MiDocumento.Add(new Paragraph($"Cliente: {Cb_Clientes.Text}            "));

                    MiDocumento.Add(new Paragraph("************************************************"));
                    MiDocumento.Add(new Paragraph("TOTAL:                             $" + label4.Text));
                    MiDocumento.Add(new Paragraph("************************************************"));
                    MiDocumento.Add(new Paragraph("Gracias por su compra"));
                    MiDocumento.Close();
                }

            }
        }

        private int EncontrarIDMax()
        {
            int Idp = 0;

            DataTable Productos = new DataTable();
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapterLibros = new SqlDataAdapter();

                string sentencia = "select MAX(Id_Venta) as id from Venta";
                cmdSelect = new SqlCommand(sentencia, conexion);

                try
                {
                    adapterLibros.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapterLibros.Fill(Productos);

                    string temporal = Productos.Rows[0]["id"].ToString();

                    if (temporal == "")
                        Idp = 1;
                    else
                        Idp = (Int32)Productos.Rows[0]["id"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return Idp;
        }
    }
}

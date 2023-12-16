﻿using Serigrafia.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serigrafia.Forms
{
    public partial class Ventas : Form
    {
        static DataTable Venta = new DataTable();
        public Ventas()
        {
            InitializeComponent();
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
            int RenglonSeleccionado = Dgv_Ventas.CurrentRow.Index;
            string h = Dgv_Ventas.Rows[RenglonSeleccionado].Cells[7].Value.ToString();
            label4.Text = h;
            DialogResult Resultado = MessageBox.Show("¿Desea terminar la venta?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resultado == DialogResult.Yes)
            {
                Insertar();
                MessageBox.Show("Se realizo la venta adecuadamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
        }
        public bool Insertar()
        {
            bool Exito = false;
            using (SqlConnection Con = Conexion.Conectar())
            {
                SqlCommand CMDSql;

                int resultado;
                string Sentencia;

                Sentencia = @"insert into Venta values (@Id_Usuario, @NombreCliente, @MontoTotal)";
                CMDSql = new SqlCommand(Sentencia, Con);

                CMDSql.Parameters.AddWithValue("@Id_Usuario", label3.Text);
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
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serigrafia.Clases;

namespace Serigrafia.Forms
{
    public partial class Clientes : Form
    {
        Cliente clientes = new Cliente();
        public static int Boton { get; set; } 
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            MostrarEmpleados();
            Mostrar(1, false, Color.Gray);
            Boton = 0;
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            Mostrar(2, true, Color.White);
            Boton = 1;
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            int RenglonSeleccionado = Dgv_Data.CurrentRow.Index;
            clientes.IdCliente = Convert.ToInt32(Dgv_Data.Rows[RenglonSeleccionado].Cells[0].Value.ToString());
            clientes.Nombre = Convert.ToString(Dgv_Data.Rows[RenglonSeleccionado].Cells[1].Value.ToString());
            clientes.Direccion = Convert.ToString(Dgv_Data.Rows[RenglonSeleccionado].Cells[2].Value.ToString());
            clientes.Telefono = Convert.ToString(Dgv_Data.Rows[RenglonSeleccionado].Cells[3].Value.ToString());

            Mostrar(2, true, Color.White);

            Txt_Nombre.Text = clientes.Nombre;
            Txt_Direccion.Text = clientes.Direccion;
            Txt_Telefono.Text = clientes.Telefono;

            Boton = 2;
        }
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            int RenglonSeleccionado = Dgv_Data.CurrentRow.Index;
            int Id = Convert.ToInt32(Dgv_Data.Rows[RenglonSeleccionado].Cells[0].Value.ToString());
            DialogResult Resultado = MessageBox.Show("¿Desea eliminar al Cliente con Id " + Id + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (Resultado == DialogResult.Yes)
            {
                clientes.Eliminar_Tabla(Id);
            }

            MostrarEmpleados();
            Mostrar(1, false, Color.Gray);
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            MostrarEmpleados();
            Mostrar(1, false, Color.Gray);
            Boton = 0;
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if(ValidarCampos())
            {
                clientes.Nombre = Txt_Nombre.Text;
                clientes.Direccion = Txt_Direccion.Text;
                clientes.Telefono = Txt_Telefono.Text;

                Mostrar(1, false, Color.Gray);

                switch (Boton)
                {
                    case 1:
                        clientes.InsertarClientes();
                        break;
                    case 2:
                        clientes.ModificarClientes();
                        break;
                }

                Boton = 0;
                MostrarEmpleados();
            }
            
        }

        //Mostrar Datos
        public void Mostrar(int s, bool tf, Color color)
        {
            foreach (Control c in this.Pnl_Datos.Controls)
            {
                c.Enabled = tf;
                if (c is TextBox || c is ComboBox)
                {
                    c.BackColor = color;
                    c.Text = "";

                }
                if (c is Button)
                {
                    if (tf == true)
                    {
                        c.Enabled = false;
                        c.BackColor = Color.Gray;
                    }
                    else
                    {
                        c.Enabled = true;
                        c.BackColor = Color.White;
                    }
                }
            }

            switch (s)
            {
                case 1:
                    Btn_Guardar.Enabled = false;
                    Btn_Cancelar.Enabled = false;
                    Btn_Cancelar.BackColor = Color.Gray;
                    Btn_Guardar.BackColor = Color.Gray;

                    break;
                case 2:
                    Btn_Guardar.Enabled = true;
                    Btn_Cancelar.Enabled = true;
                    Btn_Cancelar.BackColor = Color.White;
                    Btn_Guardar.BackColor = Color.White;
                    break;
            }
            MostrarEmpleados();
        }
        private void MostrarEmpleados()
        {
            //DgvAlmacen.AutoSize = true;
            Dgv_Data.DataSource = clientes.MostrarClientes();
        }
        
        //Validaciones

        //Validacion de los campos
        private bool ValidarCampos()
        {
            foreach (Control c in this.Pnl_Datos.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text == "")
                    {
                        MessageBox.Show("Hay campos vacios");
                        return false;
                    }
                }
            }
            return true;
        }
    }
}

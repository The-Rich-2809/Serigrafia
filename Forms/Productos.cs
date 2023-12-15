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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();

            MostrarAlmacen();
            Mostrar(1, false, Color.Gray);
        }
        int op = 0;

        private void TxtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            int renglon;
            string id;

            renglon = DgvAlmacen.CurrentRow.Index;
            id = DgvAlmacen.Rows[renglon].Cells[0].Value.ToString();
            producto.Id_Producto = Convert.ToInt32(id);

            DialogResult Resultado = MessageBox.Show("¿Desea elimar el registro " + id + " ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resultado == DialogResult.Yes)
            {
                if (producto.Eliminar())
                {
                    MessageBox.Show("Registro eliminado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarAlmacen();
                    HabilitaBotones();
                    Mostrar(1, false, Color.Gray);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            int renglon;
            string id;

            switch (op)
            {
                case 1:
                    producto.Id_Producto = Convert.ToInt32(textBox1.Text);
                    producto.Codigo = textBox2.Text;
                    producto.Nombre = textBox3.Text;
                    producto.Descripcion = textBox4.Text;
                    producto.Id_Catalogo = Convert.ToInt32(numericUpDown1.Value);
                    producto.Stock = Convert.ToInt32(numericUpDown2.Value);
                    producto.Precio_Compra = Convert.ToInt32(numericUpDown4.Value);
                    producto.Precio_Venta = Convert.ToInt32(numericUpDown3.Value);

                    if (ValidaCampos(1))
                    {
                        QuitarValidacion();
                        if (producto.Insertar())
                        {
                            MessageBox.Show("Registro agregado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiaCampos();
                            MostrarAlmacen();
                            HabilitaBotones();
                            Mostrar(1, false, Color.Gray);
                        }
                    }
                    break;
                case 2:
                    renglon = DgvAlmacen.CurrentRow.Index;
                    id = DgvAlmacen.Rows[renglon].Cells[0].Value.ToString();
                    producto.Codigo = textBox2.Text;
                    producto.Nombre = textBox3.Text;
                    producto.Descripcion = textBox4.Text;
                    producto.Id_Catalogo = Convert.ToInt32(numericUpDown1.Value);
                    producto.Stock = Convert.ToInt32(numericUpDown2.Value);
                    producto.Precio_Compra = Convert.ToInt32(numericUpDown4.Value);
                    producto.Precio_Venta = Convert.ToInt32(numericUpDown3.Value);
                    producto.Id_Producto = Convert.ToInt32(id);

                    if (ValidaCampos(2))
                    {
                        QuitarValidacion();
                        if (producto.Modificar())
                        {
                            MessageBox.Show("Registro modificado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiaCampos();
                            MostrarAlmacen();
                            HabilitaBotones();
                            Mostrar(1, false, Color.Gray);
                        }
                    }
                    break;
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Mostrar(2, true, Color.White);

            op = 2;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Mostrar(1, false, Color.Gray);
            LimpiaCampos();
        }

        private void HabilitaBotones()
        {
            foreach (Control b in panel1.Controls)
            {
                if (b is Button)
                {
                    b.Enabled = true;
                }
            }
        }

        private void LimpiaCampos()
        {
            foreach (Control c in panel1.Controls)
            {
                if (c is TextBox)
                {
                    TextBox x;
                    x = (TextBox)c;
                    x.Clear();
                }
            }
        }

        public void Mostrar(int s, bool tf, Color color)
        {
            foreach (Control c in this.panel1.Controls)
            {
                c.Enabled = tf;
                if (c is TextBox)
                {
                    c.BackColor = color;
                }
                if (c is Button)
                {
                    if (tf == true)
                    {
                        c.Enabled = false;
                    }
                    else
                    {
                        c.Enabled = true;
                    }
                }
            }

            switch (s)
            {
                case 1:
                    button2.Enabled = false;
                    button5.Enabled = false;

                    break;
                case 2:
                    button2.Enabled = true;
                    button5.Enabled = true;
                    break;
            }

        }

        private bool ValidaCampos(int op)
        {
            bool valido = true;
            if (op == 1)
            {
                errorProvider1.SetError(textBox1, "Este campo no debe estar vacio");
                errorProvider1.SetError(textBox2, "Este campo no debe estar vacio");
                errorProvider1.SetError(textBox3, "Este campo no debe estar vacio");
                errorProvider1.SetError(textBox4, "Este campo no debe estar vacio");
            }
            if (op == 2)
            {
                errorProvider1.SetError(textBox1, "Este campo no debe estar vacio");
                errorProvider1.SetError(textBox2, "Este campo no debe estar vacio");
                errorProvider1.SetError(textBox3, "Este campo no debe estar vacio");
                errorProvider1.SetError(textBox4, "Este campo no debe estar vacio");
            }
            return valido;
        }

        private void QuitarValidacion()
        {
            errorProvider1.SetError(textBox1, "");
            errorProvider1.SetError(textBox2, "");
            errorProvider1.SetError(textBox3, "");
            errorProvider1.SetError(textBox4, "");
        }

        private void MostrarAlmacen()
        {
            Producto almacen = new Producto();

            DgvAlmacen.AutoSize = true;
            DgvAlmacen.DataSource = almacen.MostrarProductos();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mostrar(2, true, Color.White);


            op = 1;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mostrar(2, true, Color.White);

            op = 2;
        }
    }
}

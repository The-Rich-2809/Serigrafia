using Serigrafia.Clases;
using System;
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
    public partial class Usuarios : Form
    {
        int op;
        public Usuarios()
        {
            InitializeComponent();
            MostrarUsuario();
            Mostrar(1, false, Color.Goldenrod);
        }

        private void HabilitaBotones()
        {
            foreach (Control b in Pnlinserstar.Controls)
            {
                if (b is Button)
                {
                    b.Enabled = true;
                }
            }
        }

        private void LimpiaCampos()
        {
            foreach (Control c in Pnlinserstar.Controls)
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
            foreach (Control c in this.Pnlinserstar.Controls)
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
                if (c is ComboBox)
                    c.BackColor = color;
            }

            switch (s)
            {
                case 1:
                    BtnGuardar.Enabled = false;
                    BtnCancelar.Enabled = false;

                    break;
                case 2:
                    BtnGuardar.Enabled = true;
                    BtnCancelar.Enabled = true;
                    break;
            }

        }
        private void MostrarUsuario()
        {
            Usario usuario = new Usario();

            //DgvUsuarios.AutoSize = true;
            DgvUsuarios.DataSource = usuario.MostrarUsuarios();

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Mostrar(2, true, Color.White);

            op = 1;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            int renglon;
            string id, idprod;

            renglon = DgvUsuarios.CurrentRow.Index;
            id = DgvUsuarios.Rows[renglon].Cells[0].Value.ToString();

            Mostrar(2, true, Color.White);

            DataTable Productos = new DataTable();

            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapterLibros = new SqlDataAdapter();

                string sentencia = "Select * from Usuario where Id_Usuario = @id";
                cmdSelect = new SqlCommand(sentencia, conexion);
                cmdSelect.Parameters.AddWithValue("@id", Convert.ToInt32(id));

                try
                {
                    adapterLibros.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapterLibros.Fill(Productos);
                    TxtUsuario.Text = Productos.Rows[0]["Usuario"].ToString();
                    TxtContraseña.Text = Productos.Rows[0]["Contrasena"].ToString();
                    TxtNombre.Text = Productos.Rows[0]["Nombre"].ToString();
                    TxtCorreo.Text = Productos.Rows[0]["Correo"].ToString();
                    CmbRol.SelectedIndex = (Int32)Productos.Rows[0]["Id_Rol"] - 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            op = 2;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Usario us = new Usario();   
            int renglon;
            string id;

            renglon = DgvUsuarios.CurrentRow.Index;
            id = DgvUsuarios.Rows[renglon].Cells[0].Value.ToString();
            us.idusuario = Convert.ToInt32(id);

            DialogResult Resultado = MessageBox.Show("¿Desea elimar el registro " + id + " ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resultado == DialogResult.Yes)
            {
                if (us.Eliminar())
                {
                    MessageBox.Show("Registro eliminado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarUsuario();
                    HabilitaBotones();
                    Mostrar(1, false, Color.Gray);
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Usario us = new Usario();

            int renglon;
            string id;

            switch (op)
            {
                case 1:
                    us.usuario = TxtUsuario.Text;
                    us.nombre = TxtNombre.Text;
                    us.correo = TxtCorreo.Text;
                    us.Contraseña = TxtContraseña.Text;
                    us.idrol = Convert.ToInt32(CmbRol.Text);

                    if (ValidaCampos(1))
                    {
                        QuitarValidacion();
                        if (us.Insertar())
                        {
                            MessageBox.Show("Registro agregado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiaCampos();
                            MostrarUsuario();
                            HabilitaBotones();
                            Mostrar(1, false, Color.Gray);
                        }
                    }
                    break;
                case 2:
                    renglon = DgvUsuarios.CurrentRow.Index;
                    id = DgvUsuarios.Rows[renglon].Cells[0].Value.ToString();
                    us.usuario = TxtUsuario.Text;
                    us.nombre = TxtNombre.Text;
                    us.correo = TxtCorreo.Text;
                    us.Contraseña = TxtContraseña.Text;
                    us.idrol = Convert.ToInt32(CmbRol.Text);
                    us.idusuario = Convert.ToInt32(id);


                    if (ValidaCampos(2))
                    {
                        QuitarValidacion();
                        if (us.Modificar())
                        {
                            MessageBox.Show("Registro modificado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiaCampos();
                            MostrarUsuario();
                            HabilitaBotones();
                            Mostrar(1, false, Color.Gray);
                        }
                    }
                    break;
            }
        }

        private bool ValidaCampos(int op)
        {
            bool valido = true;
            if (op == 1)
            {
                errorProvider1.SetError(TxtNombre, "Este campo no debe estar vacio");
                errorProvider1.SetError(TxtUsuario, "Este campo no debe estar vacio");
                errorProvider1.SetError(TxtCorreo, "Este campo no debe estar vacio");
                errorProvider1.SetError(TxtContraseña, "Este campo no debe estar vacio");
            }
            if (op == 2)
            {
                errorProvider1.SetError(TxtNombre, "Este campo no debe estar vacio");
                errorProvider1.SetError(TxtUsuario, "Este campo no debe estar vacio");
                errorProvider1.SetError(TxtCorreo, "Este campo no debe estar vacio");
                errorProvider1.SetError(TxtContraseña, "Este campo no debe estar vacio");
            }
            return valido;
        }

        private void QuitarValidacion()
        {
            errorProvider1.SetError(TxtNombre, "");
            errorProvider1.SetError(TxtUsuario, "");
            errorProvider1.SetError(TxtCorreo, "");
            errorProvider1.SetError(TxtContraseña, "");
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Mostrar(1, false, Color.Gray);
            LimpiaCampos();
        }
    }
}

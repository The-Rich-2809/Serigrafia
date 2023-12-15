namespace Proyectoaula
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menuu = new System.Windows.Forms.MenuStrip();
            this.menuusuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuproductos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuventas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDetalle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuclientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menureportes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuacercade = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTitulo = new System.Windows.Forms.MenuStrip();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.Menuu.SuspendLayout();
            this.MenuTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menuu
            // 
            this.Menuu.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Menuu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menuu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuusuarios,
            this.menuproductos,
            this.menuventas,
            this.menuclientes,
            this.menureportes,
            this.menuacercade});
            this.Menuu.Location = new System.Drawing.Point(0, 64);
            this.Menuu.Name = "Menuu";
            this.Menuu.Size = new System.Drawing.Size(1164, 30);
            this.Menuu.TabIndex = 0;
            this.Menuu.Text = "menuStrip1";
            // 
            // menuusuarios
            // 
            this.menuusuarios.AutoSize = false;
            this.menuusuarios.ForeColor = System.Drawing.Color.Black;
            this.menuusuarios.Image = global::Proyectoaula.Properties.Resources.customer_686348;
            this.menuusuarios.Name = "menuusuarios";
            this.menuusuarios.Size = new System.Drawing.Size(109, 26);
            this.menuusuarios.Text = "Usuarios";
            this.menuusuarios.Click += new System.EventHandler(this.menuusuarios_Click);
            // 
            // menuproductos
            // 
            this.menuproductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCategoria,
            this.MenuProducto});
            this.menuproductos.ForeColor = System.Drawing.Color.Black;
            this.menuproductos.Image = global::Proyectoaula.Properties.Resources.list_1950630;
            this.menuproductos.Name = "menuproductos";
            this.menuproductos.Size = new System.Drawing.Size(109, 26);
            this.menuproductos.Text = "Productos";
            // 
            // MenuCategoria
            // 
            this.MenuCategoria.Name = "MenuCategoria";
            this.MenuCategoria.Size = new System.Drawing.Size(157, 26);
            this.MenuCategoria.Text = "Categoria";
            this.MenuCategoria.Click += new System.EventHandler(this.MenuCategoria_Click);
            // 
            // MenuProducto
            // 
            this.MenuProducto.Name = "MenuProducto";
            this.MenuProducto.Size = new System.Drawing.Size(157, 26);
            this.MenuProducto.Text = "Producto";
            this.MenuProducto.Click += new System.EventHandler(this.MenuProducto_Click);
            // 
            // menuventas
            // 
            this.menuventas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuVenta,
            this.MenuDetalle});
            this.menuventas.ForeColor = System.Drawing.Color.Black;
            this.menuventas.Image = global::Proyectoaula.Properties.Resources.shopping_cart_2838838;
            this.menuventas.Name = "menuventas";
            this.menuventas.Size = new System.Drawing.Size(80, 26);
            this.menuventas.Text = "Venta";
            // 
            // MenuVenta
            // 
            this.MenuVenta.Name = "MenuVenta";
            this.MenuVenta.Size = new System.Drawing.Size(192, 26);
            this.MenuVenta.Text = "Registrar Venta";
            this.MenuVenta.Click += new System.EventHandler(this.MenuVenta_Click);
            // 
            // MenuDetalle
            // 
            this.MenuDetalle.Name = "MenuDetalle";
            this.MenuDetalle.Size = new System.Drawing.Size(192, 26);
            this.MenuDetalle.Text = "Ver Detalle";
            this.MenuDetalle.Click += new System.EventHandler(this.MenuDetalle_Click);
            // 
            // menuclientes
            // 
            this.menuclientes.ForeColor = System.Drawing.Color.Black;
            this.menuclientes.Image = global::Proyectoaula.Properties.Resources.customer_3126647;
            this.menuclientes.Name = "menuclientes";
            this.menuclientes.Size = new System.Drawing.Size(95, 26);
            this.menuclientes.Text = "Clientes";
            this.menuclientes.Click += new System.EventHandler(this.menuclientes_Click);
            // 
            // menureportes
            // 
            this.menureportes.ForeColor = System.Drawing.Color.Black;
            this.menureportes.Image = global::Proyectoaula.Properties.Resources.diagram_2285559;
            this.menureportes.Name = "menureportes";
            this.menureportes.Size = new System.Drawing.Size(102, 26);
            this.menureportes.Text = "Reportes";
            this.menureportes.Click += new System.EventHandler(this.menureportes_Click);
            // 
            // menuacercade
            // 
            this.menuacercade.ForeColor = System.Drawing.Color.Black;
            this.menuacercade.Image = global::Proyectoaula.Properties.Resources.settings_807313;
            this.menuacercade.Name = "menuacercade";
            this.menuacercade.Size = new System.Drawing.Size(121, 26);
            this.menuacercade.Text = "Acerca de....";
            this.menuacercade.Click += new System.EventHandler(this.menuacercade_Click);
            // 
            // MenuTitulo
            // 
            this.MenuTitulo.AutoSize = false;
            this.MenuTitulo.BackColor = System.Drawing.Color.Goldenrod;
            this.MenuTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuTitulo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem});
            this.MenuTitulo.Location = new System.Drawing.Point(0, 0);
            this.MenuTitulo.Name = "MenuTitulo";
            this.MenuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuTitulo.Size = new System.Drawing.Size(1164, 64);
            this.MenuTitulo.TabIndex = 1;
            this.MenuTitulo.Text = "menuStrip2";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(137, 60);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Aplicacion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Goldenrod;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Serigrafia";
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 94);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1164, 461);
            this.panelContenedor.TabIndex = 3;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 555);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Menuu);
            this.Controls.Add(this.MenuTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.Menuu;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Menuu.ResumeLayout(false);
            this.Menuu.PerformLayout();
            this.MenuTitulo.ResumeLayout(false);
            this.MenuTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menuu;
        private System.Windows.Forms.MenuStrip MenuTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem menuusuarios;
        private System.Windows.Forms.ToolStripMenuItem menuproductos;
        private System.Windows.Forms.ToolStripMenuItem menuventas;
        private System.Windows.Forms.ToolStripMenuItem menuclientes;
        private System.Windows.Forms.ToolStripMenuItem menureportes;
        private System.Windows.Forms.ToolStripMenuItem menuacercade;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuCategoria;
        private System.Windows.Forms.ToolStripMenuItem MenuProducto;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.ToolStripMenuItem MenuVenta;
        private System.Windows.Forms.ToolStripMenuItem MenuDetalle;
    }
}


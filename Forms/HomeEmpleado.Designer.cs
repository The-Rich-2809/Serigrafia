namespace Serigrafia.Forms
{
    partial class HomeEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MenuTitulo = new System.Windows.Forms.MenuStrip();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Menuu = new System.Windows.Forms.MenuStrip();
            this.menuventas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVentasRealizadas = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnHome = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlForm = new System.Windows.Forms.Panel();
            this.MenuTitulo.SuspendLayout();
            this.Menuu.SuspendLayout();
            this.SuspendLayout();
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
            this.MenuTitulo.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MenuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuTitulo.Size = new System.Drawing.Size(1473, 64);
            this.MenuTitulo.TabIndex = 3;
            this.MenuTitulo.Text = "menuStrip2";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(137, 60);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Aplicacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Goldenrod;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 43);
            this.label1.TabIndex = 4;
            this.label1.Text = "Serigrafia";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Menuu
            // 
            this.Menuu.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Menuu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menuu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuventas,
            this.BtnHome});
            this.Menuu.Location = new System.Drawing.Point(0, 64);
            this.Menuu.Name = "Menuu";
            this.Menuu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.Menuu.Size = new System.Drawing.Size(1473, 28);
            this.Menuu.TabIndex = 6;
            this.Menuu.Text = "menuStrip1";
            // 
            // menuventas
            // 
            this.menuventas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuVenta,
            this.MenuVentasRealizadas});
            this.menuventas.ForeColor = System.Drawing.Color.Black;
            this.menuventas.Image = global::Serigrafia.Properties.Resources.carrito_de_compras;
            this.menuventas.Margin = new System.Windows.Forms.Padding(0, 0, 900, 0);
            this.menuventas.Name = "menuventas";
            this.menuventas.Size = new System.Drawing.Size(80, 26);
            this.menuventas.Text = "Venta";
            // 
            // MenuVenta
            // 
            this.MenuVenta.Name = "MenuVenta";
            this.MenuVenta.Size = new System.Drawing.Size(224, 26);
            this.MenuVenta.Text = "Registrar Ventas";
            // 
            // MenuVentasRealizadas
            // 
            this.MenuVentasRealizadas.Name = "MenuVentasRealizadas";
            this.MenuVentasRealizadas.Size = new System.Drawing.Size(224, 26);
            this.MenuVentasRealizadas.Text = "Ventas Realizadas";
            // 
            // BtnHome
            // 
            this.BtnHome.ForeColor = System.Drawing.Color.Black;
            this.BtnHome.Image = global::Serigrafia.Properties.Resources.stay_at_home;
            this.BtnHome.Margin = new System.Windows.Forms.Padding(0, 0, 5000, 0);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(84, 24);
            this.BtnHome.Text = "Home";
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click_1);
            // 
            // PnlForm
            // 
            this.PnlForm.BackColor = System.Drawing.Color.Goldenrod;
            this.PnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlForm.Location = new System.Drawing.Point(0, 92);
            this.PnlForm.Name = "PnlForm";
            this.PnlForm.Size = new System.Drawing.Size(1473, 683);
            this.PnlForm.TabIndex = 7;
            this.PnlForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // HomeEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 775);
            this.Controls.Add(this.PnlForm);
            this.Controls.Add(this.Menuu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuTitulo);
            this.Name = "HomeEmpleado";
            this.Text = "HomeEmpleado";
            this.Load += new System.EventHandler(this.HomeEmpleado_Load);
            this.MenuTitulo.ResumeLayout(false);
            this.MenuTitulo.PerformLayout();
            this.Menuu.ResumeLayout(false);
            this.Menuu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuTitulo;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip Menuu;
        private System.Windows.Forms.ToolStripMenuItem menuventas;
        private System.Windows.Forms.ToolStripMenuItem MenuVenta;
        private System.Windows.Forms.ToolStripMenuItem MenuVentasRealizadas;
        private System.Windows.Forms.ToolStripMenuItem BtnHome;
        private System.Windows.Forms.Panel PnlForm;
    }
}
namespace Serigrafia.Forms
{
    partial class Clientes
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
            this.Pnl_Datos = new System.Windows.Forms.Panel();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Txt_Direccion = new System.Windows.Forms.TextBox();
            this.Txt_Telefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Dgv_Data = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Pnl_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Datos
            // 
            this.Pnl_Datos.Controls.Add(this.Btn_Cancelar);
            this.Pnl_Datos.Controls.Add(this.Txt_Nombre);
            this.Pnl_Datos.Controls.Add(this.Btn_Guardar);
            this.Pnl_Datos.Controls.Add(this.label1);
            this.Pnl_Datos.Controls.Add(this.Btn_Eliminar);
            this.Pnl_Datos.Controls.Add(this.Btn_Modificar);
            this.Pnl_Datos.Controls.Add(this.label2);
            this.Pnl_Datos.Controls.Add(this.Btn_Agregar);
            this.Pnl_Datos.Controls.Add(this.Txt_Direccion);
            this.Pnl_Datos.Controls.Add(this.Txt_Telefono);
            this.Pnl_Datos.Controls.Add(this.label3);
            this.Pnl_Datos.Location = new System.Drawing.Point(50, 102);
            this.Pnl_Datos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pnl_Datos.Name = "Pnl_Datos";
            this.Pnl_Datos.Size = new System.Drawing.Size(272, 272);
            this.Pnl_Datos.TabIndex = 14;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(138, 164);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(102, 32);
            this.Btn_Cancelar.TabIndex = 13;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(9, 26);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(116, 20);
            this.Txt_Nombre.TabIndex = 0;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(74, 215);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(102, 32);
            this.Btn_Guardar.TabIndex = 12;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Location = new System.Drawing.Point(22, 164);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(102, 32);
            this.Btn_Eliminar.TabIndex = 11;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Location = new System.Drawing.Point(138, 110);
            this.Btn_Modificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(102, 32);
            this.Btn_Modificar.TabIndex = 10;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(104, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dirección";
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Location = new System.Drawing.Point(22, 110);
            this.Btn_Agregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(102, 32);
            this.Btn_Agregar.TabIndex = 9;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Txt_Direccion
            // 
            this.Txt_Direccion.Location = new System.Drawing.Point(74, 74);
            this.Txt_Direccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Direccion.Name = "Txt_Direccion";
            this.Txt_Direccion.Size = new System.Drawing.Size(116, 20);
            this.Txt_Direccion.TabIndex = 2;
            // 
            // Txt_Telefono
            // 
            this.Txt_Telefono.Location = new System.Drawing.Point(138, 26);
            this.Txt_Telefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Telefono.Name = "Txt_Telefono";
            this.Txt_Telefono.Size = new System.Drawing.Size(116, 20);
            this.Txt_Telefono.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(138, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefono";
            // 
            // Dgv_Data
            // 
            this.Dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Data.Location = new System.Drawing.Point(339, 102);
            this.Dgv_Data.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dgv_Data.Name = "Dgv_Data";
            this.Dgv_Data.RowHeadersWidth = 51;
            this.Dgv_Data.RowTemplate.Height = 24;
            this.Dgv_Data.Size = new System.Drawing.Size(694, 275);
            this.Dgv_Data.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(555, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 55);
            this.label5.TabIndex = 16;
            this.label5.Text = "Clientes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(132, 54);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 37);
            this.label6.TabIndex = 17;
            this.label6.Text = "Datos";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1082, 410);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Dgv_Data);
            this.Controls.Add(this.Pnl_Datos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.Pnl_Datos.ResumeLayout(false);
            this.Pnl_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Datos;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.TextBox Txt_Direccion;
        private System.Windows.Forms.TextBox Txt_Telefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Dgv_Data;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
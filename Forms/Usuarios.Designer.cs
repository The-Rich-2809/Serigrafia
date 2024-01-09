namespace Serigrafia.Forms
{
    partial class Usuarios
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.CmbRol = new System.Windows.Forms.ComboBox();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.Pnlinserstar = new System.Windows.Forms.Panel();
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.Pnlinserstar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(214, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(869, 81);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 28);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 30);
            this.label11.TabIndex = 26;
            this.label11.Text = "Lista Usuarios :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-64, 300);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 54;
            this.label9.Text = "Estado :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-64, 262);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 15);
            this.label8.TabIndex = 53;
            this.label8.Text = "Rol :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-64, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 50;
            this.label5.Text = "Correo :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-64, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 48;
            this.label3.Text = "Usuario :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 30);
            this.label1.TabIndex = 85;
            this.label1.Text = "Detalle Usuarios";
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(68, 343);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(64, 21);
            this.BtnModificar.TabIndex = 84;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(136, 344);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(64, 19);
            this.BtnEliminar.TabIndex = 83;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(0, 343);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(64, 19);
            this.BtnAgregar.TabIndex = 82;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // CmbRol
            // 
            this.CmbRol.FormattingEnabled = true;
            this.CmbRol.Items.AddRange(new object[] {
            "1",
            "2"});
            this.CmbRol.Location = new System.Drawing.Point(19, 253);
            this.CmbRol.Margin = new System.Windows.Forms.Padding(2);
            this.CmbRol.Name = "CmbRol";
            this.CmbRol.Size = new System.Drawing.Size(133, 21);
            this.CmbRol.TabIndex = 80;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Location = new System.Drawing.Point(19, 214);
            this.TxtContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(133, 20);
            this.TxtContraseña.TabIndex = 78;
            this.TxtContraseña.UseSystemPasswordChar = true;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(18, 170);
            this.TxtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(133, 20);
            this.TxtCorreo.TabIndex = 77;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(18, 126);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(133, 20);
            this.TxtNombre.TabIndex = 76;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(18, 81);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(133, 20);
            this.TxtUsuario.TabIndex = 75;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 236);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 73;
            this.label6.Text = "Rol :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(16, 197);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 15);
            this.label19.TabIndex = 71;
            this.label19.Text = "Contraseña :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(16, 152);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(50, 15);
            this.label20.TabIndex = 70;
            this.label20.Text = "Correo :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(16, 109);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(114, 15);
            this.label21.TabIndex = 69;
            this.label21.Text = "Nombre Completo :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(16, 64);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 15);
            this.label22.TabIndex = 68;
            this.label22.Text = "Usuario :";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(108, 379);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(64, 19);
            this.BtnCancelar.TabIndex = 87;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(30, 379);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(64, 19);
            this.BtnGuardar.TabIndex = 88;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // Pnlinserstar
            // 
            this.Pnlinserstar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Pnlinserstar.Controls.Add(this.label1);
            this.Pnlinserstar.Controls.Add(this.BtnGuardar);
            this.Pnlinserstar.Controls.Add(this.label22);
            this.Pnlinserstar.Controls.Add(this.BtnCancelar);
            this.Pnlinserstar.Controls.Add(this.label21);
            this.Pnlinserstar.Controls.Add(this.label20);
            this.Pnlinserstar.Controls.Add(this.BtnModificar);
            this.Pnlinserstar.Controls.Add(this.label19);
            this.Pnlinserstar.Controls.Add(this.BtnEliminar);
            this.Pnlinserstar.Controls.Add(this.BtnAgregar);
            this.Pnlinserstar.Controls.Add(this.label6);
            this.Pnlinserstar.Controls.Add(this.CmbRol);
            this.Pnlinserstar.Controls.Add(this.TxtUsuario);
            this.Pnlinserstar.Controls.Add(this.TxtNombre);
            this.Pnlinserstar.Controls.Add(this.TxtContraseña);
            this.Pnlinserstar.Controls.Add(this.TxtCorreo);
            this.Pnlinserstar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pnlinserstar.Location = new System.Drawing.Point(0, 0);
            this.Pnlinserstar.Name = "Pnlinserstar";
            this.Pnlinserstar.Size = new System.Drawing.Size(209, 558);
            this.Pnlinserstar.TabIndex = 89;
            // 
            // DgvUsuarios
            // 
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuarios.Location = new System.Drawing.Point(223, 96);
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.Size = new System.Drawing.Size(844, 426);
            this.DgvUsuarios.TabIndex = 90;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1095, 558);
            this.Controls.Add(this.DgvUsuarios);
            this.Controls.Add(this.Pnlinserstar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Pnlinserstar.ResumeLayout(false);
            this.Pnlinserstar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.ComboBox CmbRol;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Panel Pnlinserstar;
        private System.Windows.Forms.DataGridView DgvUsuarios;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
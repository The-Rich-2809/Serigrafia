namespace Serigrafia.Forms
{
    partial class Menus
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
            this.Fecha = new System.Windows.Forms.Label();
            this.Hora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Font = new System.Drawing.Font("SimSun", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.ForeColor = System.Drawing.Color.Black;
            this.Fecha.Location = new System.Drawing.Point(366, 243);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(111, 33);
            this.Fecha.TabIndex = 5;
            this.Fecha.Text = "Label2";
            // 
            // Hora
            // 
            this.Hora.AutoSize = true;
            this.Hora.Font = new System.Drawing.Font("SimSun", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora.ForeColor = System.Drawing.Color.Black;
            this.Hora.Location = new System.Drawing.Point(433, 276);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(111, 66);
            this.Hora.TabIndex = 4;
            this.Hora.Text = "\r\nLabel1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(73, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 99);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hola \r\nAdministrador \r\n¿Como va su tarde?\r\n";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Menus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(882, 527);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Hora);
            this.Controls.Add(this.label1);
            this.Name = "Menus";
            this.Text = "Menus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label Hora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}
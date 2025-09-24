namespace GroupBox
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaludoLbl = new System.Windows.Forms.Label();
            this.RojoRbtn = new System.Windows.Forms.RadioButton();
            this.AmarilloRbtn = new System.Windows.Forms.RadioButton();
            this.VerdeRbtn = new System.Windows.Forms.RadioButton();
            this.AplicarBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AplicarBtn);
            this.groupBox1.Controls.Add(this.VerdeRbtn);
            this.groupBox1.Controls.Add(this.AmarilloRbtn);
            this.groupBox1.Controls.Add(this.RojoRbtn);
            this.groupBox1.Location = new System.Drawing.Point(13, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // SaludoLbl
            // 
            this.SaludoLbl.AutoSize = true;
            this.SaludoLbl.BackColor = System.Drawing.Color.White;
            this.SaludoLbl.Location = new System.Drawing.Point(99, 9);
            this.SaludoLbl.Name = "SaludoLbl";
            this.SaludoLbl.Size = new System.Drawing.Size(68, 13);
            this.SaludoLbl.TabIndex = 1;
            this.SaludoLbl.Text = "Hola Mundo!";
            // 
            // RojoRbtn
            // 
            this.RojoRbtn.AutoSize = true;
            this.RojoRbtn.Location = new System.Drawing.Point(7, 11);
            this.RojoRbtn.Name = "RojoRbtn";
            this.RojoRbtn.Size = new System.Drawing.Size(47, 17);
            this.RojoRbtn.TabIndex = 0;
            this.RojoRbtn.TabStop = true;
            this.RojoRbtn.Tag = "Red";
            this.RojoRbtn.Text = "Rojo";
            this.RojoRbtn.UseVisualStyleBackColor = true;
            // 
            // AmarilloRbtn
            // 
            this.AmarilloRbtn.AutoSize = true;
            this.AmarilloRbtn.Location = new System.Drawing.Point(7, 35);
            this.AmarilloRbtn.Name = "AmarilloRbtn";
            this.AmarilloRbtn.Size = new System.Drawing.Size(61, 17);
            this.AmarilloRbtn.TabIndex = 1;
            this.AmarilloRbtn.TabStop = true;
            this.AmarilloRbtn.Tag = "Yellow";
            this.AmarilloRbtn.Text = "Amarillo";
            this.AmarilloRbtn.UseVisualStyleBackColor = true;
            // 
            // VerdeRbtn
            // 
            this.VerdeRbtn.AutoSize = true;
            this.VerdeRbtn.Location = new System.Drawing.Point(7, 59);
            this.VerdeRbtn.Name = "VerdeRbtn";
            this.VerdeRbtn.Size = new System.Drawing.Size(53, 17);
            this.VerdeRbtn.TabIndex = 2;
            this.VerdeRbtn.TabStop = true;
            this.VerdeRbtn.Tag = "Green";
            this.VerdeRbtn.Text = "Verde";
            this.VerdeRbtn.UseVisualStyleBackColor = true;
            // 
            // AplicarBtn
            // 
            this.AplicarBtn.Location = new System.Drawing.Point(121, 35);
            this.AplicarBtn.Name = "AplicarBtn";
            this.AplicarBtn.Size = new System.Drawing.Size(75, 23);
            this.AplicarBtn.TabIndex = 3;
            this.AplicarBtn.Text = "Aplicar";
            this.AplicarBtn.UseVisualStyleBackColor = true;
            this.AplicarBtn.Click += new System.EventHandler(this.AplicarBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.SaludoLbl);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label SaludoLbl;
        private System.Windows.Forms.Button AplicarBtn;
        private System.Windows.Forms.RadioButton VerdeRbtn;
        private System.Windows.Forms.RadioButton AmarilloRbtn;
        private System.Windows.Forms.RadioButton RojoRbtn;
    }
}


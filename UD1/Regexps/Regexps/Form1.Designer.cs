namespace Regexps
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
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Url";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(85, 9);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Validar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Validar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(85, 45);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(191, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Validar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(85, 85);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Matrícula";
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(81, 18);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox4.TabIndex = 10;
            this.maskedTextBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBox4_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hexadecimal";
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.Location = new System.Drawing.Point(81, 56);
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox5.TabIndex = 13;
            this.maskedTextBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBox5_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ctrl+V";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox4);
            this.groupBox1.Controls.Add(this.maskedTextBox5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(4, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 115);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Validación Automática";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


namespace ConversionTemperaturas
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CalcularBtn = new System.Windows.Forms.Button();
            this.CelsiusTbox = new System.Windows.Forms.TextBox();
            this.FarenheithTbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "≡";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Farenheith";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Celsius";
            // 
            // CalcularBtn
            // 
            this.CalcularBtn.Location = new System.Drawing.Point(106, 105);
            this.CalcularBtn.Name = "CalcularBtn";
            this.CalcularBtn.Size = new System.Drawing.Size(75, 23);
            this.CalcularBtn.TabIndex = 5;
            this.CalcularBtn.Text = "Calcular";
            this.CalcularBtn.UseVisualStyleBackColor = true;
            this.CalcularBtn.Click += new System.EventHandler(this.CalcularBtn_Click);
            // 
            // CelsiusTbox
            // 
            this.CelsiusTbox.Location = new System.Drawing.Point(30, 41);
            this.CelsiusTbox.Name = "CelsiusTbox";
            this.CelsiusTbox.Size = new System.Drawing.Size(100, 20);
            this.CelsiusTbox.TabIndex = 0;
            this.CelsiusTbox.Text = "0.00";
            this.CelsiusTbox.Click += new System.EventHandler(this.CelsiusNud_Enter);
            this.CelsiusTbox.Enter += new System.EventHandler(this.CelsiusNud_Enter);
            this.CelsiusTbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterPress);
            // 
            // FarenheithTbox
            // 
            this.FarenheithTbox.Location = new System.Drawing.Point(164, 40);
            this.FarenheithTbox.Name = "FarenheithTbox";
            this.FarenheithTbox.Size = new System.Drawing.Size(100, 20);
            this.FarenheithTbox.TabIndex = 1;
            this.FarenheithTbox.Text = "32.00";
            this.FarenheithTbox.Click += new System.EventHandler(this.FarenheithNud_Enter);
            this.FarenheithTbox.Enter += new System.EventHandler(this.FarenheithNud_Enter);
            this.FarenheithTbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 140);
            this.Controls.Add(this.FarenheithTbox);
            this.Controls.Add(this.CelsiusTbox);
            this.Controls.Add(this.CalcularBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CalcularBtn;
        private System.Windows.Forms.TextBox CelsiusTbox;
        private System.Windows.Forms.TextBox FarenheithTbox;
    }
}


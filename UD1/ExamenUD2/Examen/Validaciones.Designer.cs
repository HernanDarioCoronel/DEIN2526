namespace Examen
{
    partial class Validaciones
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
            this.tbFecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tNeumaticos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFecha
            // 
            this.tbFecha.Location = new System.Drawing.Point(83, 90);
            this.tbFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.Size = new System.Drawing.Size(176, 20);
            this.tbFecha.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "FECHA";
            // 
            // tNeumaticos
            // 
            this.tNeumaticos.Location = new System.Drawing.Point(86, 174);
            this.tNeumaticos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tNeumaticos.Name = "tNeumaticos";
            this.tNeumaticos.Size = new System.Drawing.Size(172, 20);
            this.tNeumaticos.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "NEUMATICOS";
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(212, 244);
            this.btnValidar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(182, 41);
            this.btnValidar.TabIndex = 4;
            this.btnValidar.Text = "VALIDAR";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // Validaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tNeumaticos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFecha);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Validaciones";
            this.Text = "Validaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tNeumaticos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnValidar;
    }
}
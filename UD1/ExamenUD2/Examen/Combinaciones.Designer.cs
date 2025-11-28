namespace Examen
{
    partial class Combinaciones
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
            this.tbOrigen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCaracter = new System.Windows.Forms.TextBox();
            this.tbModificador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btFin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbOrigen
            // 
            this.tbOrigen.Location = new System.Drawing.Point(52, 66);
            this.tbOrigen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbOrigen.Name = "tbOrigen";
            this.tbOrigen.Size = new System.Drawing.Size(205, 20);
            this.tbOrigen.TabIndex = 0;
            this.tbOrigen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbOrigen_KeyDown);
            this.tbOrigen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbOrigen_KeyUp);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "ESCRIBA SU TEXTO AQUI";
            // 
            // tbCaracter
            // 
            this.tbCaracter.Location = new System.Drawing.Point(309, 68);
            this.tbCaracter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCaracter.Name = "tbCaracter";
            this.tbCaracter.Size = new System.Drawing.Size(102, 20);
            this.tbCaracter.TabIndex = 2;
            // 
            // tbModificador
            // 
            this.tbModificador.Location = new System.Drawing.Point(436, 68);
            this.tbModificador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbModificador.Name = "tbModificador";
            this.tbModificador.Size = new System.Drawing.Size(106, 20);
            this.tbModificador.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Carácter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(439, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Modificador";
            // 
            // btFin
            // 
            this.btFin.Location = new System.Drawing.Point(238, 108);
            this.btFin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btFin.Name = "btFin";
            this.btFin.Size = new System.Drawing.Size(125, 56);
            this.btFin.TabIndex = 6;
            this.btFin.Text = "SALIR";
            this.btFin.UseVisualStyleBackColor = true;
            // 
            // Combinaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 188);
            this.Controls.Add(this.btFin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbModificador);
            this.Controls.Add(this.tbCaracter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOrigen);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Combinaciones";
            this.Text = "Combinaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOrigen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCaracter;
        private System.Windows.Forms.TextBox tbModificador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btFin;
    }
}
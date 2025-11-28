namespace Examen
{
    partial class TraspasoDatos
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
            this.tbDestino = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTraspaso = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbOrigen
            // 
            this.tbOrigen.Location = new System.Drawing.Point(46, 82);
            this.tbOrigen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbOrigen.Name = "tbOrigen";
            this.tbOrigen.Size = new System.Drawing.Size(156, 20);
            this.tbOrigen.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Origen";
            // 
            // tbDestino
            // 
            this.tbDestino.Location = new System.Drawing.Point(260, 81);
            this.tbDestino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDestino.Name = "tbDestino";
            this.tbDestino.Size = new System.Drawing.Size(149, 20);
            this.tbDestino.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destino";
            // 
            // btnTraspaso
            // 
            this.btnTraspaso.Location = new System.Drawing.Point(94, 128);
            this.btnTraspaso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTraspaso.Name = "btnTraspaso";
            this.btnTraspaso.Size = new System.Drawing.Size(142, 45);
            this.btnTraspaso.TabIndex = 4;
            this.btnTraspaso.Text = "TRASPASO";
            this.btnTraspaso.UseVisualStyleBackColor = true;
            this.btnTraspaso.Click += new System.EventHandler(this.btnTraspaso_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(280, 130);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(128, 41);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // TraspasoDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 239);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnTraspaso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDestino);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOrigen);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TraspasoDatos";
            this.Text = "TraspasoDatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTraspaso;
        private System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.TextBox tbOrigen;
        internal System.Windows.Forms.TextBox tbDestino;
    }
}
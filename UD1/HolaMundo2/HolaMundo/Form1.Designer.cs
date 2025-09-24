namespace HolaMundo
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
            this.SaludoLbl = new System.Windows.Forms.Label();
            this.RedBtn = new System.Windows.Forms.Button();
            this.YellowBtn = new System.Windows.Forms.Button();
            this.GreenBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaludoLbl
            // 
            this.SaludoLbl.AutoSize = true;
            this.SaludoLbl.Location = new System.Drawing.Point(117, 9);
            this.SaludoLbl.Name = "SaludoLbl";
            this.SaludoLbl.Size = new System.Drawing.Size(68, 13);
            this.SaludoLbl.TabIndex = 0;
            this.SaludoLbl.Text = "Hola Mundo!";
            // 
            // RedBtn
            // 
            this.RedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.RedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RedBtn.Location = new System.Drawing.Point(12, 91);
            this.RedBtn.Name = "RedBtn";
            this.RedBtn.Size = new System.Drawing.Size(75, 23);
            this.RedBtn.TabIndex = 1;
            this.RedBtn.Text = "Rojo";
            this.RedBtn.UseVisualStyleBackColor = false;
            this.RedBtn.Click += new System.EventHandler(this.RedBtn_Click);
            // 
            // YellowBtn
            // 
            this.YellowBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.YellowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.YellowBtn.Location = new System.Drawing.Point(93, 91);
            this.YellowBtn.Name = "YellowBtn";
            this.YellowBtn.Size = new System.Drawing.Size(75, 23);
            this.YellowBtn.TabIndex = 2;
            this.YellowBtn.Text = "Amarillo";
            this.YellowBtn.UseVisualStyleBackColor = false;
            this.YellowBtn.Click += new System.EventHandler(this.YellowBtn_Click);
            // 
            // GreenBtn
            // 
            this.GreenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.GreenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GreenBtn.Location = new System.Drawing.Point(174, 91);
            this.GreenBtn.Name = "GreenBtn";
            this.GreenBtn.Size = new System.Drawing.Size(75, 23);
            this.GreenBtn.TabIndex = 3;
            this.GreenBtn.Text = "Verde";
            this.GreenBtn.UseVisualStyleBackColor = false;
            this.GreenBtn.Click += new System.EventHandler(this.GreenBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 126);
            this.Controls.Add(this.GreenBtn);
            this.Controls.Add(this.YellowBtn);
            this.Controls.Add(this.RedBtn);
            this.Controls.Add(this.SaludoLbl);
            this.Name = "Form1";
            this.Text = "Hola Mundo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SaludoLbl;
        private System.Windows.Forms.Button RedBtn;
        private System.Windows.Forms.Button YellowBtn;
        private System.Windows.Forms.Button GreenBtn;
    }
}


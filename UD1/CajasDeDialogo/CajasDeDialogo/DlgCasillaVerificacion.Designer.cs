namespace CajasDeDialogo
{
    partial class DlgCasillaVerificacion
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
            this.ctTexto = new System.Windows.Forms.TextBox();
            this.cbConverMayus = new System.Windows.Forms.CheckBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctTexto
            // 
            this.ctTexto.Location = new System.Drawing.Point(64, 52);
            this.ctTexto.Name = "ctTexto";
            this.ctTexto.Size = new System.Drawing.Size(151, 20);
            this.ctTexto.TabIndex = 0;
            this.ctTexto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ctTexto_KeyUp);
            // 
            // cbConverMayus
            // 
            this.cbConverMayus.AutoSize = true;
            this.cbConverMayus.Location = new System.Drawing.Point(64, 79);
            this.cbConverMayus.Name = "cbConverMayus";
            this.cbConverMayus.Size = new System.Drawing.Size(135, 17);
            this.cbConverMayus.TabIndex = 1;
            this.cbConverMayus.Text = "Convertir a mayúsculas";
            this.cbConverMayus.UseVisualStyleBackColor = true;
            this.cbConverMayus.CheckedChanged += new System.EventHandler(this.cbConverMayus_CheckedChanged);
            // 
            // btAceptar
            // 
            this.btAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAceptar.Location = new System.Drawing.Point(197, 136);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 2;
            this.btAceptar.Text = "&Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            // 
            // DlgCasillaVerificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 171);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.cbConverMayus);
            this.Controls.Add(this.ctTexto);
            this.Name = "DlgCasillaVerificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Casilla de verificacion";
            this.Load += new System.EventHandler(this.DlgCasillaVerificacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ctTexto;
        private System.Windows.Forms.CheckBox cbConverMayus;
        private System.Windows.Forms.Button btAceptar;
    }
}
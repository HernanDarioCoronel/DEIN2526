namespace CajasDeDialogo
{
    partial class DlgLogin
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
            this.ctPalabraDePaso = new System.Windows.Forms.TextBox();
            this.etPalabraDepaso = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctPalabraDePaso
            // 
            this.ctPalabraDePaso.Location = new System.Drawing.Point(72, 61);
            this.ctPalabraDePaso.Name = "ctPalabraDePaso";
            this.ctPalabraDePaso.PasswordChar = '*';
            this.ctPalabraDePaso.Size = new System.Drawing.Size(100, 20);
            this.ctPalabraDePaso.TabIndex = 1;
            // 
            // etPalabraDepaso
            // 
            this.etPalabraDepaso.AutoSize = true;
            this.etPalabraDepaso.Location = new System.Drawing.Point(79, 33);
            this.etPalabraDepaso.Name = "etPalabraDepaso";
            this.etPalabraDepaso.Size = new System.Drawing.Size(84, 13);
            this.etPalabraDepaso.TabIndex = 3;
            this.etPalabraDepaso.Text = "Palabra de paso";
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(38, 109);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 4;
            this.btAceptar.Text = "&Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(128, 109);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 6;
            this.btCancelar.Text = "&Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Password: 1234";
            // 
            // DlgLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 163);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.etPalabraDepaso);
            this.Controls.Add(this.ctPalabraDePaso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DlgLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Palabra de paso";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label etPalabraDepaso;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        internal System.Windows.Forms.TextBox ctPalabraDePaso;
        private System.Windows.Forms.Label label1;
    }
}


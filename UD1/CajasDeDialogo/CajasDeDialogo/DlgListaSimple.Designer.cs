namespace CajasDeDialogo
{
    partial class DlgListaSimple
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
            this.lbCoches = new System.Windows.Forms.ListBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.ctAñadir = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCoches
            // 
            this.lbCoches.FormattingEnabled = true;
            this.lbCoches.Items.AddRange(new object[] {
            "BMW",
            "Chevrolet",
            "Fiat",
            "Hyundai",
            "Honda",
            "Opel",
            "Renaul",
            "Aston Martin",
            "Tesla",
            "Ford"});
            this.lbCoches.Location = new System.Drawing.Point(12, 12);
            this.lbCoches.Name = "lbCoches";
            this.lbCoches.Size = new System.Drawing.Size(159, 199);
            this.lbCoches.TabIndex = 0;
            // 
            // btAceptar
            // 
            this.btAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAceptar.Location = new System.Drawing.Point(178, 13);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 1;
            this.btAceptar.Text = "&Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            // 
            // ctAñadir
            // 
            this.ctAñadir.Location = new System.Drawing.Point(177, 66);
            this.ctAñadir.Name = "ctAñadir";
            this.ctAñadir.Size = new System.Drawing.Size(75, 23);
            this.ctAñadir.TabIndex = 2;
            this.ctAñadir.Text = "&Añadir";
            this.ctAñadir.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(177, 96);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "&Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(178, 151);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(75, 23);
            this.btBorrar.TabIndex = 4;
            this.btBorrar.Text = "&Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            // 
            // DlgListaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 221);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.ctAñadir);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.lbCoches);
            this.Name = "DlgListaSimple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DlgListaSimple";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbCoches;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button ctAñadir;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btBorrar;
    }
}
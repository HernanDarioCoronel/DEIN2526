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
            this.lsLista1l = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbCoches
            // 
            this.lbCoches.FormattingEnabled = true;
            this.lbCoches.Location = new System.Drawing.Point(12, 12);
            this.lbCoches.Name = "lbCoches";
            this.lbCoches.Size = new System.Drawing.Size(159, 199);
            this.lbCoches.TabIndex = 0;
            this.lbCoches.SelectedValueChanged += new System.EventHandler(this.lbCoches_SelectedValueChanged);
            // 
            // btAceptar
            // 
            this.btAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAceptar.Enabled = false;
            this.btAceptar.Location = new System.Drawing.Point(178, 157);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 1;
            this.btAceptar.Text = "&Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // ctAñadir
            // 
            this.ctAñadir.Enabled = false;
            this.ctAñadir.Location = new System.Drawing.Point(178, 13);
            this.ctAñadir.Name = "ctAñadir";
            this.ctAñadir.Size = new System.Drawing.Size(75, 23);
            this.ctAñadir.TabIndex = 2;
            this.ctAñadir.Text = "&Añadir";
            this.ctAñadir.UseVisualStyleBackColor = true;
            this.ctAñadir.Click += new System.EventHandler(this.ctAñadir_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(178, 186);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "&Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.Enabled = false;
            this.btBorrar.Location = new System.Drawing.Point(177, 69);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(75, 23);
            this.btBorrar.TabIndex = 4;
            this.btBorrar.Text = "&Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // lsLista1l
            // 
            this.lsLista1l.FormattingEnabled = true;
            this.lsLista1l.Items.AddRange(new object[] {
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
            this.lsLista1l.Location = new System.Drawing.Point(178, 42);
            this.lsLista1l.Name = "lsLista1l";
            this.lsLista1l.Size = new System.Drawing.Size(75, 21);
            this.lsLista1l.TabIndex = 5;
            this.lsLista1l.SelectedValueChanged += new System.EventHandler(this.lsLista1l_SelectedValueChanged);
            // 
            // DlgListaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 221);
            this.Controls.Add(this.lsLista1l);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.ctAñadir);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.lbCoches);
            this.Name = "DlgListaSimple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coches";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button ctAñadir;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.ComboBox lsLista1l;
        internal System.Windows.Forms.ListBox lbCoches;
    }
}
namespace HideForm
{
    partial class FormList
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.denominacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAgregar = new System.Windows.Forms.Button();
            this.ctCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.denominacion,
            this.bodega,
            this.precio});
            this.dataGridView.Location = new System.Drawing.Point(-1, -2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(351, 222);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDoubleClick);
            // 
            // denominacion
            // 
            this.denominacion.HeaderText = "Denominación";
            this.denominacion.Name = "denominacion";
            // 
            // bodega
            // 
            this.bodega.HeaderText = "Bodega";
            this.bodega.Name = "bodega";
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(12, 226);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 23);
            this.btAgregar.TabIndex = 1;
            this.btAgregar.Text = "&Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // ctCerrar
            // 
            this.ctCerrar.Enabled = false;
            this.ctCerrar.Location = new System.Drawing.Point(94, 225);
            this.ctCerrar.Name = "ctCerrar";
            this.ctCerrar.Size = new System.Drawing.Size(89, 23);
            this.ctCerrar.TabIndex = 2;
            this.ctCerrar.Text = "&Cerrar Producto";
            this.ctCerrar.UseVisualStyleBackColor = true;
            this.ctCerrar.Click += new System.EventHandler(this.ctCerrar_Click);
            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 261);
            this.Controls.Add(this.ctCerrar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormList";
            this.Text = "FormList";
            this.Load += new System.EventHandler(this.FormList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn denominacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button ctCerrar;
        internal System.Windows.Forms.DataGridView dataGridView;
    }
}
namespace CajasDeDialogo
{
    partial class MainForm
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
            this.ctPrincipal = new System.Windows.Forms.TextBox();
            this.menuAyuda = new System.Windows.Forms.MenuStrip();
            this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDialogos = new System.Windows.Forms.ToolStripMenuItem();
            this.listaSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casillaDeVerificaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAyuda.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctPrincipal
            // 
            this.ctPrincipal.Location = new System.Drawing.Point(77, 106);
            this.ctPrincipal.Name = "ctPrincipal";
            this.ctPrincipal.Size = new System.Drawing.Size(125, 20);
            this.ctPrincipal.TabIndex = 1;
            // 
            // menuAyuda
            // 
            this.menuAyuda.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo,
            this.menuDialogos,
            this.ayudaToolStripMenuItem});
            this.menuAyuda.Location = new System.Drawing.Point(0, 0);
            this.menuAyuda.Name = "menuAyuda";
            this.menuAyuda.Size = new System.Drawing.Size(284, 24);
            this.menuAyuda.TabIndex = 2;
            this.menuAyuda.Text = "menuStrip1";
            // 
            // menuArchivo
            // 
            this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoSalir});
            this.menuArchivo.Name = "menuArchivo";
            this.menuArchivo.Size = new System.Drawing.Size(60, 20);
            this.menuArchivo.Text = "&Archivo";
            // 
            // archivoSalir
            // 
            this.archivoSalir.Name = "archivoSalir";
            this.archivoSalir.Size = new System.Drawing.Size(96, 22);
            this.archivoSalir.Text = "&Salir";
            // 
            // menuDialogos
            // 
            this.menuDialogos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaSimpleToolStripMenuItem,
            this.casillaDeVerificaciónToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuDialogos.Name = "menuDialogos";
            this.menuDialogos.Size = new System.Drawing.Size(65, 20);
            this.menuDialogos.Text = "&Diálogos";
            // 
            // listaSimpleToolStripMenuItem
            // 
            this.listaSimpleToolStripMenuItem.Name = "listaSimpleToolStripMenuItem";
            this.listaSimpleToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.listaSimpleToolStripMenuItem.Text = "&Lista Simple";
            this.listaSimpleToolStripMenuItem.Click += new System.EventHandler(this.listaSimpleToolStripMenuItem_Click);
            // 
            // casillaDeVerificaciónToolStripMenuItem
            // 
            this.casillaDeVerificaciónToolStripMenuItem.Name = "casillaDeVerificaciónToolStripMenuItem";
            this.casillaDeVerificaciónToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.casillaDeVerificaciónToolStripMenuItem.Text = "&Casilla de verificación";
            this.casillaDeVerificaciónToolStripMenuItem.Click += new System.EventHandler(this.casillaDeVerificaciónToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItem1.Text = "Fotografía";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaAcercaDe});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "&Ayuda";
            // 
            // ayudaAcercaDe
            // 
            this.ayudaAcercaDe.Name = "ayudaAcercaDe";
            this.ayudaAcercaDe.Size = new System.Drawing.Size(126, 22);
            this.ayudaAcercaDe.Text = "&Acerca de";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ctPrincipal);
            this.Controls.Add(this.menuAyuda);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuAyuda.ResumeLayout(false);
            this.menuAyuda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ctPrincipal;
        private System.Windows.Forms.MenuStrip menuAyuda;
        private System.Windows.Forms.ToolStripMenuItem menuArchivo;
        private System.Windows.Forms.ToolStripMenuItem archivoSalir;
        private System.Windows.Forms.ToolStripMenuItem menuDialogos;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem listaSimpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem casillaDeVerificaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}
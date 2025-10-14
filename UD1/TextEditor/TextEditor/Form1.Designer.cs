namespace TextEditor
{
    partial class formEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEditor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdicion = new System.Windows.Forms.ToolStripMenuItem();
            this.edicionDeshacer = new System.Windows.Forms.ToolStripMenuItem();
            this.edicionCortar = new System.Windows.Forms.ToolStripMenuItem();
            this.edicionCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.edicionPegar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpciones = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesFuente = new System.Windows.Forms.ToolStripMenuItem();
            this.opFuCourierNew = new System.Windows.Forms.ToolStripMenuItem();
            this.opFuArial = new System.Windows.Forms.ToolStripMenuItem();
            this.opFuPredeterminada = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesTam = new System.Windows.Forms.ToolStripMenuItem();
            this.opTam16 = new System.Windows.Forms.ToolStripMenuItem();
            this.opTam24 = new System.Windows.Forms.ToolStripMenuItem();
            this.OpTam2Predeterminado = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btbatCortar = new System.Windows.Forms.ToolStripButton();
            this.btbarCopiar = new System.Windows.Forms.ToolStripButton();
            this.btbarPegar = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ctEditor = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo,
            this.menuEdicion,
            this.menuOpciones});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuArchivo
            // 
            this.menuArchivo.AccessibleDescription = "Menú Archivo";
            this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoSalir});
            this.menuArchivo.Name = "menuArchivo";
            this.menuArchivo.Size = new System.Drawing.Size(60, 20);
            this.menuArchivo.Text = "&Archivo";
            // 
            // archivoSalir
            // 
            this.archivoSalir.AccessibleDescription = "Salir de la alicación";
            this.archivoSalir.Name = "archivoSalir";
            this.archivoSalir.Size = new System.Drawing.Size(96, 22);
            this.archivoSalir.Text = "&Salir";
            this.archivoSalir.Click += new System.EventHandler(this.archivoSalir_Click);
            // 
            // menuEdicion
            // 
            this.menuEdicion.AccessibleDescription = "Menú Edición";
            this.menuEdicion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edicionDeshacer,
            this.edicionCortar,
            this.edicionCopiar,
            this.edicionPegar});
            this.menuEdicion.Name = "menuEdicion";
            this.menuEdicion.Size = new System.Drawing.Size(58, 20);
            this.menuEdicion.Text = "&Edición";
            this.menuEdicion.DropDownOpening += new System.EventHandler(this.menuEdicion_DropDownOpening);
            // 
            // edicionDeshacer
            // 
            this.edicionDeshacer.AccessibleDescription = "Deshacer últimos cambios";
            this.edicionDeshacer.Name = "edicionDeshacer";
            this.edicionDeshacer.ShortcutKeyDisplayString = "Ctrl + Z";
            this.edicionDeshacer.Size = new System.Drawing.Size(169, 22);
            this.edicionDeshacer.Text = "&Deshacer";
            this.edicionDeshacer.Click += new System.EventHandler(this.edicionDeshacer_Click);
            // 
            // edicionCortar
            // 
            this.edicionCortar.AccessibleDescription = "Cortar texto";
            this.edicionCortar.Name = "edicionCortar";
            this.edicionCortar.ShortcutKeyDisplayString = "Ctrl + X";
            this.edicionCortar.Size = new System.Drawing.Size(169, 22);
            this.edicionCortar.Text = "&Cortar";
            this.edicionCortar.Click += new System.EventHandler(this.edicionCortar_Click);
            // 
            // edicionCopiar
            // 
            this.edicionCopiar.AccessibleDescription = "Copiar texto";
            this.edicionCopiar.Name = "edicionCopiar";
            this.edicionCopiar.ShortcutKeyDisplayString = "Ctrl + C";
            this.edicionCopiar.Size = new System.Drawing.Size(169, 22);
            this.edicionCopiar.Text = "&Copiar";
            this.edicionCopiar.Click += new System.EventHandler(this.edicionCopiar_Click);
            // 
            // edicionPegar
            // 
            this.edicionPegar.AccessibleDescription = "Pegar desde el portapapeles";
            this.edicionPegar.Enabled = false;
            this.edicionPegar.Name = "edicionPegar";
            this.edicionPegar.ShortcutKeyDisplayString = "Ctrl + V";
            this.edicionPegar.Size = new System.Drawing.Size(169, 22);
            this.edicionPegar.Text = "&Pegar";
            this.edicionPegar.Click += new System.EventHandler(this.edicionPegar_Click);
            // 
            // menuOpciones
            // 
            this.menuOpciones.AccessibleDescription = "Menú Opciones";
            this.menuOpciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesFuente,
            this.opcionesTam});
            this.menuOpciones.Name = "menuOpciones";
            this.menuOpciones.Size = new System.Drawing.Size(69, 20);
            this.menuOpciones.Text = "&Opciones";
            // 
            // opcionesFuente
            // 
            this.opcionesFuente.AccessibleDescription = "Submenú Fuente";
            this.opcionesFuente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opFuCourierNew,
            this.opFuArial,
            this.opFuPredeterminada});
            this.opcionesFuente.Name = "opcionesFuente";
            this.opcionesFuente.Size = new System.Drawing.Size(116, 22);
            this.opcionesFuente.Text = "&Fuente";
            // 
            // opFuCourierNew
            // 
            this.opFuCourierNew.AccessibleDescription = "Cambia la fuente a Corier New";
            this.opFuCourierNew.CheckOnClick = true;
            this.opFuCourierNew.Name = "opFuCourierNew";
            this.opFuCourierNew.Size = new System.Drawing.Size(158, 22);
            this.opFuCourierNew.Text = "Courier New";
            this.opFuCourierNew.Click += new System.EventHandler(this.opFuCourierNew_Click);
            // 
            // opFuArial
            // 
            this.opFuArial.AccessibleDescription = "Cambia la fuente a Arial";
            this.opFuArial.CheckOnClick = true;
            this.opFuArial.Name = "opFuArial";
            this.opFuArial.Size = new System.Drawing.Size(158, 22);
            this.opFuArial.Text = "Arial";
            this.opFuArial.Click += new System.EventHandler(this.opFuArial_Click);
            // 
            // opFuPredeterminada
            // 
            this.opFuPredeterminada.AccessibleDescription = "Cambia la fuente a la Predeterminada";
            this.opFuPredeterminada.Checked = true;
            this.opFuPredeterminada.CheckOnClick = true;
            this.opFuPredeterminada.CheckState = System.Windows.Forms.CheckState.Checked;
            this.opFuPredeterminada.Name = "opFuPredeterminada";
            this.opFuPredeterminada.Size = new System.Drawing.Size(158, 22);
            this.opFuPredeterminada.Text = "Predeterminada";
            this.opFuPredeterminada.Click += new System.EventHandler(this.opFuPredeterminada_Click);
            // 
            // opcionesTam
            // 
            this.opcionesTam.AccessibleDescription = "Submenú Tamaño";
            this.opcionesTam.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opTam16,
            this.opTam24,
            this.OpTam2Predeterminado});
            this.opcionesTam.Name = "opcionesTam";
            this.opcionesTam.Size = new System.Drawing.Size(116, 22);
            this.opcionesTam.Text = "&Tamaño";
            // 
            // opTam16
            // 
            this.opTam16.AccessibleDescription = "Cambia el tamaño de fuente a 16em";
            this.opTam16.Name = "opTam16";
            this.opTam16.Size = new System.Drawing.Size(159, 22);
            this.opTam16.Text = "16";
            this.opTam16.Click += new System.EventHandler(this.opTam16_Click);
            // 
            // opTam24
            // 
            this.opTam24.AccessibleDescription = "Cambia el tamaño de fuente a 24em";
            this.opTam24.Name = "opTam24";
            this.opTam24.Size = new System.Drawing.Size(159, 22);
            this.opTam24.Text = "24";
            this.opTam24.Click += new System.EventHandler(this.opTam24_Click);
            // 
            // OpTam2Predeterminado
            // 
            this.OpTam2Predeterminado.AccessibleDescription = "Cambia el tamaño de fuente a la predeterminada";
            this.OpTam2Predeterminado.Checked = true;
            this.OpTam2Predeterminado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OpTam2Predeterminado.Name = "OpTam2Predeterminado";
            this.OpTam2Predeterminado.Size = new System.Drawing.Size(159, 22);
            this.OpTam2Predeterminado.Text = "Predeterminado";
            this.OpTam2Predeterminado.Click += new System.EventHandler(this.OpTam2Predeterminado_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btbatCortar,
            this.btbarCopiar,
            this.btbarPegar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(634, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btbatCortar
            // 
            this.btbatCortar.AccessibleDescription = "Copiar al portapapeles";
            this.btbatCortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btbatCortar.Image = ((System.Drawing.Image)(resources.GetObject("btbatCortar.Image")));
            this.btbatCortar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btbatCortar.Name = "btbatCortar";
            this.btbatCortar.Size = new System.Drawing.Size(23, 22);
            this.btbatCortar.Text = "toolStripButton1";
            this.btbatCortar.ToolTipText = "Cortar";
            // 
            // btbarCopiar
            // 
            this.btbarCopiar.AccessibleDescription = "Pegar desde el portapapeles";
            this.btbarCopiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btbarCopiar.Image = ((System.Drawing.Image)(resources.GetObject("btbarCopiar.Image")));
            this.btbarCopiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btbarCopiar.Name = "btbarCopiar";
            this.btbarCopiar.Size = new System.Drawing.Size(23, 22);
            this.btbarCopiar.Text = "toolStripButton2";
            this.btbarCopiar.ToolTipText = "Copiar";
            // 
            // btbarPegar
            // 
            this.btbarPegar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btbarPegar.Enabled = false;
            this.btbarPegar.Image = ((System.Drawing.Image)(resources.GetObject("btbarPegar.Image")));
            this.btbarPegar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btbarPegar.Name = "btbarPegar";
            this.btbarPegar.Size = new System.Drawing.Size(23, 22);
            this.btbarPegar.Text = "toolStripButton3";
            this.btbarPegar.ToolTipText = "Pegar";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 309);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(634, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AccessibleDescription = "Barra de estado";
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // ctEditor
            // 
            this.ctEditor.AcceptsReturn = true;
            this.ctEditor.AcceptsTab = true;
            this.ctEditor.AccessibleDescription = "Editor de texto";
            this.ctEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctEditor.Location = new System.Drawing.Point(0, 49);
            this.ctEditor.Multiline = true;
            this.ctEditor.Name = "ctEditor";
            this.ctEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ctEditor.Size = new System.Drawing.Size(634, 260);
            this.ctEditor.TabIndex = 5;
            // 
            // formEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 331);
            this.Controls.Add(this.ctEditor);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formEditor";
            this.Text = "Editor";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formEditor_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox ctEditor;
        private System.Windows.Forms.ToolStripMenuItem menuArchivo;
        private System.Windows.Forms.ToolStripMenuItem archivoSalir;
        private System.Windows.Forms.ToolStripMenuItem menuEdicion;
        private System.Windows.Forms.ToolStripMenuItem edicionDeshacer;
        private System.Windows.Forms.ToolStripMenuItem edicionCortar;
        private System.Windows.Forms.ToolStripMenuItem edicionCopiar;
        private System.Windows.Forms.ToolStripMenuItem edicionPegar;
        private System.Windows.Forms.ToolStripMenuItem menuOpciones;
        private System.Windows.Forms.ToolStripMenuItem opcionesFuente;
        private System.Windows.Forms.ToolStripMenuItem opcionesTam;
        private System.Windows.Forms.ToolStripMenuItem opFuCourierNew;
        private System.Windows.Forms.ToolStripMenuItem opFuArial;
        private System.Windows.Forms.ToolStripMenuItem opFuPredeterminada;
        private System.Windows.Forms.ToolStripMenuItem opTam16;
        private System.Windows.Forms.ToolStripMenuItem opTam24;
        private System.Windows.Forms.ToolStripMenuItem OpTam2Predeterminado;
        private System.Windows.Forms.ToolStripButton btbatCortar;
        private System.Windows.Forms.ToolStripButton btbarCopiar;
        private System.Windows.Forms.ToolStripButton btbarPegar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}


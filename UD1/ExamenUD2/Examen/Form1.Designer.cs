namespace Examen
{
    partial class fPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.btnDatos = new System.Windows.Forms.Button();
            this.btnExpReg = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.tbOrigen = new System.Windows.Forms.TextBox();
            this.Origen = new System.Windows.Forms.Label();
            this.tbDestino = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTraspaso = new System.Windows.Forms.Button();
            this.btnCargaFichero = new System.Windows.Forms.Button();
            this.tbRuta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.basesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(761, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "EXAMEN DEIN 14-NOVIEMBRE-2025";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDatos
            // 
            this.btnDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatos.Location = new System.Drawing.Point(43, 97);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(156, 70);
            this.btnDatos.TabIndex = 1;
            this.btnDatos.Text = "DATOS ENTRE FORMULARIOS";
            this.btnDatos.UseVisualStyleBackColor = true;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // btnExpReg
            // 
            this.btnExpReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpReg.Location = new System.Drawing.Point(435, 97);
            this.btnExpReg.Name = "btnExpReg";
            this.btnExpReg.Size = new System.Drawing.Size(202, 70);
            this.btnExpReg.TabIndex = 3;
            this.btnExpReg.Text = "VALIDACIONES CON EXPRESIONES REGULARES";
            this.btnExpReg.UseVisualStyleBackColor = true;
            this.btnExpReg.Click += new System.EventHandler(this.btnExpReg_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(686, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 70);
            this.button2.TabIndex = 4;
            this.button2.Text = "COMBINACIONES DE TECLAS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(205, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "CONTRASEÑA";
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // tbContraseña
            // 
            this.tbContraseña.Location = new System.Drawing.Point(205, 149);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(224, 20);
            this.tbContraseña.TabIndex = 6;
            // 
            // btnValidar
            // 
            this.btnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.Location = new System.Drawing.Point(205, 80);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(221, 45);
            this.btnValidar.TabIndex = 7;
            this.btnValidar.Text = "VALIDAR CONTRASEÑA";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // tbOrigen
            // 
            this.tbOrigen.Location = new System.Drawing.Point(50, 207);
            this.tbOrigen.Margin = new System.Windows.Forms.Padding(2);
            this.tbOrigen.Name = "tbOrigen";
            this.tbOrigen.Size = new System.Drawing.Size(150, 20);
            this.tbOrigen.TabIndex = 8;
            // 
            // Origen
            // 
            this.Origen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Origen.Location = new System.Drawing.Point(46, 181);
            this.Origen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Origen.Name = "Origen";
            this.Origen.Size = new System.Drawing.Size(98, 24);
            this.Origen.TabIndex = 9;
            this.Origen.Text = "Origen";
            // 
            // tbDestino
            // 
            this.tbDestino.Location = new System.Drawing.Point(52, 265);
            this.tbDestino.Margin = new System.Windows.Forms.Padding(2);
            this.tbDestino.Name = "tbDestino";
            this.tbDestino.Size = new System.Drawing.Size(146, 20);
            this.tbDestino.TabIndex = 10;
            this.tbDestino.TextChanged += new System.EventHandler(this.tbDestino_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Destino";
            // 
            // btnTraspaso
            // 
            this.btnTraspaso.Location = new System.Drawing.Point(52, 291);
            this.btnTraspaso.Margin = new System.Windows.Forms.Padding(2);
            this.btnTraspaso.Name = "btnTraspaso";
            this.btnTraspaso.Size = new System.Drawing.Size(139, 44);
            this.btnTraspaso.TabIndex = 12;
            this.btnTraspaso.Text = "TRASPASO";
            this.btnTraspaso.UseVisualStyleBackColor = true;
            // 
            // btnCargaFichero
            // 
            this.btnCargaFichero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargaFichero.Location = new System.Drawing.Point(260, 210);
            this.btnCargaFichero.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargaFichero.Name = "btnCargaFichero";
            this.btnCargaFichero.Size = new System.Drawing.Size(175, 52);
            this.btnCargaFichero.TabIndex = 13;
            this.btnCargaFichero.Text = "CargarFichero";
            this.btnCargaFichero.UseVisualStyleBackColor = true;
            this.btnCargaFichero.Click += new System.EventHandler(this.btnCargaFichero_Click);
            // 
            // tbRuta
            // 
            this.tbRuta.Location = new System.Drawing.Point(260, 291);
            this.tbRuta.Margin = new System.Windows.Forms.Padding(2);
            this.tbRuta.Name = "tbRuta";
            this.tbRuta.Size = new System.Drawing.Size(186, 20);
            this.tbRuta.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(258, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "RUTA";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 346);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(990, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "Listo";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(990, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // basesToolStripMenuItem
            // 
            this.basesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarToolStripMenuItem});
            this.basesToolStripMenuItem.Name = "basesToolStripMenuItem";
            this.basesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.basesToolStripMenuItem.Text = "&Base Datos";
            this.basesToolStripMenuItem.Click += new System.EventHandler(this.basesToolStripMenuItem_Click);
            // 
            // insertarToolStripMenuItem
            // 
            this.insertarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("insertarToolStripMenuItem.Image")));
            this.insertarToolStripMenuItem.Name = "insertarToolStripMenuItem";
            this.insertarToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.insertarToolStripMenuItem.Text = "Insertar";
            this.insertarToolStripMenuItem.Click += new System.EventHandler(this.basesToolStripMenuItem_Click);
            // 
            // fPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 368);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbRuta);
            this.Controls.Add(this.btnCargaFichero);
            this.Controls.Add(this.btnTraspaso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDestino);
            this.Controls.Add(this.Origen);
            this.Controls.Add(this.tbOrigen);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnExpReg);
            this.Controls.Add(this.btnDatos);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fPrincipal";
            this.Text = "PRINCIPAL";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDatos;
        private System.Windows.Forms.Button btnExpReg;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label Origen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTraspaso;
        private System.Windows.Forms.Button btnCargaFichero;
        private System.Windows.Forms.TextBox tbRuta;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox tbOrigen;
        internal System.Windows.Forms.TextBox tbDestino;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem basesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarToolStripMenuItem;
    }
}


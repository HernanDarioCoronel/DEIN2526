namespace CajasDeDialogo
{
    partial class DlgFotografía
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCargar = new System.Windows.Forms.Button();
            this.pbFotografia = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ctText = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotografia)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 508);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btCargar);
            this.tabPage1.Controls.Add(this.pbFotografia);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(785, 482);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btAceptar
            // 
            this.btAceptar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btAceptar.Location = new System.Drawing.Point(3, 498);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(793, 23);
            this.btAceptar.TabIndex = 2;
            this.btAceptar.Text = "&Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCargar
            // 
            this.btCargar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btCargar.Location = new System.Drawing.Point(3, 456);
            this.btCargar.Name = "btCargar";
            this.btCargar.Size = new System.Drawing.Size(779, 23);
            this.btCargar.TabIndex = 1;
            this.btCargar.Text = "Cargar";
            this.btCargar.UseVisualStyleBackColor = true;
            this.btCargar.Click += new System.EventHandler(this.btCargar_Click);
            // 
            // pbFotografia
            // 
            this.pbFotografia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFotografia.Location = new System.Drawing.Point(3, 3);
            this.pbFotografia.Name = "pbFotografia";
            this.pbFotografia.Size = new System.Drawing.Size(779, 476);
            this.pbFotografia.TabIndex = 0;
            this.pbFotografia.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ctText);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 494);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ctText
            // 
            this.ctText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctText.Location = new System.Drawing.Point(3, 3);
            this.ctText.Multiline = true;
            this.ctText.Name = "ctText";
            this.ctText.Size = new System.Drawing.Size(785, 488);
            this.ctText.TabIndex = 0;
            // 
            // DlgFotografía
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 524);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.tabControl1);
            this.Name = "DlgFotografía";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Text = "DlgFotografía";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotografia)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btCargar;
        private System.Windows.Forms.PictureBox pbFotografia;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.TextBox ctText;
    }
}
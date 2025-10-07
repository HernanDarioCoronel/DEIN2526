namespace RegExps
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
            this.components = new System.ComponentModel.Container();
            this.BtnUrl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TboxUrl = new System.Windows.Forms.TextBox();
            this.TboxIp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnIp = new System.Windows.Forms.Button();
            this.TboxMattr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnMattr = new System.Windows.Forms.Button();
            this.TboxHex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TboxPaste = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.infoProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnUrl
            // 
            this.BtnUrl.Location = new System.Drawing.Point(197, 12);
            this.BtnUrl.Name = "BtnUrl";
            this.BtnUrl.Size = new System.Drawing.Size(75, 23);
            this.BtnUrl.TabIndex = 0;
            this.BtnUrl.Text = "button1";
            this.BtnUrl.UseVisualStyleBackColor = true;
            this.BtnUrl.Click += new System.EventHandler(this.BtnUrl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Url";
            // 
            // TboxUrl
            // 
            this.TboxUrl.Location = new System.Drawing.Point(74, 14);
            this.TboxUrl.Name = "TboxUrl";
            this.TboxUrl.Size = new System.Drawing.Size(100, 20);
            this.TboxUrl.TabIndex = 2;
            // 
            // TboxIp
            // 
            this.TboxIp.Location = new System.Drawing.Point(74, 50);
            this.TboxIp.Name = "TboxIp";
            this.TboxIp.Size = new System.Drawing.Size(100, 20);
            this.TboxIp.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ip";
            // 
            // BtnIp
            // 
            this.BtnIp.Location = new System.Drawing.Point(197, 48);
            this.BtnIp.Name = "BtnIp";
            this.BtnIp.Size = new System.Drawing.Size(75, 23);
            this.BtnIp.TabIndex = 3;
            this.BtnIp.Text = "button2";
            this.BtnIp.UseVisualStyleBackColor = true;
            this.BtnIp.Click += new System.EventHandler(this.BtnIp_Click);
            // 
            // TboxMattr
            // 
            this.TboxMattr.Location = new System.Drawing.Point(74, 85);
            this.TboxMattr.Name = "TboxMattr";
            this.TboxMattr.Size = new System.Drawing.Size(100, 20);
            this.TboxMattr.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Matricula";
            // 
            // BtnMattr
            // 
            this.BtnMattr.Location = new System.Drawing.Point(197, 83);
            this.BtnMattr.Name = "BtnMattr";
            this.BtnMattr.Size = new System.Drawing.Size(75, 23);
            this.BtnMattr.TabIndex = 6;
            this.BtnMattr.Text = "button3";
            this.BtnMattr.UseVisualStyleBackColor = true;
            this.BtnMattr.Click += new System.EventHandler(this.BtnMattr_Click);
            // 
            // TboxHex
            // 
            this.TboxHex.Location = new System.Drawing.Point(74, 121);
            this.TboxHex.Name = "TboxHex";
            this.TboxHex.Size = new System.Drawing.Size(100, 20);
            this.TboxHex.TabIndex = 11;
            this.TboxHex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TboxHex_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hexadecimal";
            // 
            // TboxPaste
            // 
            this.TboxPaste.Location = new System.Drawing.Point(74, 158);
            this.TboxPaste.Name = "TboxPaste";
            this.TboxPaste.Size = new System.Drawing.Size(100, 20);
            this.TboxPaste.TabIndex = 14;
            this.TboxPaste.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TboxPaste_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pegar";
            // 
            // infoProvider
            // 
            this.infoProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 208);
            this.Controls.Add(this.TboxPaste);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TboxHex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TboxMattr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnMattr);
            this.Controls.Add(this.TboxIp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnIp);
            this.Controls.Add(this.TboxUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TboxUrl;
        private System.Windows.Forms.TextBox TboxIp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnIp;
        private System.Windows.Forms.TextBox TboxMattr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnMattr;
        private System.Windows.Forms.TextBox TboxHex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TboxPaste;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider infoProvider;
    }
}


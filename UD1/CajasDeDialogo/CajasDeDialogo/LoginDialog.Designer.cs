namespace CajasDeDialogo
{
    partial class LoginDialog
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
            this.couldLogLabel = new System.Windows.Forms.Label();
            this.intentosLabel = new System.Windows.Forms.Label();
            this.aceptarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // couldLogLabel
            // 
            this.couldLogLabel.AutoSize = true;
            this.couldLogLabel.Location = new System.Drawing.Point(83, 12);
            this.couldLogLabel.Name = "couldLogLabel";
            this.couldLogLabel.Size = new System.Drawing.Size(35, 13);
            this.couldLogLabel.TabIndex = 0;
            this.couldLogLabel.Text = "label1";
            // 
            // intentosLabel
            // 
            this.intentosLabel.AutoSize = true;
            this.intentosLabel.Location = new System.Drawing.Point(83, 44);
            this.intentosLabel.Name = "intentosLabel";
            this.intentosLabel.Size = new System.Drawing.Size(35, 13);
            this.intentosLabel.TabIndex = 1;
            this.intentosLabel.Text = "label1";
            this.intentosLabel.Visible = false;
            // 
            // aceptarBtn
            // 
            this.aceptarBtn.Location = new System.Drawing.Point(64, 88);
            this.aceptarBtn.Name = "aceptarBtn";
            this.aceptarBtn.Size = new System.Drawing.Size(75, 23);
            this.aceptarBtn.TabIndex = 2;
            this.aceptarBtn.Text = "Aceptar";
            this.aceptarBtn.UseVisualStyleBackColor = true;
            this.aceptarBtn.Click += new System.EventHandler(this.aceptarBtn_Click);
            // 
            // LoginDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 137);
            this.Controls.Add(this.aceptarBtn);
            this.Controls.Add(this.intentosLabel);
            this.Controls.Add(this.couldLogLabel);
            this.Name = "LoginDialog";
            this.Text = "LoginDialog";
            this.Load += new System.EventHandler(this.LoginDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label couldLogLabel;
        private System.Windows.Forms.Label intentosLabel;
        private System.Windows.Forms.Button aceptarBtn;
    }
}
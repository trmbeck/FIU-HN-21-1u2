
namespace MeineErsteWinFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbEingabe = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.txbAusgabe = new System.Windows.Forms.TextBox();
            this.btnCopyPaste = new System.Windows.Forms.Button();
            this.txbAusgabe2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbEingabe
            // 
            this.txbEingabe.Location = new System.Drawing.Point(13, 13);
            this.txbEingabe.Name = "txbEingabe";
            this.txbEingabe.Size = new System.Drawing.Size(100, 20);
            this.txbEingabe.TabIndex = 0;
            this.txbEingabe.Text = "Hallo Welt";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(171, 13);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txbAusgabe
            // 
            this.txbAusgabe.Enabled = false;
            this.txbAusgabe.Location = new System.Drawing.Point(13, 68);
            this.txbAusgabe.Name = "txbAusgabe";
            this.txbAusgabe.Size = new System.Drawing.Size(100, 20);
            this.txbAusgabe.TabIndex = 2;
            // 
            // btnCopyPaste
            // 
            this.btnCopyPaste.Location = new System.Drawing.Point(171, 68);
            this.btnCopyPaste.Name = "btnCopyPaste";
            this.btnCopyPaste.Size = new System.Drawing.Size(100, 23);
            this.btnCopyPaste.TabIndex = 3;
            this.btnCopyPaste.Text = "Copy/Paste";
            this.btnCopyPaste.UseVisualStyleBackColor = true;
            this.btnCopyPaste.Click += new System.EventHandler(this.btnCopyPaste_Click);
            // 
            // txbAusgabe2
            // 
            this.txbAusgabe2.Enabled = false;
            this.txbAusgabe2.Location = new System.Drawing.Point(13, 108);
            this.txbAusgabe2.Name = "txbAusgabe2";
            this.txbAusgabe2.Size = new System.Drawing.Size(100, 20);
            this.txbAusgabe2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(283, 164);
            this.Controls.Add(this.txbAusgabe2);
            this.Controls.Add(this.btnCopyPaste);
            this.Controls.Add(this.txbAusgabe);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txbEingabe);
            this.Name = "Form1";
            this.Text = "Grüße";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbEingabe;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txbAusgabe;
        private System.Windows.Forms.Button btnCopyPaste;
        private System.Windows.Forms.TextBox txbAusgabe2;
    }
}


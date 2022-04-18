
namespace Steam.WinForms
{
    partial class Steam
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
            this.buttonAccount = new System.Windows.Forms.Button();
            this.buttonMarket = new System.Windows.Forms.Button();
            this.buttonLibrary = new System.Windows.Forms.Button();
            this.hostPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonAccount
            // 
            this.buttonAccount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAccount.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAccount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAccount.Location = new System.Drawing.Point(550, -2);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Size = new System.Drawing.Size(253, 44);
            this.buttonAccount.TabIndex = 2;
            this.buttonAccount.Text = "Account";
            this.buttonAccount.UseVisualStyleBackColor = false;
            this.buttonAccount.Click += new System.EventHandler(this.buttonAccount_Click);       
            // 
            // buttonMarket
            // 
            this.buttonMarket.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonMarket.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMarket.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMarket.Location = new System.Drawing.Point(-6, -2);
            this.buttonMarket.Name = "buttonMarket";
            this.buttonMarket.Size = new System.Drawing.Size(264, 44);
            this.buttonMarket.TabIndex = 0;
            this.buttonMarket.Text = "Market";
            this.buttonMarket.UseVisualStyleBackColor = false;
            this.buttonMarket.Click += new System.EventHandler(this.buttonMarket_Click);
            // 
            // buttonLibrary
            // 
            this.buttonLibrary.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLibrary.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLibrary.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonLibrary.Location = new System.Drawing.Point(269, -2);
            this.buttonLibrary.Name = "buttonLibrary";
            this.buttonLibrary.Size = new System.Drawing.Size(274, 44);
            this.buttonLibrary.TabIndex = 1;
            this.buttonLibrary.Text = "Library";
            this.buttonLibrary.UseVisualStyleBackColor = false;
            this.buttonLibrary.Click += new System.EventHandler(this.buttonLibrary_Click);
            // 
            // hostPanel
            // 
            this.hostPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hostPanel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hostPanel.Location = new System.Drawing.Point(-1, 48);
            this.hostPanel.Name = "hostPanel";
            this.hostPanel.Size = new System.Drawing.Size(801, 405);
            this.hostPanel.TabIndex = 3;
            // 
            // Steam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hostPanel);
            this.Controls.Add(this.buttonLibrary);
            this.Controls.Add(this.buttonMarket);
            this.Controls.Add(this.buttonAccount);
            this.Name = "Steam";
            this.Text = "Steam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Steam_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAccount;
        private System.Windows.Forms.Button buttonMarket;
        private System.Windows.Forms.Button buttonLibrary;
        private System.Windows.Forms.Panel hostPanel;
    }
}
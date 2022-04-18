
namespace Steam.WinForms.Views.MainForm
{
    partial class LibraryGameInfo
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DiscribeLb = new System.Windows.Forms.Label();
            this.GameNameLb = new System.Windows.Forms.Label();
            this.DelGameBtn = new System.Windows.Forms.Button();
            this.GameImagePB = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GameImagePB)).BeginInit();
            this.SuspendLayout();
            // 
            // DiscribeLb
            // 
            this.DiscribeLb.AutoSize = true;
            this.DiscribeLb.Location = new System.Drawing.Point(593, 3);
            this.DiscribeLb.Name = "DiscribeLb";
            this.DiscribeLb.Size = new System.Drawing.Size(38, 15);
            this.DiscribeLb.TabIndex = 0;
            this.DiscribeLb.Text = "label1";
            // 
            // GameNameLb
            // 
            this.GameNameLb.AutoSize = true;
            this.GameNameLb.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GameNameLb.Location = new System.Drawing.Point(3, 284);
            this.GameNameLb.Name = "GameNameLb";
            this.GameNameLb.Size = new System.Drawing.Size(83, 32);
            this.GameNameLb.TabIndex = 1;
            this.GameNameLb.Text = "label1";
            // 
            // DelGameBtn
            // 
            this.DelGameBtn.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DelGameBtn.ForeColor = System.Drawing.Color.Black;
            this.DelGameBtn.Location = new System.Drawing.Point(593, 210);
            this.DelGameBtn.Name = "DelGameBtn";
            this.DelGameBtn.Size = new System.Drawing.Size(122, 71);
            this.DelGameBtn.TabIndex = 2;
            this.DelGameBtn.Text = "Delete game";
            this.DelGameBtn.UseVisualStyleBackColor = true;
            this.DelGameBtn.Click += new System.EventHandler(this.DelGameBtn_Click);
            // 
            // GameImagePB
            // 
            this.GameImagePB.Location = new System.Drawing.Point(3, 3);
            this.GameImagePB.Name = "GameImagePB";
            this.GameImagePB.Size = new System.Drawing.Size(584, 278);
            this.GameImagePB.TabIndex = 3;
            this.GameImagePB.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("FORTNITE BATTLEFEST", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(593, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 71);
            this.button1.TabIndex = 4;
            this.button1.Text = "PLAY NOW";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LibraryGameInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GameImagePB);
            this.Controls.Add(this.DelGameBtn);
            this.Controls.Add(this.GameNameLb);
            this.Controls.Add(this.DiscribeLb);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "LibraryGameInfo";
            this.Size = new System.Drawing.Size(779, 590);
            this.Load += new System.EventHandler(this.LibraryGameInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GameImagePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DiscribeLb;
        private System.Windows.Forms.Label GameNameLb;
        private System.Windows.Forms.Button DelGameBtn;
        private System.Windows.Forms.PictureBox GameImagePB;
        private System.Windows.Forms.Button button1;
    }
}

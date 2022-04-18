
namespace Steam.WinForms.Views.MainForm
{
    partial class GameInfo
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
            this.GameImagePB = new System.Windows.Forms.PictureBox();
            this.gameNameLB = new System.Windows.Forms.Label();
            this.gameDiscribeLB = new System.Windows.Forms.Label();
            this.gamePriceLB = new System.Windows.Forms.Label();
            this.BuyGameBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GameImagePB)).BeginInit();
            this.SuspendLayout();
            // 
            // GameImagePB
            // 
            this.GameImagePB.Location = new System.Drawing.Point(7, 6);
            this.GameImagePB.Name = "GameImagePB";
            this.GameImagePB.Size = new System.Drawing.Size(584, 278);
            this.GameImagePB.TabIndex = 0;
            this.GameImagePB.TabStop = false;
            // 
            // gameNameLB
            // 
            this.gameNameLB.AutoSize = true;
            this.gameNameLB.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gameNameLB.Location = new System.Drawing.Point(7, 287);
            this.gameNameLB.Name = "gameNameLB";
            this.gameNameLB.Size = new System.Drawing.Size(83, 32);
            this.gameNameLB.TabIndex = 1;
            this.gameNameLB.Text = "label1";
            // 
            // gameDiscribeLB
            // 
            this.gameDiscribeLB.AutoSize = true;
            this.gameDiscribeLB.Location = new System.Drawing.Point(597, 6);
            this.gameDiscribeLB.Name = "gameDiscribeLB";
            this.gameDiscribeLB.Size = new System.Drawing.Size(38, 15);
            this.gameDiscribeLB.TabIndex = 2;
            this.gameDiscribeLB.Text = "label2";
            // 
            // gamePriceLB
            // 
            this.gamePriceLB.AutoSize = true;
            this.gamePriceLB.Location = new System.Drawing.Point(7, 319);
            this.gamePriceLB.Name = "gamePriceLB";
            this.gamePriceLB.Size = new System.Drawing.Size(38, 15);
            this.gamePriceLB.TabIndex = 3;
            this.gamePriceLB.Text = "label3";
            // 
            // BuyGameBT
            // 
            this.BuyGameBT.Font = new System.Drawing.Font("FORTNITE BATTLEFEST", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BuyGameBT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BuyGameBT.Location = new System.Drawing.Point(597, 201);
            this.BuyGameBT.Name = "BuyGameBT";
            this.BuyGameBT.Size = new System.Drawing.Size(180, 83);
            this.BuyGameBT.TabIndex = 4;
            this.BuyGameBT.Text = "BUY NOW!!!!!";
            this.BuyGameBT.UseVisualStyleBackColor = true;
            this.BuyGameBT.Click += new System.EventHandler(this.BuyGameBT_Click);
            // 
            // GameInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.Controls.Add(this.BuyGameBT);
            this.Controls.Add(this.gamePriceLB);
            this.Controls.Add(this.gameDiscribeLB);
            this.Controls.Add(this.gameNameLB);
            this.Controls.Add(this.GameImagePB);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "GameInfo";
            this.Size = new System.Drawing.Size(790, 604);
            this.Load += new System.EventHandler(this.GameInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GameImagePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GameImagePB;
        private System.Windows.Forms.Label gameNameLB;
        private System.Windows.Forms.Label gameDiscribeLB;
        private System.Windows.Forms.Label gamePriceLB;
        private System.Windows.Forms.Button BuyGameBT;
    }
}

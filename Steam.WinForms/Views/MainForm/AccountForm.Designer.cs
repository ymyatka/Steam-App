
namespace Steam.WinForms.Views.MainForm
{
    partial class AccountForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.nicknameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.moneyTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(23, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "nickname:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(26, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "money:";
            // 
            // nameTB
            // 
            this.nameTB.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.nameTB.ForeColor = System.Drawing.SystemColors.Info;
            this.nameTB.Location = new System.Drawing.Point(10, 71);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(98, 23);
            this.nameTB.TabIndex = 16;
            this.nameTB.TextChanged += new System.EventHandler(this.nameLabel_TextChanged);
            // 
            // nicknameTB
            // 
            this.nicknameTB.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.nicknameTB.ForeColor = System.Drawing.SystemColors.Info;
            this.nicknameTB.Location = new System.Drawing.Point(7, 139);
            this.nicknameTB.Name = "nicknameTB";
            this.nicknameTB.Size = new System.Drawing.Size(101, 23);
            this.nicknameTB.TabIndex = 17;
            this.nicknameTB.TextChanged += new System.EventHandler(this.nicknameLabel_TextChanged);
            // 
            // passwordTB
            // 
            this.passwordTB.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.passwordTB.ForeColor = System.Drawing.SystemColors.Info;
            this.passwordTB.Location = new System.Drawing.Point(7, 213);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(101, 23);
            this.passwordTB.TabIndex = 18;
            this.passwordTB.TextChanged += new System.EventHandler(this.passwordLabel_TextChanged);
            // 
            // moneyTB
            // 
            this.moneyTB.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.moneyTB.ForeColor = System.Drawing.SystemColors.Info;
            this.moneyTB.Location = new System.Drawing.Point(7, 287);
            this.moneyTB.Name = "moneyTB";
            this.moneyTB.Size = new System.Drawing.Size(101, 23);
            this.moneyTB.TabIndex = 19;
            this.moneyTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.Controls.Add(this.moneyTB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.nicknameTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "AccountForm";
            this.Size = new System.Drawing.Size(730, 490);
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox nicknameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox moneyTB;
    }
}

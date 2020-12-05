
namespace ClinicApp.Forms
{
    partial class MenusForm
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
            this.OSForm = new System.Windows.Forms.Button();
            this.ownersBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.vForm = new System.Windows.Forms.Button();
            this.aButton = new System.Windows.Forms.Button();
            this.vButton = new System.Windows.Forms.Button();
            this.avButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OSForm
            // 
            this.OSForm.BackColor = System.Drawing.SystemColors.GrayText;
            this.OSForm.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OSForm.ForeColor = System.Drawing.SystemColors.Info;
            this.OSForm.Location = new System.Drawing.Point(145, 151);
            this.OSForm.Name = "OSForm";
            this.OSForm.Size = new System.Drawing.Size(207, 37);
            this.OSForm.TabIndex = 2;
            this.OSForm.Text = "Покупки владельцев";
            this.OSForm.UseVisualStyleBackColor = false;
            this.OSForm.Click += new System.EventHandler(this.OSForm_Click);
            // 
            // ownersBtn
            // 
            this.ownersBtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.ownersBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.ownersBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.ownersBtn.Location = new System.Drawing.Point(145, 80);
            this.ownersBtn.Name = "ownersBtn";
            this.ownersBtn.Size = new System.Drawing.Size(207, 37);
            this.ownersBtn.TabIndex = 43;
            this.ownersBtn.Text = "Владельцы";
            this.ownersBtn.UseVisualStyleBackColor = false;
            this.ownersBtn.Click += new System.EventHandler(this.ownersBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(145, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 34);
            this.button1.TabIndex = 44;
            this.button1.Text = "Услуги";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vForm
            // 
            this.vForm.BackColor = System.Drawing.SystemColors.GrayText;
            this.vForm.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vForm.ForeColor = System.Drawing.SystemColors.Info;
            this.vForm.Location = new System.Drawing.Point(145, 188);
            this.vForm.Name = "vForm";
            this.vForm.Size = new System.Drawing.Size(207, 37);
            this.vForm.TabIndex = 45;
            this.vForm.Text = "Ветеринары";
            this.vForm.UseVisualStyleBackColor = false;
            this.vForm.Click += new System.EventHandler(this.vForm_Click);
            // 
            // aButton
            // 
            this.aButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.aButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aButton.ForeColor = System.Drawing.SystemColors.Info;
            this.aButton.Location = new System.Drawing.Point(145, 225);
            this.aButton.Name = "aButton";
            this.aButton.Size = new System.Drawing.Size(207, 37);
            this.aButton.TabIndex = 46;
            this.aButton.Text = "Животные";
            this.aButton.UseVisualStyleBackColor = false;
            this.aButton.Click += new System.EventHandler(this.aButton_Click);
            // 
            // vButton
            // 
            this.vButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.vButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vButton.ForeColor = System.Drawing.SystemColors.Info;
            this.vButton.Location = new System.Drawing.Point(145, 262);
            this.vButton.Name = "vButton";
            this.vButton.Size = new System.Drawing.Size(207, 37);
            this.vButton.TabIndex = 47;
            this.vButton.Text = "Вакцины";
            this.vButton.UseVisualStyleBackColor = false;
            this.vButton.Click += new System.EventHandler(this.vButton_Click);
            // 
            // avButton
            // 
            this.avButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.avButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avButton.ForeColor = System.Drawing.SystemColors.Info;
            this.avButton.Location = new System.Drawing.Point(145, 299);
            this.avButton.Name = "avButton";
            this.avButton.Size = new System.Drawing.Size(207, 37);
            this.avButton.TabIndex = 48;
            this.avButton.Text = "Вакцинация";
            this.avButton.UseVisualStyleBackColor = false;
            this.avButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // MenusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 432);
            this.Controls.Add(this.avButton);
            this.Controls.Add(this.vButton);
            this.Controls.Add(this.aButton);
            this.Controls.Add(this.vForm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ownersBtn);
            this.Controls.Add(this.OSForm);
            this.Name = "MenusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenusForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OSForm;
        private System.Windows.Forms.Button ownersBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button vForm;
        private System.Windows.Forms.Button aButton;
        private System.Windows.Forms.Button vButton;
        private System.Windows.Forms.Button avButton;
    }
}
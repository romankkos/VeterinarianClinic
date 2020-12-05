
namespace ClinicApp.Forms
{
    partial class VeterinarianForm
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
            this.email = new System.Windows.Forms.TextBox();
            this.veterinarian_lastname = new System.Windows.Forms.TextBox();
            this.veterinarian_surname = new System.Windows.Forms.TextBox();
            this.veterinarian_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.veterinarianView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backButtonmenu = new System.Windows.Forms.Button();
            this.aButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarianView)).BeginInit();
            this.SuspendLayout();
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(188, 247);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(199, 35);
            this.email.TabIndex = 17;
            // 
            // veterinarian_lastname
            // 
            this.veterinarian_lastname.Location = new System.Drawing.Point(188, 183);
            this.veterinarian_lastname.Multiline = true;
            this.veterinarian_lastname.Name = "veterinarian_lastname";
            this.veterinarian_lastname.Size = new System.Drawing.Size(199, 35);
            this.veterinarian_lastname.TabIndex = 16;
            // 
            // veterinarian_surname
            // 
            this.veterinarian_surname.Location = new System.Drawing.Point(188, 122);
            this.veterinarian_surname.Multiline = true;
            this.veterinarian_surname.Name = "veterinarian_surname";
            this.veterinarian_surname.Size = new System.Drawing.Size(199, 35);
            this.veterinarian_surname.TabIndex = 15;
            // 
            // veterinarian_name
            // 
            this.veterinarian_name.Location = new System.Drawing.Point(188, 65);
            this.veterinarian_name.Multiline = true;
            this.veterinarian_name.Name = "veterinarian_name";
            this.veterinarian_name.Size = new System.Drawing.Size(199, 35);
            this.veterinarian_name.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Имя ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "E-Mail";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.saveButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.saveButton.ForeColor = System.Drawing.SystemColors.Info;
            this.saveButton.Location = new System.Drawing.Point(84, 321);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(97, 29);
            this.saveButton.TabIndex = 22;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.clearButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.clearButton.ForeColor = System.Drawing.SystemColors.Info;
            this.clearButton.Location = new System.Drawing.Point(195, 321);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(97, 29);
            this.clearButton.TabIndex = 23;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.deleteButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.deleteButton.ForeColor = System.Drawing.SystemColors.Info;
            this.deleteButton.Location = new System.Drawing.Point(303, 321);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(97, 29);
            this.deleteButton.TabIndex = 24;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // veterinarianView
            // 
            this.veterinarianView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.veterinarianView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.veterinarianView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fName,
            this.sName,
            this.lName,
            this.Mail});
            this.veterinarianView.Location = new System.Drawing.Point(450, 51);
            this.veterinarianView.Name = "veterinarianView";
            this.veterinarianView.Size = new System.Drawing.Size(546, 320);
            this.veterinarianView.TabIndex = 25;
            this.veterinarianView.DoubleClick += new System.EventHandler(this.veterinarianView_DoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // fName
            // 
            this.fName.DataPropertyName = "VeterinarianName";
            this.fName.HeaderText = "Имя";
            this.fName.Name = "fName";
            // 
            // sName
            // 
            this.sName.DataPropertyName = "VeterinarianSurname";
            this.sName.HeaderText = "Фамилия";
            this.sName.Name = "sName";
            // 
            // lName
            // 
            this.lName.DataPropertyName = "VeterinarianLastname";
            this.lName.HeaderText = "Отчество";
            this.lName.Name = "lName";
            // 
            // Mail
            // 
            this.Mail.DataPropertyName = "email";
            this.Mail.HeaderText = "Почта";
            this.Mail.Name = "Mail";
            // 
            // backButtonmenu
            // 
            this.backButtonmenu.BackColor = System.Drawing.SystemColors.GrayText;
            this.backButtonmenu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.backButtonmenu.ForeColor = System.Drawing.SystemColors.Info;
            this.backButtonmenu.Location = new System.Drawing.Point(12, 12);
            this.backButtonmenu.Name = "backButtonmenu";
            this.backButtonmenu.Size = new System.Drawing.Size(97, 29);
            this.backButtonmenu.TabIndex = 43;
            this.backButtonmenu.Text = "Меню";
            this.backButtonmenu.UseVisualStyleBackColor = false;
            this.backButtonmenu.Click += new System.EventHandler(this.backButtonmenu_Click);
            // 
            // aButton
            // 
            this.aButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.aButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aButton.ForeColor = System.Drawing.SystemColors.Info;
            this.aButton.Location = new System.Drawing.Point(121, 476);
            this.aButton.Name = "aButton";
            this.aButton.Size = new System.Drawing.Size(207, 37);
            this.aButton.TabIndex = 47;
            this.aButton.Text = "Животные";
            this.aButton.UseVisualStyleBackColor = false;
            this.aButton.Click += new System.EventHandler(this.aButton_Click);
            // 
            // VeterinarianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 538);
            this.Controls.Add(this.aButton);
            this.Controls.Add(this.backButtonmenu);
            this.Controls.Add(this.veterinarianView);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.veterinarian_lastname);
            this.Controls.Add(this.veterinarian_surname);
            this.Controls.Add(this.veterinarian_name);
            this.Name = "VeterinarianForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ветеринары";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VeterinarianForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.veterinarianView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox veterinarian_lastname;
        private System.Windows.Forms.TextBox veterinarian_surname;
        private System.Windows.Forms.TextBox veterinarian_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView veterinarianView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.Button backButtonmenu;
        private System.Windows.Forms.Button aButton;
    }
}
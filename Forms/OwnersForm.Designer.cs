
namespace ClinicApp.Forms
{
    partial class OwnersForm
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.owner_lastname = new System.Windows.Forms.TextBox();
            this.owner_surname = new System.Windows.Forms.TextBox();
            this.owner_name = new System.Windows.Forms.TextBox();
            this.ownerView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backButtonmenu = new System.Windows.Forms.Button();
            this.backButtonform = new System.Windows.Forms.Button();
            this.aButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ownerView)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.deleteButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.deleteButton.ForeColor = System.Drawing.SystemColors.Info;
            this.deleteButton.Location = new System.Drawing.Point(277, 302);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(93, 27);
            this.deleteButton.TabIndex = 28;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.clearButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.clearButton.ForeColor = System.Drawing.SystemColors.Info;
            this.clearButton.Location = new System.Drawing.Point(153, 302);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(93, 27);
            this.clearButton.TabIndex = 27;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.saveButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.saveButton.ForeColor = System.Drawing.SystemColors.Info;
            this.saveButton.Location = new System.Drawing.Point(35, 302);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(93, 27);
            this.saveButton.TabIndex = 26;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Номер телефона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Отчество владельца";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Фамилия владельца";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Имя владельца";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(171, 229);
            this.phone.Multiline = true;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(199, 35);
            this.phone.TabIndex = 32;
            // 
            // owner_lastname
            // 
            this.owner_lastname.Location = new System.Drawing.Point(171, 165);
            this.owner_lastname.Multiline = true;
            this.owner_lastname.Name = "owner_lastname";
            this.owner_lastname.Size = new System.Drawing.Size(199, 35);
            this.owner_lastname.TabIndex = 31;
            // 
            // owner_surname
            // 
            this.owner_surname.Location = new System.Drawing.Point(171, 104);
            this.owner_surname.Multiline = true;
            this.owner_surname.Name = "owner_surname";
            this.owner_surname.Size = new System.Drawing.Size(199, 35);
            this.owner_surname.TabIndex = 30;
            // 
            // owner_name
            // 
            this.owner_name.Location = new System.Drawing.Point(171, 47);
            this.owner_name.Multiline = true;
            this.owner_name.Name = "owner_name";
            this.owner_name.Size = new System.Drawing.Size(199, 35);
            this.owner_name.TabIndex = 29;
            // 
            // ownerView
            // 
            this.ownerView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ownerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ownerView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.oName,
            this.ofName,
            this.olName,
            this.oPhone});
            this.ownerView.Location = new System.Drawing.Point(406, 47);
            this.ownerView.Name = "ownerView";
            this.ownerView.Size = new System.Drawing.Size(544, 365);
            this.ownerView.TabIndex = 37;
            this.ownerView.DoubleClick += new System.EventHandler(this.ownerView_DoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // oName
            // 
            this.oName.DataPropertyName = "OwnerName";
            this.oName.HeaderText = "Имя владельца";
            this.oName.Name = "oName";
            // 
            // ofName
            // 
            this.ofName.DataPropertyName = "OwnerSurname";
            this.ofName.HeaderText = "Фамилия владельца";
            this.ofName.Name = "ofName";
            // 
            // olName
            // 
            this.olName.DataPropertyName = "OwnerLastname";
            this.olName.HeaderText = "Отчество владельца";
            this.olName.Name = "olName";
            // 
            // oPhone
            // 
            this.oPhone.DataPropertyName = "Phone";
            this.oPhone.HeaderText = "Телефон";
            this.oPhone.Name = "oPhone";
            // 
            // backButtonmenu
            // 
            this.backButtonmenu.BackColor = System.Drawing.SystemColors.GrayText;
            this.backButtonmenu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.backButtonmenu.ForeColor = System.Drawing.SystemColors.Info;
            this.backButtonmenu.Location = new System.Drawing.Point(12, 12);
            this.backButtonmenu.Name = "backButtonmenu";
            this.backButtonmenu.Size = new System.Drawing.Size(75, 28);
            this.backButtonmenu.TabIndex = 42;
            this.backButtonmenu.Text = "Меню";
            this.backButtonmenu.UseVisualStyleBackColor = false;
            this.backButtonmenu.Click += new System.EventHandler(this.backButtonmenu_Click);
            // 
            // backButtonform
            // 
            this.backButtonform.BackColor = System.Drawing.SystemColors.GrayText;
            this.backButtonform.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.backButtonform.ForeColor = System.Drawing.SystemColors.Info;
            this.backButtonform.Location = new System.Drawing.Point(118, 381);
            this.backButtonform.Name = "backButtonform";
            this.backButtonform.Size = new System.Drawing.Size(195, 28);
            this.backButtonform.TabIndex = 43;
            this.backButtonform.Text = "Владельцы и услуги";
            this.backButtonform.UseVisualStyleBackColor = false;
            this.backButtonform.Click += new System.EventHandler(this.backButtonform_Click);
            // 
            // aButton
            // 
            this.aButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.aButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.aButton.ForeColor = System.Drawing.SystemColors.Info;
            this.aButton.Location = new System.Drawing.Point(135, 415);
            this.aButton.Name = "aButton";
            this.aButton.Size = new System.Drawing.Size(158, 28);
            this.aButton.TabIndex = 44;
            this.aButton.Text = "Животные";
            this.aButton.UseVisualStyleBackColor = false;
            this.aButton.Click += new System.EventHandler(this.aButton_Click);
            // 
            // OwnersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 450);
            this.Controls.Add(this.aButton);
            this.Controls.Add(this.backButtonform);
            this.Controls.Add(this.backButtonmenu);
            this.Controls.Add(this.ownerView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.owner_lastname);
            this.Controls.Add(this.owner_surname);
            this.Controls.Add(this.owner_name);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Name = "OwnersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Владельцы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OwnersForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ownerView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox owner_lastname;
        private System.Windows.Forms.TextBox owner_surname;
        private System.Windows.Forms.TextBox owner_name;
        private System.Windows.Forms.DataGridView ownerView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn oName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ofName;
        private System.Windows.Forms.DataGridViewTextBoxColumn olName;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPhone;
        private System.Windows.Forms.Button backButtonmenu;
        private System.Windows.Forms.Button backButtonform;
        private System.Windows.Forms.Button aButton;
    }
}
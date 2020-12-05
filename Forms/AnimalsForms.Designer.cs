
namespace ClinicApp.Forms
{
    partial class AnimalsForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AnimalName = new System.Windows.Forms.TextBox();
            this.animalsView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animal_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vetId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.AnimalBreed = new System.Windows.Forms.TextBox();
            this.AnimalGender = new System.Windows.Forms.TextBox();
            this.AnimalAge = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.backButtonmenu = new System.Windows.Forms.Button();
            this.veterinarianView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner_id = new System.Windows.Forms.TextBox();
            this.veterinarian_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.vButton = new System.Windows.Forms.Button();
            this.oButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.animalsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarianView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название животного";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Порода животного";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пол животного";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Возраст животного";
            // 
            // AnimalName
            // 
            this.AnimalName.Location = new System.Drawing.Point(200, 132);
            this.AnimalName.Multiline = true;
            this.AnimalName.Name = "AnimalName";
            this.AnimalName.Size = new System.Drawing.Size(199, 35);
            this.AnimalName.TabIndex = 4;
            // 
            // animalsView
            // 
            this.animalsView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.animalsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animalsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.animal_name,
            this.breed,
            this.gender,
            this.age,
            this.vetId,
            this.oId});
            this.animalsView.Location = new System.Drawing.Point(586, 245);
            this.animalsView.Name = "animalsView";
            this.animalsView.Size = new System.Drawing.Size(747, 279);
            this.animalsView.TabIndex = 8;
            this.animalsView.DoubleClick += new System.EventHandler(this.animalsView_DoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // animal_name
            // 
            this.animal_name.DataPropertyName = "AnimalName";
            this.animal_name.HeaderText = "Название животного";
            this.animal_name.Name = "animal_name";
            // 
            // breed
            // 
            this.breed.DataPropertyName = "Breed";
            this.breed.HeaderText = "Порода";
            this.breed.Name = "breed";
            // 
            // gender
            // 
            this.gender.DataPropertyName = "Gender";
            this.gender.HeaderText = "Пол";
            this.gender.Name = "gender";
            // 
            // age
            // 
            this.age.DataPropertyName = "Age";
            this.age.HeaderText = "Возраст";
            this.age.Name = "age";
            // 
            // vetId
            // 
            this.vetId.DataPropertyName = "VeterinarianId";
            this.vetId.HeaderText = "Id Ветеринара";
            this.vetId.Name = "vetId";
            // 
            // oId
            // 
            this.oId.DataPropertyName = "OwnerId";
            this.oId.HeaderText = "Id Владельца";
            this.oId.Name = "oId";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.saveButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.saveButton.ForeColor = System.Drawing.SystemColors.Info;
            this.saveButton.Location = new System.Drawing.Point(68, 474);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(99, 27);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.clearButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.clearButton.ForeColor = System.Drawing.SystemColors.Info;
            this.clearButton.Location = new System.Drawing.Point(217, 474);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(99, 27);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // AnimalBreed
            // 
            this.AnimalBreed.Location = new System.Drawing.Point(200, 189);
            this.AnimalBreed.Multiline = true;
            this.AnimalBreed.Name = "AnimalBreed";
            this.AnimalBreed.Size = new System.Drawing.Size(199, 35);
            this.AnimalBreed.TabIndex = 11;
            // 
            // AnimalGender
            // 
            this.AnimalGender.Location = new System.Drawing.Point(200, 245);
            this.AnimalGender.Multiline = true;
            this.AnimalGender.Name = "AnimalGender";
            this.AnimalGender.Size = new System.Drawing.Size(199, 35);
            this.AnimalGender.TabIndex = 12;
            // 
            // AnimalAge
            // 
            this.AnimalAge.Location = new System.Drawing.Point(200, 303);
            this.AnimalAge.Multiline = true;
            this.AnimalAge.Name = "AnimalAge";
            this.AnimalAge.Size = new System.Drawing.Size(199, 35);
            this.AnimalAge.TabIndex = 13;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.deleteButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.deleteButton.ForeColor = System.Drawing.SystemColors.Info;
            this.deleteButton.Location = new System.Drawing.Point(377, 474);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(99, 27);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // backButtonmenu
            // 
            this.backButtonmenu.BackColor = System.Drawing.SystemColors.GrayText;
            this.backButtonmenu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.backButtonmenu.ForeColor = System.Drawing.SystemColors.Info;
            this.backButtonmenu.Location = new System.Drawing.Point(12, 12);
            this.backButtonmenu.Name = "backButtonmenu";
            this.backButtonmenu.Size = new System.Drawing.Size(99, 27);
            this.backButtonmenu.TabIndex = 44;
            this.backButtonmenu.Text = "Меню";
            this.backButtonmenu.UseVisualStyleBackColor = false;
            this.backButtonmenu.Click += new System.EventHandler(this.backButtonmenu_Click);
            // 
            // veterinarianView
            // 
            this.veterinarianView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.veterinarianView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.veterinarianView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.fName,
            this.sName,
            this.lName,
            this.Mail});
            this.veterinarianView.Location = new System.Drawing.Point(424, 52);
            this.veterinarianView.Name = "veterinarianView";
            this.veterinarianView.Size = new System.Drawing.Size(546, 162);
            this.veterinarianView.TabIndex = 45;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            // ownerView
            // 
            this.ownerView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ownerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ownerView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.oName,
            this.ofName,
            this.olName,
            this.oPhone});
            this.ownerView.Location = new System.Drawing.Point(985, 52);
            this.ownerView.Name = "ownerView";
            this.ownerView.Size = new System.Drawing.Size(546, 161);
            this.ownerView.TabIndex = 46;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn2.HeaderText = "id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
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
            // owner_id
            // 
            this.owner_id.Location = new System.Drawing.Point(200, 415);
            this.owner_id.Multiline = true;
            this.owner_id.Name = "owner_id";
            this.owner_id.Size = new System.Drawing.Size(199, 35);
            this.owner_id.TabIndex = 50;
            // 
            // veterinarian_id
            // 
            this.veterinarian_id.Location = new System.Drawing.Point(200, 357);
            this.veterinarian_id.Multiline = true;
            this.veterinarian_id.Name = "veterinarian_id";
            this.veterinarian_id.Size = new System.Drawing.Size(199, 35);
            this.veterinarian_id.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Id Владельца";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Id Ветеринара";
            // 
            // vButton
            // 
            this.vButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.vButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vButton.ForeColor = System.Drawing.SystemColors.Info;
            this.vButton.Location = new System.Drawing.Point(572, 7);
            this.vButton.Name = "vButton";
            this.vButton.Size = new System.Drawing.Size(207, 31);
            this.vButton.TabIndex = 51;
            this.vButton.Text = "Ветеринары";
            this.vButton.UseVisualStyleBackColor = false;
            this.vButton.Click += new System.EventHandler(this.vButton_Click);
            // 
            // oButton
            // 
            this.oButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.oButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oButton.ForeColor = System.Drawing.SystemColors.Info;
            this.oButton.Location = new System.Drawing.Point(1161, 12);
            this.oButton.Name = "oButton";
            this.oButton.Size = new System.Drawing.Size(207, 31);
            this.oButton.TabIndex = 52;
            this.oButton.Text = "Владельцы";
            this.oButton.UseVisualStyleBackColor = false;
            this.oButton.Click += new System.EventHandler(this.oButton_Click);
            // 
            // AnimalsForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 584);
            this.Controls.Add(this.oButton);
            this.Controls.Add(this.vButton);
            this.Controls.Add(this.owner_id);
            this.Controls.Add(this.veterinarian_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ownerView);
            this.Controls.Add(this.veterinarianView);
            this.Controls.Add(this.backButtonmenu);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.AnimalAge);
            this.Controls.Add(this.AnimalGender);
            this.Controls.Add(this.AnimalBreed);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.animalsView);
            this.Controls.Add(this.AnimalName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AnimalsForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Животные";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnimalsForms_FormClosed);
            this.Load += new System.EventHandler(this.AnimalsForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.animalsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarianView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AnimalName;
        private System.Windows.Forms.DataGridView animalsView;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox AnimalBreed;
        private System.Windows.Forms.TextBox AnimalGender;
        private System.Windows.Forms.TextBox AnimalAge;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button backButtonmenu;
        private System.Windows.Forms.DataGridView veterinarianView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridView ownerView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn oName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ofName;
        private System.Windows.Forms.DataGridViewTextBoxColumn olName;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPhone;
        private System.Windows.Forms.TextBox owner_id;
        private System.Windows.Forms.TextBox veterinarian_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn animal_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn breed;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn vetId;
        private System.Windows.Forms.DataGridViewTextBoxColumn oId;
        private System.Windows.Forms.Button vButton;
        private System.Windows.Forms.Button oButton;
    }
}
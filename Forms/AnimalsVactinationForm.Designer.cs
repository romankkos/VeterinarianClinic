
namespace ClinicApp.Forms
{
    partial class AnimalsVactinationForm
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
            this.animalsView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animal_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vetId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vactinationView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalsVactinationView = new System.Windows.Forms.DataGridView();
            this.avId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backButtonmenu = new System.Windows.Forms.Button();
            this.animal_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.vactination_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vButton = new System.Windows.Forms.Button();
            this.aButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.animalsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vactinationView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsVactinationView)).BeginInit();
            this.SuspendLayout();
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
            this.animalsView.Location = new System.Drawing.Point(153, 62);
            this.animalsView.Name = "animalsView";
            this.animalsView.Size = new System.Drawing.Size(747, 279);
            this.animalsView.TabIndex = 9;
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
            // vactinationView
            // 
            this.vactinationView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vactinationView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vactinationView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.vName});
            this.vactinationView.Location = new System.Drawing.Point(1014, 62);
            this.vactinationView.Name = "vactinationView";
            this.vactinationView.Size = new System.Drawing.Size(245, 279);
            this.vactinationView.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // vName
            // 
            this.vName.DataPropertyName = "VactinationName";
            this.vName.HeaderText = "Наименование вакцины";
            this.vName.Name = "vName";
            // 
            // animalsVactinationView
            // 
            this.animalsVactinationView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.animalsVactinationView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animalsVactinationView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.avId,
            this.aId,
            this.vId});
            this.animalsVactinationView.Location = new System.Drawing.Point(463, 396);
            this.animalsVactinationView.Name = "animalsVactinationView";
            this.animalsVactinationView.Size = new System.Drawing.Size(347, 299);
            this.animalsVactinationView.TabIndex = 34;
            this.animalsVactinationView.DoubleClick += new System.EventHandler(this.animalsVactinationView_DoubleClick);
            // 
            // avId
            // 
            this.avId.DataPropertyName = "Id";
            this.avId.HeaderText = "Id";
            this.avId.Name = "avId";
            // 
            // aId
            // 
            this.aId.DataPropertyName = "AnimalId";
            this.aId.HeaderText = "Id Животного";
            this.aId.Name = "aId";
            // 
            // vId
            // 
            this.vId.DataPropertyName = "VactinationId";
            this.vId.HeaderText = "Id Вакцины";
            this.vId.Name = "vId";
            // 
            // backButtonmenu
            // 
            this.backButtonmenu.BackColor = System.Drawing.SystemColors.GrayText;
            this.backButtonmenu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.backButtonmenu.ForeColor = System.Drawing.SystemColors.Info;
            this.backButtonmenu.Location = new System.Drawing.Point(12, 12);
            this.backButtonmenu.Name = "backButtonmenu";
            this.backButtonmenu.Size = new System.Drawing.Size(98, 28);
            this.backButtonmenu.TabIndex = 45;
            this.backButtonmenu.Text = "Меню";
            this.backButtonmenu.UseVisualStyleBackColor = false;
            this.backButtonmenu.Click += new System.EventHandler(this.backButtonmenu_Click);
            // 
            // animal_id
            // 
            this.animal_id.Location = new System.Drawing.Point(238, 493);
            this.animal_id.Name = "animal_id";
            this.animal_id.Size = new System.Drawing.Size(128, 20);
            this.animal_id.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Id Животного";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.deleteButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.deleteButton.ForeColor = System.Drawing.SystemColors.Info;
            this.deleteButton.Location = new System.Drawing.Point(357, 566);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(98, 28);
            this.deleteButton.TabIndex = 50;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.clearButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.clearButton.ForeColor = System.Drawing.SystemColors.Info;
            this.clearButton.Location = new System.Drawing.Point(235, 566);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(98, 28);
            this.clearButton.TabIndex = 49;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.saveButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.saveButton.ForeColor = System.Drawing.SystemColors.Info;
            this.saveButton.Location = new System.Drawing.Point(116, 566);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(98, 28);
            this.saveButton.TabIndex = 48;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // vactination_id
            // 
            this.vactination_id.Location = new System.Drawing.Point(238, 519);
            this.vactination_id.Name = "vactination_id";
            this.vactination_id.Size = new System.Drawing.Size(128, 20);
            this.vactination_id.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 522);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Id Вакцины";
            // 
            // vButton
            // 
            this.vButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.vButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vButton.ForeColor = System.Drawing.SystemColors.Info;
            this.vButton.Location = new System.Drawing.Point(1036, 19);
            this.vButton.Name = "vButton";
            this.vButton.Size = new System.Drawing.Size(207, 37);
            this.vButton.TabIndex = 53;
            this.vButton.Text = "Вакцины";
            this.vButton.UseVisualStyleBackColor = false;
            this.vButton.Click += new System.EventHandler(this.vButton_Click);
            // 
            // aButton
            // 
            this.aButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.aButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aButton.ForeColor = System.Drawing.SystemColors.Info;
            this.aButton.Location = new System.Drawing.Point(432, 19);
            this.aButton.Name = "aButton";
            this.aButton.Size = new System.Drawing.Size(207, 37);
            this.aButton.TabIndex = 54;
            this.aButton.Text = "Животные";
            this.aButton.UseVisualStyleBackColor = false;
            this.aButton.Click += new System.EventHandler(this.aButton_Click);
            // 
            // AnimalsVactinationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 798);
            this.Controls.Add(this.aButton);
            this.Controls.Add(this.vButton);
            this.Controls.Add(this.animal_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.vactination_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButtonmenu);
            this.Controls.Add(this.animalsVactinationView);
            this.Controls.Add(this.vactinationView);
            this.Controls.Add(this.animalsView);
            this.Name = "AnimalsVactinationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вакцинация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnimalsVactinationForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.animalsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vactinationView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsVactinationView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView animalsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn animal_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn breed;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn vetId;
        private System.Windows.Forms.DataGridViewTextBoxColumn oId;
        private System.Windows.Forms.DataGridView vactinationView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vName;
        private System.Windows.Forms.DataGridView animalsVactinationView;
        private System.Windows.Forms.Button backButtonmenu;
        private System.Windows.Forms.TextBox animal_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox vactination_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn avId;
        private System.Windows.Forms.DataGridViewTextBoxColumn aId;
        private System.Windows.Forms.DataGridViewTextBoxColumn vId;
        private System.Windows.Forms.Button vButton;
        private System.Windows.Forms.Button aButton;
    }
}
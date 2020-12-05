
namespace ClinicApp.Forms
{
    partial class OwnersServicesForm
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
            this.ownersServicesView = new System.Windows.Forms.DataGridView();
            this.osId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.service_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.owner_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ownerView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicesView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backButton = new System.Windows.Forms.Button();
            this.ownersBtn = new System.Windows.Forms.Button();
            this.servicesBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ownersServicesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesView)).BeginInit();
            this.SuspendLayout();
            // 
            // ownersServicesView
            // 
            this.ownersServicesView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ownersServicesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ownersServicesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.osId,
            this.oId,
            this.sId});
            this.ownersServicesView.Location = new System.Drawing.Point(648, 297);
            this.ownersServicesView.Name = "ownersServicesView";
            this.ownersServicesView.Size = new System.Drawing.Size(344, 203);
            this.ownersServicesView.TabIndex = 2;
            this.ownersServicesView.DoubleClick += new System.EventHandler(this.ownersServicesView_DoubleClick);
            // 
            // osId
            // 
            this.osId.DataPropertyName = "Id";
            this.osId.HeaderText = "id";
            this.osId.Name = "osId";
            // 
            // oId
            // 
            this.oId.DataPropertyName = "OwnerId";
            this.oId.HeaderText = "Id владельца";
            this.oId.Name = "oId";
            // 
            // sId
            // 
            this.sId.DataPropertyName = "ServiceId";
            this.sId.HeaderText = "Id услуги";
            this.sId.Name = "sId";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.deleteButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.deleteButton.ForeColor = System.Drawing.SystemColors.Info;
            this.deleteButton.Location = new System.Drawing.Point(226, 255);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 27);
            this.deleteButton.TabIndex = 36;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.clearButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.clearButton.ForeColor = System.Drawing.SystemColors.Info;
            this.clearButton.Location = new System.Drawing.Point(123, 255);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(90, 27);
            this.clearButton.TabIndex = 35;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click_1);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.saveButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.saveButton.ForeColor = System.Drawing.SystemColors.Info;
            this.saveButton.Location = new System.Drawing.Point(12, 255);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(96, 27);
            this.saveButton.TabIndex = 34;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // service_id
            // 
            this.service_id.Location = new System.Drawing.Point(115, 208);
            this.service_id.Name = "service_id";
            this.service_id.Size = new System.Drawing.Size(128, 20);
            this.service_id.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Id услуги";
            // 
            // owner_id
            // 
            this.owner_id.Location = new System.Drawing.Point(115, 182);
            this.owner_id.Name = "owner_id";
            this.owner_id.Size = new System.Drawing.Size(128, 20);
            this.owner_id.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Id владельца";
            // 
            // ownerView
            // 
            this.ownerView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ownerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ownerView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.oName,
            this.ofName,
            this.olName});
            this.ownerView.Location = new System.Drawing.Point(314, 71);
            this.ownerView.Name = "ownerView";
            this.ownerView.Size = new System.Drawing.Size(443, 203);
            this.ownerView.TabIndex = 39;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            // servicesView
            // 
            this.servicesView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.servicesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.serviceName,
            this.price});
            this.servicesView.Location = new System.Drawing.Point(814, 71);
            this.servicesView.Name = "servicesView";
            this.servicesView.Size = new System.Drawing.Size(343, 203);
            this.servicesView.TabIndex = 40;
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // serviceName
            // 
            this.serviceName.DataPropertyName = "ServiceName";
            this.serviceName.HeaderText = "Название услуги";
            this.serviceName.Name = "serviceName";
            // 
            // price
            // 
            this.price.DataPropertyName = "Price";
            this.price.HeaderText = "Цена";
            this.price.Name = "price";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.backButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.backButton.ForeColor = System.Drawing.SystemColors.Info;
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(68, 29);
            this.backButton.TabIndex = 41;
            this.backButton.Text = "Меню";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ownersBtn
            // 
            this.ownersBtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.ownersBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.ownersBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.ownersBtn.Location = new System.Drawing.Point(443, 26);
            this.ownersBtn.Name = "ownersBtn";
            this.ownersBtn.Size = new System.Drawing.Size(198, 27);
            this.ownersBtn.TabIndex = 42;
            this.ownersBtn.Text = "Владельцы";
            this.ownersBtn.UseVisualStyleBackColor = false;
            this.ownersBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // servicesBtn
            // 
            this.servicesBtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.servicesBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.servicesBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.servicesBtn.Location = new System.Drawing.Point(903, 26);
            this.servicesBtn.Name = "servicesBtn";
            this.servicesBtn.Size = new System.Drawing.Size(198, 27);
            this.servicesBtn.TabIndex = 43;
            this.servicesBtn.Text = "Услуги";
            this.servicesBtn.UseVisualStyleBackColor = false;
            this.servicesBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // OwnersServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 531);
            this.Controls.Add(this.servicesBtn);
            this.Controls.Add(this.ownersBtn);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.servicesView);
            this.Controls.Add(this.ownerView);
            this.Controls.Add(this.owner_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.service_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ownersServicesView);
            this.Name = "OwnersServicesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Покупки владельцев";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OwnersServicesForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ownersServicesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ownersServicesView;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox service_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox owner_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ownerView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ofName;
        private System.Windows.Forms.DataGridViewTextBoxColumn olName;
        private System.Windows.Forms.DataGridView servicesView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn osId;
        private System.Windows.Forms.DataGridViewTextBoxColumn oId;
        private System.Windows.Forms.DataGridViewTextBoxColumn sId;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button ownersBtn;
        private System.Windows.Forms.Button servicesBtn;
    }
}
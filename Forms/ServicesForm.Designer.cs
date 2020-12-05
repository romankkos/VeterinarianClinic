
namespace ClinicApp.Forms
{
    partial class ServicesForm
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
            this.service_name = new System.Windows.Forms.TextBox();
            this.prices = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.servicesView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.backButtonmenu = new System.Windows.Forms.Button();
            this.backButtonform = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.servicesView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Услуга";
            // 
            // service_name
            // 
            this.service_name.Location = new System.Drawing.Point(118, 74);
            this.service_name.Name = "service_name";
            this.service_name.Size = new System.Drawing.Size(128, 20);
            this.service_name.TabIndex = 1;
            // 
            // prices
            // 
            this.prices.Location = new System.Drawing.Point(118, 117);
            this.prices.Name = "prices";
            this.prices.Size = new System.Drawing.Size(128, 20);
            this.prices.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Цена";
            // 
            // servicesView
            // 
            this.servicesView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.servicesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.serviceName,
            this.price});
            this.servicesView.Location = new System.Drawing.Point(305, 12);
            this.servicesView.Name = "servicesView";
            this.servicesView.Size = new System.Drawing.Size(344, 343);
            this.servicesView.TabIndex = 4;
            this.servicesView.DoubleClick += new System.EventHandler(this.servicesView_DoubleClick);
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
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.saveButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.saveButton.ForeColor = System.Drawing.SystemColors.Info;
            this.saveButton.Location = new System.Drawing.Point(12, 188);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(97, 27);
            this.saveButton.TabIndex = 23;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.clearButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.clearButton.ForeColor = System.Drawing.SystemColors.Info;
            this.clearButton.Location = new System.Drawing.Point(115, 188);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(94, 27);
            this.clearButton.TabIndex = 24;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.deleteButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.deleteButton.ForeColor = System.Drawing.SystemColors.Info;
            this.deleteButton.Location = new System.Drawing.Point(215, 188);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(84, 27);
            this.deleteButton.TabIndex = 25;
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
            this.backButtonmenu.Size = new System.Drawing.Size(85, 28);
            this.backButtonmenu.TabIndex = 43;
            this.backButtonmenu.Text = "Меню";
            this.backButtonmenu.UseVisualStyleBackColor = false;
            this.backButtonmenu.Click += new System.EventHandler(this.backButtonmenu_Click);
            // 
            // backButtonform
            // 
            this.backButtonform.BackColor = System.Drawing.SystemColors.GrayText;
            this.backButtonform.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.backButtonform.ForeColor = System.Drawing.SystemColors.Info;
            this.backButtonform.Location = new System.Drawing.Point(67, 332);
            this.backButtonform.Name = "backButtonform";
            this.backButtonform.Size = new System.Drawing.Size(189, 27);
            this.backButtonform.TabIndex = 44;
            this.backButtonform.Text = "Владельцы и услуги";
            this.backButtonform.UseVisualStyleBackColor = false;
            this.backButtonform.Click += new System.EventHandler(this.backButtonform_Click);
            // 
            // ServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 371);
            this.Controls.Add(this.backButtonform);
            this.Controls.Add(this.backButtonmenu);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.servicesView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prices);
            this.Controls.Add(this.service_name);
            this.Controls.Add(this.label1);
            this.Name = "ServicesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Услуги";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServicesForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.servicesView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox service_name;
        private System.Windows.Forms.TextBox prices;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView servicesView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button backButtonmenu;
        private System.Windows.Forms.Button backButtonform;
    }
}
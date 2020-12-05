
namespace ClinicApp.Forms
{
    partial class VactinationForm
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
            this.vactination_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.vactinationView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backButtonmenu = new System.Windows.Forms.Button();
            this.avButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vactinationView)).BeginInit();
            this.SuspendLayout();
            // 
            // vactination_name
            // 
            this.vactination_name.Location = new System.Drawing.Point(128, 83);
            this.vactination_name.Name = "vactination_name";
            this.vactination_name.Size = new System.Drawing.Size(128, 20);
            this.vactination_name.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название вакцины";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.deleteButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.deleteButton.ForeColor = System.Drawing.SystemColors.Info;
            this.deleteButton.Location = new System.Drawing.Point(246, 130);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(96, 28);
            this.deleteButton.TabIndex = 31;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.clearButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.clearButton.ForeColor = System.Drawing.SystemColors.Info;
            this.clearButton.Location = new System.Drawing.Point(144, 130);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(96, 28);
            this.clearButton.TabIndex = 30;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.saveButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.saveButton.ForeColor = System.Drawing.SystemColors.Info;
            this.saveButton.Location = new System.Drawing.Point(42, 130);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(96, 28);
            this.saveButton.TabIndex = 29;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // vactinationView
            // 
            this.vactinationView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vactinationView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vactinationView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.vName});
            this.vactinationView.Location = new System.Drawing.Point(368, 44);
            this.vactinationView.Name = "vactinationView";
            this.vactinationView.Size = new System.Drawing.Size(245, 283);
            this.vactinationView.TabIndex = 32;
            this.vactinationView.DoubleClick += new System.EventHandler(this.vactinationView_DoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // vName
            // 
            this.vName.DataPropertyName = "VactinationName";
            this.vName.HeaderText = "Наименование вакцины";
            this.vName.Name = "vName";
            // 
            // backButtonmenu
            // 
            this.backButtonmenu.BackColor = System.Drawing.SystemColors.GrayText;
            this.backButtonmenu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.backButtonmenu.ForeColor = System.Drawing.SystemColors.Info;
            this.backButtonmenu.Location = new System.Drawing.Point(13, 12);
            this.backButtonmenu.Name = "backButtonmenu";
            this.backButtonmenu.Size = new System.Drawing.Size(96, 28);
            this.backButtonmenu.TabIndex = 44;
            this.backButtonmenu.Text = "Меню";
            this.backButtonmenu.UseVisualStyleBackColor = false;
            this.backButtonmenu.Click += new System.EventHandler(this.backButtonmenu_Click);
            // 
            // avButton
            // 
            this.avButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.avButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avButton.ForeColor = System.Drawing.SystemColors.Info;
            this.avButton.Location = new System.Drawing.Point(86, 313);
            this.avButton.Name = "avButton";
            this.avButton.Size = new System.Drawing.Size(154, 28);
            this.avButton.TabIndex = 49;
            this.avButton.Text = "Вакцинация";
            this.avButton.UseVisualStyleBackColor = false;
            this.avButton.Click += new System.EventHandler(this.avButton_Click);
            // 
            // VactinationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 353);
            this.Controls.Add(this.avButton);
            this.Controls.Add(this.backButtonmenu);
            this.Controls.Add(this.vactinationView);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.vactination_name);
            this.Controls.Add(this.label1);
            this.Name = "VactinationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вакцины";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VactinationForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.vactinationView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vactination_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView vactinationView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn vName;
        private System.Windows.Forms.Button backButtonmenu;
        private System.Windows.Forms.Button avButton;
    }
}
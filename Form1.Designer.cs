namespace ManagerProject
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.EmployeeDataGridView = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfEmploymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.DeletePanel = new System.Windows.Forms.Panel();
            this.RemoveComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.EmployeeTabPage = new System.Windows.Forms.TabPage();
            this.CustomerTabPage = new System.Windows.Forms.TabPage();
            this.ProjectTabPage = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SettingsPanel.SuspendLayout();
            this.DeletePanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.EmployeeTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeDataGridView
            // 
            this.EmployeeDataGridView.AllowUserToAddRows = false;
            this.EmployeeDataGridView.AllowUserToDeleteRows = false;
            this.EmployeeDataGridView.AllowUserToResizeColumns = false;
            this.EmployeeDataGridView.AllowUserToResizeRows = false;
            this.EmployeeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeDataGridView.AutoGenerateColumns = false;
            this.EmployeeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dateOfEmploymentDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn});
            this.EmployeeDataGridView.DataSource = this.employeeBindingSource;
            this.EmployeeDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.EmployeeDataGridView.Location = new System.Drawing.Point(3, 262);
            this.EmployeeDataGridView.MinimumSize = new System.Drawing.Size(408, 59);
            this.EmployeeDataGridView.MultiSelect = false;
            this.EmployeeDataGridView.Name = "EmployeeDataGridView";
            this.EmployeeDataGridView.ReadOnly = true;
            this.EmployeeDataGridView.RowHeadersVisible = false;
            this.EmployeeDataGridView.RowTemplate.ReadOnly = true;
            this.EmployeeDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EmployeeDataGridView.ShowCellErrors = false;
            this.EmployeeDataGridView.ShowCellToolTips = false;
            this.EmployeeDataGridView.ShowEditingIcon = false;
            this.EmployeeDataGridView.ShowRowErrors = false;
            this.EmployeeDataGridView.Size = new System.Drawing.Size(681, 334);
            this.EmployeeDataGridView.TabIndex = 7;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfEmploymentDataGridViewTextBoxColumn
            // 
            this.dateOfEmploymentDataGridViewTextBoxColumn.DataPropertyName = "Date_Of_Employment";
            this.dateOfEmploymentDataGridViewTextBoxColumn.HeaderText = "Date_Of_Employment";
            this.dateOfEmploymentDataGridViewTextBoxColumn.Name = "dateOfEmploymentDataGridViewTextBoxColumn";
            this.dateOfEmploymentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(ManagerProject.Employee);
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SettingsPanel.Controls.Add(this.AddEmployeeButton);
            this.SettingsPanel.Controls.Add(this.label4);
            this.SettingsPanel.Controls.Add(this.NameTextBox);
            this.SettingsPanel.Controls.Add(this.EmployeeDateTimePicker);
            this.SettingsPanel.Controls.Add(this.label3);
            this.SettingsPanel.Controls.Add(this.label1);
            this.SettingsPanel.Controls.Add(this.SurnameTextBox);
            this.SettingsPanel.Controls.Add(this.label2);
            this.SettingsPanel.Controls.Add(this.SalaryTextBox);
            this.SettingsPanel.Controls.Add(this.DeletePanel);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsPanel.Location = new System.Drawing.Point(3, 3);
            this.SettingsPanel.MinimumSize = new System.Drawing.Size(408, 260);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(681, 260);
            this.SettingsPanel.TabIndex = 8;
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Location = new System.Drawing.Point(13, 223);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(173, 23);
            this.AddEmployeeButton.TabIndex = 18;
            this.AddEmployeeButton.Text = "Add";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Visible = false;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Salary";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(13, 31);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(174, 20);
            this.NameTextBox.TabIndex = 17;
            this.NameTextBox.Enter += new System.EventHandler(this.NameTextBox_Enter);
            this.NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
            // 
            // EmployeeDateTimePicker
            // 
            this.EmployeeDateTimePicker.Checked = false;
            this.EmployeeDateTimePicker.CustomFormat = "dd:MM:yy  HH:mm";
            this.EmployeeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EmployeeDateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EmployeeDateTimePicker.Location = new System.Drawing.Point(12, 133);
            this.EmployeeDateTimePicker.Name = "EmployeeDateTimePicker";
            this.EmployeeDateTimePicker.Size = new System.Drawing.Size(174, 20);
            this.EmployeeDateTimePicker.TabIndex = 15;
            this.EmployeeDateTimePicker.Value = new System.DateTime(2016, 12, 5, 17, 48, 56, 0);
            this.EmployeeDateTimePicker.Enter += new System.EventHandler(this.EmployeeDateTimePicker_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Surname";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(12, 80);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(174, 20);
            this.SurnameTextBox.TabIndex = 12;
            this.SurnameTextBox.Enter += new System.EventHandler(this.SurnameTextBox_Enter);
            this.SurnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurnameTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name";
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Location = new System.Drawing.Point(13, 185);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(174, 20);
            this.SalaryTextBox.TabIndex = 11;
            this.SalaryTextBox.Enter += new System.EventHandler(this.SalaryTextBox_Enter);
            this.SalaryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SalaryTextBox_KeyPress);
            // 
            // DeletePanel
            // 
            this.DeletePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeletePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeletePanel.Controls.Add(this.RemoveComboBox);
            this.DeletePanel.Controls.Add(this.label5);
            this.DeletePanel.Controls.Add(this.RemoveButton);
            this.DeletePanel.Location = new System.Drawing.Point(475, 0);
            this.DeletePanel.MinimumSize = new System.Drawing.Size(218, 258);
            this.DeletePanel.Name = "DeletePanel";
            this.DeletePanel.Size = new System.Drawing.Size(218, 258);
            this.DeletePanel.TabIndex = 9;
            // 
            // RemoveComboBox
            // 
            this.RemoveComboBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RemoveComboBox.FormattingEnabled = true;
            this.RemoveComboBox.Location = new System.Drawing.Point(23, 26);
            this.RemoveComboBox.Name = "RemoveComboBox";
            this.RemoveComboBox.Size = new System.Drawing.Size(153, 21);
            this.RemoveComboBox.TabIndex = 8;
            this.RemoveComboBox.Tag = "";
            this.RemoveComboBox.SelectedIndexChanged += new System.EventHandler(this.RemoveComboBox_SelectedIndexChanged);
            this.RemoveComboBox.Enter += new System.EventHandler(this.RemoveComboBox_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "EmployeeID";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RemoveButton.Location = new System.Drawing.Point(23, 59);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(153, 23);
            this.RemoveButton.TabIndex = 6;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Visible = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.EmployeeTabPage);
            this.tabControl1.Controls.Add(this.CustomerTabPage);
            this.tabControl1.Controls.Add(this.ProjectTabPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.MinimumSize = new System.Drawing.Size(422, 356);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(695, 631);
            this.tabControl1.TabIndex = 19;
            // 
            // EmployeeTabPage
            // 
            this.EmployeeTabPage.Controls.Add(this.SettingsPanel);
            this.EmployeeTabPage.Controls.Add(this.EmployeeDataGridView);
            this.EmployeeTabPage.Location = new System.Drawing.Point(4, 22);
            this.EmployeeTabPage.Name = "EmployeeTabPage";
            this.EmployeeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeeTabPage.Size = new System.Drawing.Size(687, 605);
            this.EmployeeTabPage.TabIndex = 0;
            this.EmployeeTabPage.Text = "Employees";
            this.EmployeeTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomerTabPage
            // 
            this.CustomerTabPage.Location = new System.Drawing.Point(4, 22);
            this.CustomerTabPage.Name = "CustomerTabPage";
            this.CustomerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CustomerTabPage.Size = new System.Drawing.Size(682, 577);
            this.CustomerTabPage.TabIndex = 1;
            this.CustomerTabPage.Text = "Customers";
            this.CustomerTabPage.UseVisualStyleBackColor = true;
            // 
            // ProjectTabPage
            // 
            this.ProjectTabPage.Location = new System.Drawing.Point(4, 22);
            this.ProjectTabPage.Name = "ProjectTabPage";
            this.ProjectTabPage.Size = new System.Drawing.Size(682, 577);
            this.ProjectTabPage.TabIndex = 2;
            this.ProjectTabPage.Text = "Projects";
            this.ProjectTabPage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 632);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(440, 396);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.DeletePanel.ResumeLayout(false);
            this.DeletePanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.EmployeeTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView EmployeeDataGridView;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.DateTimePicker EmployeeDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SalaryTextBox;
        private System.Windows.Forms.Panel DeletePanel;
        private System.Windows.Forms.ComboBox RemoveComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfEmploymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage EmployeeTabPage;
        private System.Windows.Forms.TabPage CustomerTabPage;
        private System.Windows.Forms.TabPage ProjectTabPage;
    }
}


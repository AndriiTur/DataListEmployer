namespace ManagerProject
{
    partial class MainForm
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
            this.NameEmployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameEmployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfEmployment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaryEmployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditEmployeeButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteEmployeeButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.NameEmployeeTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SurnameEmployeeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SalaryEmployeeTextBox = new System.Windows.Forms.TextBox();
            this.MenegerTabControl = new System.Windows.Forms.TabControl();
            this.EmployeeTabPage = new System.Windows.Forms.TabPage();
            this.CustomerTabPage = new System.Windows.Forms.TabPage();
            this.CustomerDataGridView = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameCustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfAgreement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryCustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CustomerDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddCutomerButton = new System.Windows.Forms.Button();
            this.AgreementDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CustomerSurnameTextBox = new System.Windows.Forms.TextBox();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.ProjectTabPage = new System.Windows.Forms.TabPage();
            this.ProjectDataGridView = new System.Windows.Forms.DataGridView();
            this.ProjectIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectDataColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectCostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectStatusColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ProjectCustomerColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.EmployeeCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditEmployeeInProject = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ProjectEditColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ProjectDeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.ProjectDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddProjectButton = new System.Windows.Forms.Button();
            this.ProjectNameTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ProjectCostTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ProjectCustomerComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SettingsPanel.SuspendLayout();
            this.MenegerTabControl.SuspendLayout();
            this.EmployeeTabPage.SuspendLayout();
            this.CustomerTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.ProjectTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.EmployeeDataGridView.CausesValidation = false;
            this.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.NameEmployeeDataGridViewTextBoxColumn,
            this.SurnameEmployeeDataGridViewTextBoxColumn,
            this.DateOfEmployment,
            this.SalaryEmployeeDataGridViewTextBoxColumn,
            this.EditEmployeeButton,
            this.DeleteEmployeeButton});
            this.EmployeeDataGridView.DataSource = this.employeeBindingSource;
            this.EmployeeDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.EmployeeDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.EmployeeDataGridView.Location = new System.Drawing.Point(3, 173);
            this.EmployeeDataGridView.MinimumSize = new System.Drawing.Size(411, 125);
            this.EmployeeDataGridView.MultiSelect = false;
            this.EmployeeDataGridView.Name = "EmployeeDataGridView";
            this.EmployeeDataGridView.ReadOnly = true;
            this.EmployeeDataGridView.RowHeadersVisible = false;
            this.EmployeeDataGridView.RowTemplate.ReadOnly = true;
            this.EmployeeDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EmployeeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeeDataGridView.ShowCellErrors = false;
            this.EmployeeDataGridView.ShowCellToolTips = false;
            this.EmployeeDataGridView.ShowEditingIcon = false;
            this.EmployeeDataGridView.ShowRowErrors = false;
            this.EmployeeDataGridView.Size = new System.Drawing.Size(660, 259);
            this.EmployeeDataGridView.TabIndex = 7;
            this.EmployeeDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeDataGridView_CellClick);
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.FillWeight = 20F;
            this.employeeIDDataGridViewTextBoxColumn.Frozen = true;
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeIDDataGridViewTextBoxColumn.Width = 75;
            // 
            // NameEmployeeDataGridViewTextBoxColumn
            // 
            this.NameEmployeeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameEmployeeDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.NameEmployeeDataGridViewTextBoxColumn.FillWeight = 27.84817F;
            this.NameEmployeeDataGridViewTextBoxColumn.HeaderText = "Name";
            this.NameEmployeeDataGridViewTextBoxColumn.Name = "NameEmployeeDataGridViewTextBoxColumn";
            this.NameEmployeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SurnameEmployeeDataGridViewTextBoxColumn
            // 
            this.SurnameEmployeeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SurnameEmployeeDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.SurnameEmployeeDataGridViewTextBoxColumn.FillWeight = 27.84817F;
            this.SurnameEmployeeDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.SurnameEmployeeDataGridViewTextBoxColumn.Name = "SurnameEmployeeDataGridViewTextBoxColumn";
            this.SurnameEmployeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DateOfEmployment
            // 
            this.DateOfEmployment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DateOfEmployment.DataPropertyName = "DateOfEmployment";
            this.DateOfEmployment.HeaderText = "Date_Of_Employment";
            this.DateOfEmployment.Name = "DateOfEmployment";
            this.DateOfEmployment.ReadOnly = true;
            this.DateOfEmployment.Width = 135;
            // 
            // SalaryEmployeeDataGridViewTextBoxColumn
            // 
            this.SalaryEmployeeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SalaryEmployeeDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.SalaryEmployeeDataGridViewTextBoxColumn.FillWeight = 27.84817F;
            this.SalaryEmployeeDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.SalaryEmployeeDataGridViewTextBoxColumn.Name = "SalaryEmployeeDataGridViewTextBoxColumn";
            this.SalaryEmployeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EditEmployeeButton
            // 
            this.EditEmployeeButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EditEmployeeButton.FillWeight = 40F;
            this.EditEmployeeButton.HeaderText = "Edit";
            this.EditEmployeeButton.Name = "EditEmployeeButton";
            this.EditEmployeeButton.ReadOnly = true;
            this.EditEmployeeButton.Text = "Edit";
            this.EditEmployeeButton.UseColumnTextForButtonValue = true;
            this.EditEmployeeButton.Width = 40;
            // 
            // DeleteEmployeeButton
            // 
            this.DeleteEmployeeButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DeleteEmployeeButton.FillWeight = 50F;
            this.DeleteEmployeeButton.HeaderText = "Delete";
            this.DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            this.DeleteEmployeeButton.ReadOnly = true;
            this.DeleteEmployeeButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteEmployeeButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DeleteEmployeeButton.Text = "Delete";
            this.DeleteEmployeeButton.UseColumnTextForButtonValue = true;
            this.DeleteEmployeeButton.Width = 50;
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
            this.SettingsPanel.Controls.Add(this.NameEmployeeTextBox);
            this.SettingsPanel.Controls.Add(this.EmployeeDateTimePicker);
            this.SettingsPanel.Controls.Add(this.label3);
            this.SettingsPanel.Controls.Add(this.label1);
            this.SettingsPanel.Controls.Add(this.SurnameEmployeeTextBox);
            this.SettingsPanel.Controls.Add(this.label2);
            this.SettingsPanel.Controls.Add(this.SalaryEmployeeTextBox);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsPanel.Location = new System.Drawing.Point(3, 3);
            this.SettingsPanel.MinimumSize = new System.Drawing.Size(423, 168);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(660, 168);
            this.SettingsPanel.TabIndex = 8;
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Location = new System.Drawing.Point(12, 123);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(393, 23);
            this.AddEmployeeButton.TabIndex = 18;
            this.AddEmployeeButton.Text = "Add";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Visible = false;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Salary";
            // 
            // NameEmployeeTextBox
            // 
            this.NameEmployeeTextBox.Location = new System.Drawing.Point(13, 31);
            this.NameEmployeeTextBox.Name = "NameEmployeeTextBox";
            this.NameEmployeeTextBox.Size = new System.Drawing.Size(174, 20);
            this.NameEmployeeTextBox.TabIndex = 17;
            this.NameEmployeeTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            this.NameEmployeeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
            this.NameEmployeeTextBox.MouseEnter += new System.EventHandler(this.NameTextBox_MouseEnter);
            // 
            // EmployeeDateTimePicker
            // 
            this.EmployeeDateTimePicker.Checked = false;
            this.EmployeeDateTimePicker.CustomFormat = "dd:MM:yy  HH:mm";
            this.EmployeeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EmployeeDateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EmployeeDateTimePicker.Location = new System.Drawing.Point(231, 31);
            this.EmployeeDateTimePicker.Name = "EmployeeDateTimePicker";
            this.EmployeeDateTimePicker.Size = new System.Drawing.Size(174, 20);
            this.EmployeeDateTimePicker.TabIndex = 15;
            this.EmployeeDateTimePicker.Value = new System.DateTime(2016, 12, 5, 17, 48, 56, 0);
            this.EmployeeDateTimePicker.MouseEnter += new System.EventHandler(this.EmployeeDateTimePicker_MouseEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 15);
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
            // SurnameEmployeeTextBox
            // 
            this.SurnameEmployeeTextBox.Location = new System.Drawing.Point(12, 80);
            this.SurnameEmployeeTextBox.Name = "SurnameEmployeeTextBox";
            this.SurnameEmployeeTextBox.Size = new System.Drawing.Size(174, 20);
            this.SurnameEmployeeTextBox.TabIndex = 12;
            this.SurnameEmployeeTextBox.TextChanged += new System.EventHandler(this.SurnameTextBox_TextChanged);
            this.SurnameEmployeeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurnameTextBox_KeyPress);
            this.SurnameEmployeeTextBox.MouseEnter += new System.EventHandler(this.SurnameTextBox_MouseEnter);
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
            // SalaryEmployeeTextBox
            // 
            this.SalaryEmployeeTextBox.Location = new System.Drawing.Point(231, 80);
            this.SalaryEmployeeTextBox.Name = "SalaryEmployeeTextBox";
            this.SalaryEmployeeTextBox.Size = new System.Drawing.Size(174, 20);
            this.SalaryEmployeeTextBox.TabIndex = 11;
            this.SalaryEmployeeTextBox.TextChanged += new System.EventHandler(this.SalaryTextBox_TextChanged);
            this.SalaryEmployeeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SalaryTextBox_KeyPress);
            this.SalaryEmployeeTextBox.MouseEnter += new System.EventHandler(this.SalaryTextBox_MouseEnter);
            // 
            // MenegerTabControl
            // 
            this.MenegerTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenegerTabControl.Controls.Add(this.EmployeeTabPage);
            this.MenegerTabControl.Controls.Add(this.CustomerTabPage);
            this.MenegerTabControl.Controls.Add(this.ProjectTabPage);
            this.MenegerTabControl.Location = new System.Drawing.Point(0, 3);
            this.MenegerTabControl.MinimumSize = new System.Drawing.Size(422, 356);
            this.MenegerTabControl.Name = "MenegerTabControl";
            this.MenegerTabControl.SelectedIndex = 0;
            this.MenegerTabControl.Size = new System.Drawing.Size(674, 463);
            this.MenegerTabControl.TabIndex = 19;
            this.MenegerTabControl.SelectedIndexChanged += new System.EventHandler(this.MenegerTabControl_SelectedIndexChanged);
            // 
            // EmployeeTabPage
            // 
            this.EmployeeTabPage.Controls.Add(this.SettingsPanel);
            this.EmployeeTabPage.Controls.Add(this.EmployeeDataGridView);
            this.EmployeeTabPage.Location = new System.Drawing.Point(4, 22);
            this.EmployeeTabPage.Name = "EmployeeTabPage";
            this.EmployeeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeeTabPage.Size = new System.Drawing.Size(666, 437);
            this.EmployeeTabPage.TabIndex = 0;
            this.EmployeeTabPage.Text = "Employees";
            this.EmployeeTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomerTabPage
            // 
            this.CustomerTabPage.Controls.Add(this.CustomerDataGridView);
            this.CustomerTabPage.Controls.Add(this.panel1);
            this.CustomerTabPage.Location = new System.Drawing.Point(4, 22);
            this.CustomerTabPage.Name = "CustomerTabPage";
            this.CustomerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CustomerTabPage.Size = new System.Drawing.Size(666, 437);
            this.CustomerTabPage.TabIndex = 1;
            this.CustomerTabPage.Text = "Customers";
            this.CustomerTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomerDataGridView
            // 
            this.CustomerDataGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.CustomerDataGridView.AllowUserToAddRows = false;
            this.CustomerDataGridView.AllowUserToDeleteRows = false;
            this.CustomerDataGridView.AllowUserToResizeColumns = false;
            this.CustomerDataGridView.AllowUserToResizeRows = false;
            this.CustomerDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerDataGridView.AutoGenerateColumns = false;
            this.CustomerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.CustomerDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.CustomerDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.NameCustomerDataGridViewTextBoxColumn,
            this.SurnameCustomerDataGridViewTextBoxColumn,
            this.DateOfAgreement,
            this.CountryCustomerDataGridViewTextBoxColumn,
            this.CustomerQuantity,
            this.CustomerMoney,
            this.CustomerEdit,
            this.CustomerDelete});
            this.CustomerDataGridView.DataSource = this.customerBindingSource;
            this.CustomerDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CustomerDataGridView.EnableHeadersVisualStyles = false;
            this.CustomerDataGridView.Location = new System.Drawing.Point(3, 163);
            this.CustomerDataGridView.MinimumSize = new System.Drawing.Size(414, 94);
            this.CustomerDataGridView.MultiSelect = false;
            this.CustomerDataGridView.Name = "CustomerDataGridView";
            this.CustomerDataGridView.ReadOnly = true;
            this.CustomerDataGridView.RowHeadersVisible = false;
            this.CustomerDataGridView.RowTemplate.ReadOnly = true;
            this.CustomerDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CustomerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerDataGridView.ShowCellErrors = false;
            this.CustomerDataGridView.ShowCellToolTips = false;
            this.CustomerDataGridView.ShowEditingIcon = false;
            this.CustomerDataGridView.ShowRowErrors = false;
            this.CustomerDataGridView.Size = new System.Drawing.Size(658, 268);
            this.CustomerDataGridView.StandardTab = true;
            this.CustomerDataGridView.TabIndex = 6;
            this.CustomerDataGridView.TabStop = false;
            this.CustomerDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerDataGridView_CellClick);
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.FillWeight = 20F;
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIDDataGridViewTextBoxColumn.Width = 20;
            // 
            // NameCustomerDataGridViewTextBoxColumn
            // 
            this.NameCustomerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameCustomerDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.NameCustomerDataGridViewTextBoxColumn.FillWeight = 60.65695F;
            this.NameCustomerDataGridViewTextBoxColumn.HeaderText = "Name";
            this.NameCustomerDataGridViewTextBoxColumn.Name = "NameCustomerDataGridViewTextBoxColumn";
            this.NameCustomerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SurnameCustomerDataGridViewTextBoxColumn
            // 
            this.SurnameCustomerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SurnameCustomerDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.SurnameCustomerDataGridViewTextBoxColumn.FillWeight = 60.65695F;
            this.SurnameCustomerDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.SurnameCustomerDataGridViewTextBoxColumn.Name = "SurnameCustomerDataGridViewTextBoxColumn";
            this.SurnameCustomerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DateOfAgreement
            // 
            this.DateOfAgreement.DataPropertyName = "DateOfAgreement";
            this.DateOfAgreement.HeaderText = "DateOfAgreement";
            this.DateOfAgreement.Name = "DateOfAgreement";
            this.DateOfAgreement.ReadOnly = true;
            // 
            // CountryCustomerDataGridViewTextBoxColumn
            // 
            this.CountryCustomerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CountryCustomerDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.CountryCustomerDataGridViewTextBoxColumn.FillWeight = 60.65695F;
            this.CountryCustomerDataGridViewTextBoxColumn.HeaderText = "Country";
            this.CountryCustomerDataGridViewTextBoxColumn.Name = "CountryCustomerDataGridViewTextBoxColumn";
            this.CountryCustomerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CustomerQuantity
            // 
            this.CustomerQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustomerQuantity.FillWeight = 20F;
            this.CustomerQuantity.HeaderText = "ProjectCount";
            this.CustomerQuantity.Name = "CustomerQuantity";
            this.CustomerQuantity.ReadOnly = true;
            this.CustomerQuantity.Width = 91;
            // 
            // CustomerMoney
            // 
            this.CustomerMoney.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerMoney.FillWeight = 40F;
            this.CustomerMoney.HeaderText = "Money";
            this.CustomerMoney.Name = "CustomerMoney";
            this.CustomerMoney.ReadOnly = true;
            // 
            // CustomerEdit
            // 
            this.CustomerEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustomerEdit.FillWeight = 50F;
            this.CustomerEdit.HeaderText = "Edit";
            this.CustomerEdit.Name = "CustomerEdit";
            this.CustomerEdit.ReadOnly = true;
            this.CustomerEdit.Text = "Edit";
            this.CustomerEdit.UseColumnTextForButtonValue = true;
            this.CustomerEdit.Width = 29;
            // 
            // CustomerDelete
            // 
            this.CustomerDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustomerDelete.FillWeight = 60F;
            this.CustomerDelete.HeaderText = "Delete";
            this.CustomerDelete.Name = "CustomerDelete";
            this.CustomerDelete.ReadOnly = true;
            this.CustomerDelete.Text = "Delete";
            this.CustomerDelete.UseColumnTextForButtonValue = true;
            this.CustomerDelete.Width = 42;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(ManagerProject.Customer);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.AddCutomerButton);
            this.panel1.Controls.Add(this.AgreementDateTimePicker);
            this.panel1.Controls.Add(this.CustomerSurnameTextBox);
            this.panel1.Controls.Add(this.CountryTextBox);
            this.panel1.Controls.Add(this.CustomerNameTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.MinimumSize = new System.Drawing.Size(423, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 157);
            this.panel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(221, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "DateAgreement";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Country";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(221, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Surname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Name";
            // 
            // AddCutomerButton
            // 
            this.AddCutomerButton.Location = new System.Drawing.Point(20, 119);
            this.AddCutomerButton.Name = "AddCutomerButton";
            this.AddCutomerButton.Size = new System.Drawing.Size(375, 23);
            this.AddCutomerButton.TabIndex = 2;
            this.AddCutomerButton.Text = "AddCutomer";
            this.AddCutomerButton.UseVisualStyleBackColor = true;
            this.AddCutomerButton.Visible = false;
            this.AddCutomerButton.Click += new System.EventHandler(this.AddCutomerButton_Click);
            // 
            // AgreementDateTimePicker
            // 
            this.AgreementDateTimePicker.CustomFormat = "dd:MM:yy HH:mm";
            this.AgreementDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AgreementDateTimePicker.Location = new System.Drawing.Point(224, 71);
            this.AgreementDateTimePicker.Name = "AgreementDateTimePicker";
            this.AgreementDateTimePicker.Size = new System.Drawing.Size(171, 20);
            this.AgreementDateTimePicker.TabIndex = 5;
            this.AgreementDateTimePicker.Value = new System.DateTime(2016, 12, 6, 23, 32, 0, 0);
            this.AgreementDateTimePicker.MouseEnter += new System.EventHandler(this.AgreementDateTimePicker_MouseEnter);
            // 
            // CustomerSurnameTextBox
            // 
            this.CustomerSurnameTextBox.Location = new System.Drawing.Point(224, 27);
            this.CustomerSurnameTextBox.Name = "CustomerSurnameTextBox";
            this.CustomerSurnameTextBox.Size = new System.Drawing.Size(171, 20);
            this.CustomerSurnameTextBox.TabIndex = 2;
            this.CustomerSurnameTextBox.TextChanged += new System.EventHandler(this.CustomerSurnameTextBox_TextChanged);
            this.CustomerSurnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CuustomerSurnameTextBox_KeyPress);
            this.CustomerSurnameTextBox.MouseEnter += new System.EventHandler(this.CustomerSurnameTextBox_MouseEnter);
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(20, 71);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(171, 20);
            this.CountryTextBox.TabIndex = 3;
            this.CountryTextBox.TextChanged += new System.EventHandler(this.CountryTextBox_TextChanged);
            this.CountryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CountryTextBox_KeyPress);
            this.CountryTextBox.MouseEnter += new System.EventHandler(this.CountryTextBox_MouseEnter);
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Location = new System.Drawing.Point(20, 27);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(171, 20);
            this.CustomerNameTextBox.TabIndex = 1;
            this.CustomerNameTextBox.TextChanged += new System.EventHandler(this.CustomerNameTextBox_TextChanged);
            this.CustomerNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomerNameTextBox_KeyPress);
            this.CustomerNameTextBox.MouseEnter += new System.EventHandler(this.CustomerNameTextBox_MouseEnter);
            // 
            // ProjectTabPage
            // 
            this.ProjectTabPage.Controls.Add(this.ProjectDataGridView);
            this.ProjectTabPage.Controls.Add(this.panel2);
            this.ProjectTabPage.Location = new System.Drawing.Point(4, 22);
            this.ProjectTabPage.Name = "ProjectTabPage";
            this.ProjectTabPage.Size = new System.Drawing.Size(666, 437);
            this.ProjectTabPage.TabIndex = 2;
            this.ProjectTabPage.Text = "Projects";
            this.ProjectTabPage.UseVisualStyleBackColor = true;
            // 
            // ProjectDataGridView
            // 
            this.ProjectDataGridView.AllowDrop = true;
            this.ProjectDataGridView.AllowUserToAddRows = false;
            this.ProjectDataGridView.AllowUserToDeleteRows = false;
            this.ProjectDataGridView.AllowUserToResizeColumns = false;
            this.ProjectDataGridView.AllowUserToResizeRows = false;
            this.ProjectDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectIDColumn,
            this.ProjectNameColumn,
            this.ProjectDataColumn,
            this.ProjectCostColumn,
            this.ProjectStatusColumn,
            this.ProjectCustomerColumn,
            this.EmployeeCountColumn,
            this.EditEmployeeInProject,
            this.ProjectEditColumn,
            this.ProjectDeleteColumn});
            this.ProjectDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ProjectDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.ProjectDataGridView.Location = new System.Drawing.Point(3, 185);
            this.ProjectDataGridView.MultiSelect = false;
            this.ProjectDataGridView.Name = "ProjectDataGridView";
            this.ProjectDataGridView.RowHeadersVisible = false;
            this.ProjectDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ProjectDataGridView.ShowCellErrors = false;
            this.ProjectDataGridView.ShowCellToolTips = false;
            this.ProjectDataGridView.ShowEditingIcon = false;
            this.ProjectDataGridView.ShowRowErrors = false;
            this.ProjectDataGridView.Size = new System.Drawing.Size(663, 249);
            this.ProjectDataGridView.TabIndex = 7;
            this.ProjectDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProjectDataGridView_CellClick);
            // 
            // ProjectIDColumn
            // 
            this.ProjectIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ProjectIDColumn.FillWeight = 30F;
            this.ProjectIDColumn.HeaderText = "ID:";
            this.ProjectIDColumn.Name = "ProjectIDColumn";
            this.ProjectIDColumn.ToolTipText = "ID:";
            this.ProjectIDColumn.Width = 30;
            // 
            // ProjectNameColumn
            // 
            this.ProjectNameColumn.FillWeight = 75.52312F;
            this.ProjectNameColumn.HeaderText = "Name";
            this.ProjectNameColumn.Name = "ProjectNameColumn";
            // 
            // ProjectDataColumn
            // 
            this.ProjectDataColumn.FillWeight = 75.52312F;
            this.ProjectDataColumn.HeaderText = "DataAgrement";
            this.ProjectDataColumn.Name = "ProjectDataColumn";
            // 
            // ProjectCostColumn
            // 
            this.ProjectCostColumn.FillWeight = 75.52312F;
            this.ProjectCostColumn.HeaderText = "Cost";
            this.ProjectCostColumn.Name = "ProjectCostColumn";
            // 
            // ProjectStatusColumn
            // 
            this.ProjectStatusColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProjectStatusColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ProjectStatusColumn.FillWeight = 75.52312F;
            this.ProjectStatusColumn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ProjectStatusColumn.HeaderText = "Status";
            this.ProjectStatusColumn.Name = "ProjectStatusColumn";
            this.ProjectStatusColumn.Width = 43;
            // 
            // ProjectCustomerColumn
            // 
            this.ProjectCustomerColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProjectCustomerColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ProjectCustomerColumn.FillWeight = 75.52312F;
            this.ProjectCustomerColumn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ProjectCustomerColumn.HeaderText = "Customer";
            this.ProjectCustomerColumn.Name = "ProjectCustomerColumn";
            this.ProjectCustomerColumn.Width = 57;
            // 
            // EmployeeCountColumn
            // 
            this.EmployeeCountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.EmployeeCountColumn.FillWeight = 30F;
            this.EmployeeCountColumn.HeaderText = "EmplCount";
            this.EmployeeCountColumn.Name = "EmployeeCountColumn";
            this.EmployeeCountColumn.Width = 83;
            // 
            // EditEmployeeInProject
            // 
            this.EditEmployeeInProject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EditEmployeeInProject.FillWeight = 75F;
            this.EditEmployeeInProject.HeaderText = "EditEmployee";
            this.EditEmployeeInProject.Name = "EditEmployeeInProject";
            this.EditEmployeeInProject.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditEmployeeInProject.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EditEmployeeInProject.Text = "EditEmployee";
            this.EditEmployeeInProject.UseColumnTextForButtonValue = true;
            this.EditEmployeeInProject.Width = 75;
            // 
            // ProjectEditColumn
            // 
            this.ProjectEditColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ProjectEditColumn.FillWeight = 40F;
            this.ProjectEditColumn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ProjectEditColumn.HeaderText = "Edit";
            this.ProjectEditColumn.Name = "ProjectEditColumn";
            this.ProjectEditColumn.ReadOnly = true;
            this.ProjectEditColumn.Text = "Edit";
            this.ProjectEditColumn.UseColumnTextForButtonValue = true;
            this.ProjectEditColumn.Width = 31;
            // 
            // ProjectDeleteColumn
            // 
            this.ProjectDeleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ProjectDeleteColumn.FillWeight = 60F;
            this.ProjectDeleteColumn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ProjectDeleteColumn.HeaderText = "Delete";
            this.ProjectDeleteColumn.Name = "ProjectDeleteColumn";
            this.ProjectDeleteColumn.Text = "Delete";
            this.ProjectDeleteColumn.UseColumnTextForButtonValue = true;
            this.ProjectDeleteColumn.Width = 60;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.ProjectDateTimePicker);
            this.panel2.Controls.Add(this.AddProjectButton);
            this.panel2.Controls.Add(this.ProjectNameTextBox);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.ProjectCostTextBox);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.ProjectCustomerComboBox);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.StatusComboBox);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(666, 179);
            this.panel2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "ProjectName";
            // 
            // ProjectDateTimePicker
            // 
            this.ProjectDateTimePicker.CustomFormat = " dd.MM.yy  HH:mm";
            this.ProjectDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ProjectDateTimePicker.Location = new System.Drawing.Point(16, 69);
            this.ProjectDateTimePicker.Name = "ProjectDateTimePicker";
            this.ProjectDateTimePicker.Size = new System.Drawing.Size(156, 20);
            this.ProjectDateTimePicker.TabIndex = 1;
            this.ProjectDateTimePicker.Value = new System.DateTime(2016, 12, 14, 13, 56, 35, 0);
            // 
            // AddProjectButton
            // 
            this.AddProjectButton.Location = new System.Drawing.Point(16, 140);
            this.AddProjectButton.Name = "AddProjectButton";
            this.AddProjectButton.Size = new System.Drawing.Size(360, 23);
            this.AddProjectButton.TabIndex = 4;
            this.AddProjectButton.Text = "AddProject";
            this.AddProjectButton.UseVisualStyleBackColor = true;
            this.AddProjectButton.Visible = false;
            this.AddProjectButton.Click += new System.EventHandler(this.AddProjectButton_Click);
            // 
            // ProjectNameTextBox
            // 
            this.ProjectNameTextBox.Location = new System.Drawing.Point(16, 28);
            this.ProjectNameTextBox.Name = "ProjectNameTextBox";
            this.ProjectNameTextBox.Size = new System.Drawing.Size(156, 20);
            this.ProjectNameTextBox.TabIndex = 0;
            this.ProjectNameTextBox.TextChanged += new System.EventHandler(this.ProjectNameTextBox_TextChanged);
            this.ProjectNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProjectNameTextBox_KeyPress);
            this.ProjectNameTextBox.MouseEnter += new System.EventHandler(this.ProjectNameTextBox_MouseEnter);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(217, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Status";
            // 
            // ProjectCostTextBox
            // 
            this.ProjectCostTextBox.Location = new System.Drawing.Point(220, 28);
            this.ProjectCostTextBox.Name = "ProjectCostTextBox";
            this.ProjectCostTextBox.Size = new System.Drawing.Size(156, 20);
            this.ProjectCostTextBox.TabIndex = 0;
            this.ProjectCostTextBox.TextChanged += new System.EventHandler(this.ProjectCostTextBox_TextChanged);
            this.ProjectCostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProjectCostTextBox_KeyPress);
            this.ProjectCostTextBox.MouseEnter += new System.EventHandler(this.ProjectCostTextBox_MouseEnter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(217, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Customer";
            // 
            // ProjectCustomerComboBox
            // 
            this.ProjectCustomerComboBox.Location = new System.Drawing.Point(220, 68);
            this.ProjectCustomerComboBox.Name = "ProjectCustomerComboBox";
            this.ProjectCustomerComboBox.Size = new System.Drawing.Size(156, 21);
            this.ProjectCustomerComboBox.TabIndex = 2;
            this.ProjectCustomerComboBox.MouseEnter += new System.EventHandler(this.ProjectCustomerComboBox_MouseEnter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(217, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "ProjectCost";
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(220, 113);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(156, 21);
            this.StatusComboBox.TabIndex = 2;
            this.StatusComboBox.MouseEnter += new System.EventHandler(this.StatusComboBox_MouseEnter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "DateAgrementProject";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 464);
            this.Controls.Add(this.MenegerTabControl);
            this.MinimumSize = new System.Drawing.Size(455, 454);
            this.Name = "MainForm";
            this.Text = "Main_Form";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.MenegerTabControl.ResumeLayout(false);
            this.EmployeeTabPage.ResumeLayout(false);
            this.CustomerTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ProjectTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView EmployeeDataGridView;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameEmployeeTextBox;
        private System.Windows.Forms.DateTimePicker EmployeeDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SurnameEmployeeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SalaryEmployeeTextBox;
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.TabControl MenegerTabControl;
        private System.Windows.Forms.TabPage EmployeeTabPage;
        private System.Windows.Forms.TabPage CustomerTabPage;
        private System.Windows.Forms.TabPage ProjectTabPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView CustomerDataGridView;
        private System.Windows.Forms.DateTimePicker AgreementDateTimePicker;
        private System.Windows.Forms.TextBox CustomerSurnameTextBox;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddCutomerButton;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.TextBox ProjectCostTextBox;
        private System.Windows.Forms.TextBox ProjectNameTextBox;
        private System.Windows.Forms.DateTimePicker ProjectDateTimePicker;
        private System.Windows.Forms.Button AddProjectButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ProjectCustomerComboBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView ProjectDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfEmploymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAgreementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectDataColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectCostColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProjectStatusColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProjectCustomerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeCountColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditEmployeeInProject;
        private System.Windows.Forms.DataGridViewButtonColumn ProjectEditColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ProjectDeleteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameEmployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameEmployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfEmployment;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaryEmployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditEmployeeButton;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteEmployeeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameCustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfAgreement;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryCustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerMoney;
        private System.Windows.Forms.DataGridViewButtonColumn CustomerEdit;
        private System.Windows.Forms.DataGridViewButtonColumn CustomerDelete;
    }
}


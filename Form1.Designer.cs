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
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfEmploymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.MenegerTabControl = new System.Windows.Forms.TabControl();
            this.EmployeeTabPage = new System.Windows.Forms.TabPage();
            this.CustomerTabPage = new System.Windows.Forms.TabPage();
            this.CustomerDataGridView = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAgreementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CustomerDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddCutomerButton = new System.Windows.Forms.Button();
            this.AgreementDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CustomerSurnameTextBox = new System.Windows.Forms.TextBox();
            this.MoneyTextBox = new System.Windows.Forms.TextBox();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.ProjectTabPage = new System.Windows.Forms.TabPage();
            this.ProjectEditButton = new System.Windows.Forms.Button();
            this.DeleteProjectButton = new System.Windows.Forms.Button();
            this.AddProjectButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProjectInfoComboBox = new System.Windows.Forms.ComboBox();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.projestStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProjectCustomerComboBox = new System.Windows.Forms.ComboBox();
            this.ProjectCostTextBox = new System.Windows.Forms.TextBox();
            this.ProjectNameTextBox = new System.Windows.Forms.TextBox();
            this.ProjectDateTimePicker = new System.Windows.Forms.DateTimePicker();
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
            ((System.ComponentModel.ISupportInitialize)(this.projestStatusBindingSource)).BeginInit();
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
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.dateOfEmploymentDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.Edit,
            this.DeleteButton});
            this.EmployeeDataGridView.DataSource = this.employeeBindingSource;
            this.EmployeeDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.EmployeeDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.EmployeeDataGridView.Location = new System.Drawing.Point(3, 262);
            this.EmployeeDataGridView.MinimumSize = new System.Drawing.Size(411, 150);
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
            this.EmployeeDataGridView.Size = new System.Drawing.Size(430, 150);
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
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 26.0761F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.FillWeight = 26.0761F;
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfEmploymentDataGridViewTextBoxColumn
            // 
            this.dateOfEmploymentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateOfEmploymentDataGridViewTextBoxColumn.DataPropertyName = "Date_Of_Employment";
            this.dateOfEmploymentDataGridViewTextBoxColumn.FillWeight = 26.0761F;
            this.dateOfEmploymentDataGridViewTextBoxColumn.HeaderText = "Date_Of_Employment";
            this.dateOfEmploymentDataGridViewTextBoxColumn.Name = "dateOfEmploymentDataGridViewTextBoxColumn";
            this.dateOfEmploymentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.FillWeight = 26.0761F;
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Edit.FillWeight = 40F;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 40;
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DeleteButton.FillWeight = 50F;
            this.DeleteButton.HeaderText = "Delete";
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.ReadOnly = true;
            this.DeleteButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseColumnTextForButtonValue = true;
            this.DeleteButton.Width = 50;
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
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsPanel.Location = new System.Drawing.Point(3, 3);
            this.SettingsPanel.MinimumSize = new System.Drawing.Size(408, 260);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(423, 260);
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
            this.MenegerTabControl.Size = new System.Drawing.Size(437, 414);
            this.MenegerTabControl.TabIndex = 19;
            this.MenegerTabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.MenegerTabControl_Selecting);
            // 
            // EmployeeTabPage
            // 
            this.EmployeeTabPage.Controls.Add(this.SettingsPanel);
            this.EmployeeTabPage.Controls.Add(this.EmployeeDataGridView);
            this.EmployeeTabPage.Location = new System.Drawing.Point(4, 22);
            this.EmployeeTabPage.Name = "EmployeeTabPage";
            this.EmployeeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeeTabPage.Size = new System.Drawing.Size(429, 388);
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
            this.CustomerTabPage.Size = new System.Drawing.Size(429, 388);
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
            this.nameDataGridViewTextBoxColumn1,
            this.surnameDataGridViewTextBoxColumn1,
            this.countryDataGridViewTextBoxColumn,
            this.dateAgreementDataGridViewTextBoxColumn,
            this.moneyDataGridViewTextBoxColumn,
            this.CustomerEdit,
            this.CustomerDelete});
            this.CustomerDataGridView.DataSource = this.customerBindingSource;
            this.CustomerDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CustomerDataGridView.EnableHeadersVisualStyles = false;
            this.CustomerDataGridView.Location = new System.Drawing.Point(3, 200);
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
            this.CustomerDataGridView.Size = new System.Drawing.Size(429, 179);
            this.CustomerDataGridView.StandardTab = true;
            this.CustomerDataGridView.TabIndex = 6;
            this.CustomerDataGridView.TabStop = false;
            this.CustomerDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerDataGridView_CellClick);
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.FillWeight = 60.65695F;
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.FillWeight = 60.65695F;
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn1
            // 
            this.surnameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.surnameDataGridViewTextBoxColumn1.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn1.FillWeight = 60.65695F;
            this.surnameDataGridViewTextBoxColumn1.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn1.Name = "surnameDataGridViewTextBoxColumn1";
            this.surnameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.FillWeight = 60.65695F;
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateAgreementDataGridViewTextBoxColumn
            // 
            this.dateAgreementDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateAgreementDataGridViewTextBoxColumn.DataPropertyName = "DateAgreement";
            this.dateAgreementDataGridViewTextBoxColumn.FillWeight = 60.65695F;
            this.dateAgreementDataGridViewTextBoxColumn.HeaderText = "DateAgreement";
            this.dateAgreementDataGridViewTextBoxColumn.Name = "dateAgreementDataGridViewTextBoxColumn";
            this.dateAgreementDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moneyDataGridViewTextBoxColumn
            // 
            this.moneyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.moneyDataGridViewTextBoxColumn.DataPropertyName = "Money";
            this.moneyDataGridViewTextBoxColumn.FillWeight = 60.65695F;
            this.moneyDataGridViewTextBoxColumn.HeaderText = "Money";
            this.moneyDataGridViewTextBoxColumn.Name = "moneyDataGridViewTextBoxColumn";
            this.moneyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CustomerEdit
            // 
            this.CustomerEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CustomerEdit.FillWeight = 50F;
            this.CustomerEdit.HeaderText = "Edit";
            this.CustomerEdit.Name = "CustomerEdit";
            this.CustomerEdit.ReadOnly = true;
            this.CustomerEdit.Text = "Edit";
            this.CustomerEdit.UseColumnTextForButtonValue = true;
            this.CustomerEdit.Width = 50;
            // 
            // CustomerDelete
            // 
            this.CustomerDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CustomerDelete.FillWeight = 60F;
            this.CustomerDelete.HeaderText = "Delete";
            this.CustomerDelete.Name = "CustomerDelete";
            this.CustomerDelete.ReadOnly = true;
            this.CustomerDelete.Text = "Delete";
            this.CustomerDelete.UseColumnTextForButtonValue = true;
            this.CustomerDelete.Width = 60;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(ManagerProject.Customer);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.AddCutomerButton);
            this.panel1.Controls.Add(this.AgreementDateTimePicker);
            this.panel1.Controls.Add(this.CustomerSurnameTextBox);
            this.panel1.Controls.Add(this.MoneyTextBox);
            this.panel1.Controls.Add(this.CountryTextBox);
            this.panel1.Controls.Add(this.CustomerNameTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.MinimumSize = new System.Drawing.Size(424, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 200);
            this.panel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "DateAgreement";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(221, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Money";
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
            this.AddCutomerButton.Location = new System.Drawing.Point(224, 118);
            this.AddCutomerButton.Name = "AddCutomerButton";
            this.AddCutomerButton.Size = new System.Drawing.Size(171, 23);
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
            this.AgreementDateTimePicker.Location = new System.Drawing.Point(20, 121);
            this.AgreementDateTimePicker.Name = "AgreementDateTimePicker";
            this.AgreementDateTimePicker.Size = new System.Drawing.Size(171, 20);
            this.AgreementDateTimePicker.TabIndex = 5;
            this.AgreementDateTimePicker.Value = new System.DateTime(2016, 12, 6, 23, 32, 0, 0);
            // 
            // CustomerSurnameTextBox
            // 
            this.CustomerSurnameTextBox.Location = new System.Drawing.Point(224, 27);
            this.CustomerSurnameTextBox.Name = "CustomerSurnameTextBox";
            this.CustomerSurnameTextBox.Size = new System.Drawing.Size(171, 20);
            this.CustomerSurnameTextBox.TabIndex = 2;
            this.CustomerSurnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CuustomerSurnameTextBox_KeyPress);
            // 
            // MoneyTextBox
            // 
            this.MoneyTextBox.Location = new System.Drawing.Point(224, 71);
            this.MoneyTextBox.Name = "MoneyTextBox";
            this.MoneyTextBox.Size = new System.Drawing.Size(171, 20);
            this.MoneyTextBox.TabIndex = 4;
            this.MoneyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MoneyTextBox_KeyPress);
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(20, 71);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(171, 20);
            this.CountryTextBox.TabIndex = 3;
            this.CountryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CountryTextBox_KeyPress);
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Location = new System.Drawing.Point(20, 27);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(171, 20);
            this.CustomerNameTextBox.TabIndex = 1;
            this.CustomerNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomerNameTextBox_KeyPress);
            // 
            // ProjectTabPage
            // 
            this.ProjectTabPage.Controls.Add(this.ProjectEditButton);
            this.ProjectTabPage.Controls.Add(this.DeleteProjectButton);
            this.ProjectTabPage.Controls.Add(this.AddProjectButton);
            this.ProjectTabPage.Controls.Add(this.label14);
            this.ProjectTabPage.Controls.Add(this.label15);
            this.ProjectTabPage.Controls.Add(this.label13);
            this.ProjectTabPage.Controls.Add(this.label12);
            this.ProjectTabPage.Controls.Add(this.label11);
            this.ProjectTabPage.Controls.Add(this.label5);
            this.ProjectTabPage.Controls.Add(this.ProjectInfoComboBox);
            this.ProjectTabPage.Controls.Add(this.StatusComboBox);
            this.ProjectTabPage.Controls.Add(this.ProjectCustomerComboBox);
            this.ProjectTabPage.Controls.Add(this.ProjectCostTextBox);
            this.ProjectTabPage.Controls.Add(this.ProjectNameTextBox);
            this.ProjectTabPage.Controls.Add(this.ProjectDateTimePicker);
            this.ProjectTabPage.Location = new System.Drawing.Point(4, 22);
            this.ProjectTabPage.Name = "ProjectTabPage";
            this.ProjectTabPage.Size = new System.Drawing.Size(429, 388);
            this.ProjectTabPage.TabIndex = 2;
            this.ProjectTabPage.Text = "Projects";
            this.ProjectTabPage.UseVisualStyleBackColor = true;
            // 
            // ProjectEditButton
            // 
            this.ProjectEditButton.Location = new System.Drawing.Point(17, 245);
            this.ProjectEditButton.Name = "ProjectEditButton";
            this.ProjectEditButton.Size = new System.Drawing.Size(360, 23);
            this.ProjectEditButton.TabIndex = 4;
            this.ProjectEditButton.Text = "ProjectEdit";
            this.ProjectEditButton.UseVisualStyleBackColor = true;
            this.ProjectEditButton.Visible = false;
            this.ProjectEditButton.Click += new System.EventHandler(this.ProjectEditButton_Click);
            // 
            // DeleteProjectButton
            // 
            this.DeleteProjectButton.Location = new System.Drawing.Point(17, 274);
            this.DeleteProjectButton.Name = "DeleteProjectButton";
            this.DeleteProjectButton.Size = new System.Drawing.Size(360, 23);
            this.DeleteProjectButton.TabIndex = 4;
            this.DeleteProjectButton.Text = "Delete";
            this.DeleteProjectButton.UseVisualStyleBackColor = true;
            this.DeleteProjectButton.Visible = false;
            this.DeleteProjectButton.Click += new System.EventHandler(this.DeleteProjectButton_Click);
            // 
            // AddProjectButton
            // 
            this.AddProjectButton.Location = new System.Drawing.Point(17, 142);
            this.AddProjectButton.Name = "AddProjectButton";
            this.AddProjectButton.Size = new System.Drawing.Size(360, 23);
            this.AddProjectButton.TabIndex = 4;
            this.AddProjectButton.Text = "AddProject";
            this.AddProjectButton.UseVisualStyleBackColor = true;
            this.AddProjectButton.Visible = false;
            this.AddProjectButton.Click += new System.EventHandler(this.AddProjectButton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 177);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "ProjectInfo";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(218, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Status";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(218, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Customer";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(218, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "ProjectCost";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "DateAgrementProject";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "ProjectName";
            // 
            // ProjectInfoComboBox
            // 
            this.ProjectInfoComboBox.FormattingEnabled = true;
            this.ProjectInfoComboBox.Location = new System.Drawing.Point(17, 193);
            this.ProjectInfoComboBox.Name = "ProjectInfoComboBox";
            this.ProjectInfoComboBox.Size = new System.Drawing.Size(360, 21);
            this.ProjectInfoComboBox.TabIndex = 2;
            this.ProjectInfoComboBox.Text = "Choise...";
            this.ProjectInfoComboBox.SelectedIndexChanged += new System.EventHandler(this.ProjectInfoComboBox_SelectedIndexChanged);
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.DataSource = this.projestStatusBindingSource;
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(221, 115);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(156, 21);
            this.StatusComboBox.TabIndex = 2;
            // 
            // projestStatusBindingSource
            // 
            this.projestStatusBindingSource.DataSource = typeof(ManagerProject.Project.ProjestStatus);
            // 
            // ProjectCustomerComboBox
            // 
            this.ProjectCustomerComboBox.Location = new System.Drawing.Point(221, 70);
            this.ProjectCustomerComboBox.Name = "ProjectCustomerComboBox";
            this.ProjectCustomerComboBox.Size = new System.Drawing.Size(156, 21);
            this.ProjectCustomerComboBox.TabIndex = 2;
            this.ProjectCustomerComboBox.Text = "Choise...";
            // 
            // ProjectCostTextBox
            // 
            this.ProjectCostTextBox.Location = new System.Drawing.Point(221, 30);
            this.ProjectCostTextBox.Name = "ProjectCostTextBox";
            this.ProjectCostTextBox.Size = new System.Drawing.Size(156, 20);
            this.ProjectCostTextBox.TabIndex = 0;
            this.ProjectCostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProjectCostTextBox_KeyPress);
            // 
            // ProjectNameTextBox
            // 
            this.ProjectNameTextBox.Location = new System.Drawing.Point(17, 30);
            this.ProjectNameTextBox.Name = "ProjectNameTextBox";
            this.ProjectNameTextBox.Size = new System.Drawing.Size(156, 20);
            this.ProjectNameTextBox.TabIndex = 0;
            this.ProjectNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProjectNameTextBox_KeyPress);
            // 
            // ProjectDateTimePicker
            // 
            this.ProjectDateTimePicker.CustomFormat = " dd.MM.yy  HH:mm";
            this.ProjectDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ProjectDateTimePicker.Location = new System.Drawing.Point(17, 71);
            this.ProjectDateTimePicker.Name = "ProjectDateTimePicker";
            this.ProjectDateTimePicker.Size = new System.Drawing.Size(156, 20);
            this.ProjectDateTimePicker.TabIndex = 1;
            this.ProjectDateTimePicker.Value = new System.DateTime(2016, 12, 14, 13, 56, 35, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 415);
            this.Controls.Add(this.MenegerTabControl);
            this.MinimumSize = new System.Drawing.Size(455, 454);
            this.Name = "Form1";
            this.Text = "Form1";
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
            this.ProjectTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projestStatusBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox MoneyTextBox;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddCutomerButton;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAgreementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn CustomerEdit;
        private System.Windows.Forms.DataGridViewButtonColumn CustomerDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfEmploymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButton;
        private System.Windows.Forms.TextBox ProjectCostTextBox;
        private System.Windows.Forms.TextBox ProjectNameTextBox;
        private System.Windows.Forms.DateTimePicker ProjectDateTimePicker;
        private System.Windows.Forms.Button AddProjectButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ProjectInfoComboBox;
        private System.Windows.Forms.ComboBox ProjectCustomerComboBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.BindingSource projestStatusBindingSource;
        private System.Windows.Forms.Button DeleteProjectButton;
        private System.Windows.Forms.Button ProjectEditButton;
    }
}


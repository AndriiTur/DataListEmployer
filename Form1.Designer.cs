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
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.CustomerEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CustomerDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfEmploymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAgreementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).BeginInit();
            this.SettingsPanel.SuspendLayout();
            this.MenegerTabControl.SuspendLayout();
            this.EmployeeTabPage.SuspendLayout();
            this.CustomerTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
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
            this.EmployeeDataGridView.Size = new System.Drawing.Size(561, 216);
            this.EmployeeDataGridView.TabIndex = 7;
            this.EmployeeDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeDataGridView_CellClick);
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Edit.FillWeight = 40F;
            this.Edit.Frozen = true;
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
            this.DeleteButton.Frozen = true;
            this.DeleteButton.HeaderText = "Delete";
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.ReadOnly = true;
            this.DeleteButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseColumnTextForButtonValue = true;
            this.DeleteButton.Width = 50;
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
            this.SettingsPanel.Size = new System.Drawing.Size(558, 260);
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
            this.MenegerTabControl.Size = new System.Drawing.Size(572, 507);
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
            this.EmployeeTabPage.Size = new System.Drawing.Size(564, 481);
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
            this.CustomerTabPage.Size = new System.Drawing.Size(564, 481);
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
            this.CustomerDataGridView.Size = new System.Drawing.Size(564, 272);
            this.CustomerDataGridView.StandardTab = true;
            this.CustomerDataGridView.TabIndex = 6;
            this.CustomerDataGridView.TabStop = false;
            this.CustomerDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerDataGridView_CellClick);
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
            this.panel1.Size = new System.Drawing.Size(558, 200);
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
            this.ProjectTabPage.Location = new System.Drawing.Point(4, 22);
            this.ProjectTabPage.Name = "ProjectTabPage";
            this.ProjectTabPage.Size = new System.Drawing.Size(564, 481);
            this.ProjectTabPage.TabIndex = 2;
            this.ProjectTabPage.Text = "Projects";
            this.ProjectTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomerEdit
            // 
            this.CustomerEdit.HeaderText = "Edit";
            this.CustomerEdit.Name = "CustomerEdit";
            this.CustomerEdit.ReadOnly = true;
            this.CustomerEdit.Text = "Edit";
            this.CustomerEdit.UseColumnTextForButtonValue = true;
            // 
            // CustomerDelete
            // 
            this.CustomerDelete.HeaderText = "Delete";
            this.CustomerDelete.Name = "CustomerDelete";
            this.CustomerDelete.ReadOnly = true;
            this.CustomerDelete.Text = "Delete";
            this.CustomerDelete.UseColumnTextForButtonValue = true;
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
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 26.0761F;
            this.nameDataGridViewTextBoxColumn.Frozen = true;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 98;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.FillWeight = 26.0761F;
            this.surnameDataGridViewTextBoxColumn.Frozen = true;
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.surnameDataGridViewTextBoxColumn.Width = 99;
            // 
            // dateOfEmploymentDataGridViewTextBoxColumn
            // 
            this.dateOfEmploymentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dateOfEmploymentDataGridViewTextBoxColumn.DataPropertyName = "Date_Of_Employment";
            this.dateOfEmploymentDataGridViewTextBoxColumn.FillWeight = 26.0761F;
            this.dateOfEmploymentDataGridViewTextBoxColumn.Frozen = true;
            this.dateOfEmploymentDataGridViewTextBoxColumn.HeaderText = "Date_Of_Employment";
            this.dateOfEmploymentDataGridViewTextBoxColumn.Name = "dateOfEmploymentDataGridViewTextBoxColumn";
            this.dateOfEmploymentDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfEmploymentDataGridViewTextBoxColumn.Width = 98;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.FillWeight = 26.0761F;
            this.salaryDataGridViewTextBoxColumn.Frozen = true;
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            this.salaryDataGridViewTextBoxColumn.Width = 98;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(ManagerProject.Employee);
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn1
            // 
            this.surnameDataGridViewTextBoxColumn1.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn1.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn1.Name = "surnameDataGridViewTextBoxColumn1";
            this.surnameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateAgreementDataGridViewTextBoxColumn
            // 
            this.dateAgreementDataGridViewTextBoxColumn.DataPropertyName = "DateAgreement";
            this.dateAgreementDataGridViewTextBoxColumn.HeaderText = "DateAgreement";
            this.dateAgreementDataGridViewTextBoxColumn.Name = "dateAgreementDataGridViewTextBoxColumn";
            this.dateAgreementDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moneyDataGridViewTextBoxColumn
            // 
            this.moneyDataGridViewTextBoxColumn.DataPropertyName = "Money";
            this.moneyDataGridViewTextBoxColumn.HeaderText = "Money";
            this.moneyDataGridViewTextBoxColumn.Name = "moneyDataGridViewTextBoxColumn";
            this.moneyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(ManagerProject.Customer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 508);
            this.Controls.Add(this.MenegerTabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).EndInit();
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.MenegerTabControl.ResumeLayout(false);
            this.EmployeeTabPage.ResumeLayout(false);
            this.CustomerTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfEmploymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButton;
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
    }
}


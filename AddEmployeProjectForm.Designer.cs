namespace ManagerProject
{
    partial class AddEmployeProjectForm
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
            this.EmployesInProjectDataGridView = new System.Windows.Forms.DataGridView();
            this.EmployeeIDProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EployeeNameProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeSurnameProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeDeleteButtonProject = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AddEmployeToProjectButton = new System.Windows.Forms.Button();
            this.EmployeesComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmployesInProjectDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployesInProjectDataGridView
            // 
            this.EmployesInProjectDataGridView.AllowUserToAddRows = false;
            this.EmployesInProjectDataGridView.AllowUserToDeleteRows = false;
            this.EmployesInProjectDataGridView.AllowUserToResizeColumns = false;
            this.EmployesInProjectDataGridView.AllowUserToResizeRows = false;
            this.EmployesInProjectDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployesInProjectDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployesInProjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployesInProjectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeIDProject,
            this.EployeeNameProject,
            this.EmployeSurnameProject,
            this.EmployeeDeleteButtonProject});
            this.EmployesInProjectDataGridView.EnableHeadersVisualStyles = false;
            this.EmployesInProjectDataGridView.Location = new System.Drawing.Point(1, 54);
            this.EmployesInProjectDataGridView.Name = "EmployesInProjectDataGridView";
            this.EmployesInProjectDataGridView.RowHeadersVisible = false;
            this.EmployesInProjectDataGridView.Size = new System.Drawing.Size(450, 370);
            this.EmployesInProjectDataGridView.TabIndex = 0;
            this.EmployesInProjectDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployesInProjectDataGridView_CellClick);
            // 
            // EmployeeIDProject
            // 
            this.EmployeeIDProject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EmployeeIDProject.FillWeight = 30F;
            this.EmployeeIDProject.HeaderText = "ID";
            this.EmployeeIDProject.Name = "EmployeeIDProject";
            this.EmployeeIDProject.Width = 30;
            // 
            // EployeeNameProject
            // 
            this.EployeeNameProject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EployeeNameProject.HeaderText = "Name";
            this.EployeeNameProject.Name = "EployeeNameProject";
            // 
            // EmployeSurnameProject
            // 
            this.EmployeSurnameProject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmployeSurnameProject.HeaderText = "Surname";
            this.EmployeSurnameProject.Name = "EmployeSurnameProject";
            // 
            // EmployeeDeleteButtonProject
            // 
            this.EmployeeDeleteButtonProject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmployeeDeleteButtonProject.HeaderText = "Delete";
            this.EmployeeDeleteButtonProject.Name = "EmployeeDeleteButtonProject";
            this.EmployeeDeleteButtonProject.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeDeleteButtonProject.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EmployeeDeleteButtonProject.Text = "Delete";
            this.EmployeeDeleteButtonProject.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AddEmployeToProjectButton);
            this.panel1.Controls.Add(this.EmployeesComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 52);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employees";
            // 
            // AddEmployeToProjectButton
            // 
            this.AddEmployeToProjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddEmployeToProjectButton.Location = new System.Drawing.Point(233, 22);
            this.AddEmployeToProjectButton.Name = "AddEmployeToProjectButton";
            this.AddEmployeToProjectButton.Size = new System.Drawing.Size(205, 23);
            this.AddEmployeToProjectButton.TabIndex = 1;
            this.AddEmployeToProjectButton.Text = "AddEmployeToProject";
            this.AddEmployeToProjectButton.UseVisualStyleBackColor = true;
            this.AddEmployeToProjectButton.Click += new System.EventHandler(this.AddEmployeToProjectButton_Click);
            // 
            // EmployeesComboBox
            // 
            this.EmployeesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EmployeesComboBox.FormattingEnabled = true;
            this.EmployeesComboBox.Location = new System.Drawing.Point(12, 22);
            this.EmployeesComboBox.Name = "EmployeesComboBox";
            this.EmployeesComboBox.Size = new System.Drawing.Size(173, 21);
            this.EmployeesComboBox.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 424);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EmployesInProjectDataGridView);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.EmployesInProjectDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployesInProjectDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddEmployeToProjectButton;
        private System.Windows.Forms.ComboBox EmployeesComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeIDProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn EployeeNameProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeSurnameProject;
        private System.Windows.Forms.DataGridViewButtonColumn EmployeeDeleteButtonProject;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ManagerProject
{
    public partial class Form2 : Form
    {
        public const string PathToFile = "WriteData.xml";
        public const string ExeptionError = "Error";
        public const string XMLNodeManager = "Manager";
        public const string XMLNodeProjects = "Projects";
        public const string XMLNodeProject = "Project";
        public const string XMLProjectAtributeID = "projectID";
        public const string XMLEmployeeProject = "Employee";
        public int projectID;
            
        EmployeeOnProject employeeOnProject;
        public List<EmployeeOnProject> employeesOnProject;
        Form1 mainForm;
        List<string> employeeComboBoxList;
        public Form2()
        {
            InitializeComponent();
            employeeOnProject = new EmployeeOnProject();
            employeesOnProject = new List<EmployeeOnProject>();
            mainForm = new Form1();
            employeeComboBoxList = new List<string>();
            //LoadEmployeesOnProjectToList();
        }

        internal void LoadEmployeesOnProjectToList()
        {
            //projectID = GetProjectID(this.Text);
            if (File.Exists(PathToFile))
            {
                try
                {
                    XmlDocument projectDoc = new XmlDocument();
                    projectDoc.Load(PathToFile);
                    XmlNodeList nodes = projectDoc.ChildNodes;
                    foreach (XmlNode node in nodes)
                    {
                        if (XMLNodeManager == node.Name)
                        {
                            for (XmlNode projectsNode = node.FirstChild; projectsNode != null; projectsNode = projectsNode.NextSibling)
                            {
                                if (XMLNodeProjects == projectsNode.Name)
                                {
                                    for (XmlNode projectNode = projectsNode.FirstChild; projectNode != null; projectNode = projectNode.NextSibling)
                                    {
                                        if ((XMLNodeProject == projectNode.Name) && projectNode.Attributes.GetNamedItem(XMLProjectAtributeID).Value == projectID.ToString())
                                        {
                                            for (XmlNode employeeNode = projectNode.FirstChild; employeeNode != null; employeeNode = employeeNode.NextSibling)
                                            {
                                                var employeeOnProject = new EmployeeOnProject();
                                                if (XMLEmployeeProject == employeeNode.Name)
                                                {
                                                    employeeOnProject.LoadFromNode(employeeNode);
                                                    employeesOnProject.Add(employeeOnProject);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception e) { MessageBox.Show(ExeptionError + e.Message); }
            }
            RefreshForm2();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            employeesOnProject.Clear();
        }

        private void AddEmployeToProjectButton_Click(object sender, EventArgs e)
        {
            string[] words = EmployeesComboBox.Text.Split(' ');
            int employeeID = int.Parse(words[0]);
            string name = words[1];
            string surname = words[2];
            var employeeOnProject = new EmployeeOnProject(projectID, employeeID, name, surname);
            employeesOnProject.Add(employeeOnProject);
            SaveEmployeesOnProject(employeesOnProject);
            RefreshForm2();
        }

        internal void RemovEmployeeFromProject(int employeeIndex)
        {
            employeesOnProject.Remove(employeesOnProject[employeeIndex]);
            SaveEmployeesOnProject(employeesOnProject);
            RefreshForm2();
        }

        private void EmployesInProjectDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == EmployeeDeleteButtonProject.Index && e.RowIndex >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    RemovEmployeeFromProject(e.RowIndex);
                }
                else if (dialogResult == DialogResult.No)
                {
                    EmployesInProjectDataGridView.CurrentCell = null;
                }
            }
        }

        internal void RefreshForm2()
        {
            int row = 0;
            if (EmployeesComboBox.Items.Count > 0)
                EmployeesComboBox.Items.Clear();
            if (EmployesInProjectDataGridView.Rows.Count > 0)
                EmployesInProjectDataGridView.Rows.Clear();
            foreach (var employee in mainForm.employees)
            {
                if (GetEmployee(employee.EmployeeID) == false)
                {
                    EmployeesComboBox.Items.Add(employee.EmployeeID + " " + employee.Name + " " + employee.Surname);
                }
            }
            EmployeesComboBox.Text = "Choise..";
            
            foreach (var employeeOnProject in employeesOnProject)
            {
                //if (GetProjectID(this.Text) == employeeOnProject.ProjectID)
                //{
                    EmployesInProjectDataGridView.Rows.Add();
                    EmployesInProjectDataGridView[EmployeeIDProject.Index, row].Value = employeeOnProject.EmployeeID.ToString();
                    EmployesInProjectDataGridView[EployeeNameProject.Index, row].Value = employeeOnProject.Name.ToString();
                    EmployesInProjectDataGridView[EmployeSurnameProject.Index, row].Value = employeeOnProject.Surname.ToString();
                    row++;
                //}
                
            }
        }
        internal int GetEmployeeIDFromcombobox(string strIn)
        {
            string[] words = strIn.Split(' ');
            return int.Parse(words[0]);
        }
        internal bool GetEmployee(int employeeOnProjectID)
        {
            EmployeeOnProject resultEmployee = new EmployeeOnProject();
            foreach (var employeeOnProject in employeesOnProject)
            {
                if (employeeOnProject.EmployeeID == employeeOnProjectID)
                    return true;
            }
            return false;
        }

        internal int GetProjectID(string strIn)
        {
            foreach (var project in mainForm.projects)
            {
                if (project.Name == strIn)
                    return project.ProjectID;
            }
            return -1;
        }

        internal void SaveEmployeesOnProject(List<EmployeeOnProject> employeesOnProject)
        {
            foreach (var employeeOnProject in employeesOnProject)
                SaveEmployeeOnProject(employeeOnProject);
        }

        internal void SaveEmployeeOnProject(EmployeeOnProject employeeOnProject)
        {
            string projectID = employeeOnProject.ProjectID.ToString();
            string employeeID = employeeOnProject.EmployeeID.ToString();
            string name = employeeOnProject.Name.ToString();
            string surname = employeeOnProject.Surname.ToString();
            bool findnode = true;
            
            try
            {
                XmlDocument projectdocument = new XmlDocument();
                projectdocument.Load(PathToFile);
                XmlNode projectElement = projectdocument.CreateElement("Employee");
                XmlNodeList nodes = projectdocument.ChildNodes;
                foreach (XmlNode node in nodes)
                {
                    if (XMLNodeManager == node.Name)
                    {
                        for (XmlNode projectsNode = node.FirstChild; projectsNode != null; projectsNode = projectsNode.NextSibling)
                        {
                            if (XMLNodeProjects == projectsNode.Name)
                            {
                                for (XmlNode projectNode = projectsNode.FirstChild; projectNode != null; projectNode = projectNode.NextSibling)
                                {
                                    if ((XMLNodeProject == projectNode.Name) && (projectNode.Attributes.GetNamedItem(XMLProjectAtributeID).Value) == projectID)
                                    {
                                        for (XmlNode employeeNode = projectNode.FirstChild; employeeNode != null; employeeNode = employeeNode.NextSibling)
                                        {
                                            if ((XMLEmployeeProject == employeeNode.Name) && (employeeNode.Attributes.GetNamedItem("employeeID").Value) == employeeID)
                                            {
                                                findnode = true;
                                                break;
                                            }
                                            else findnode = false;
                                        }

                                        if (projectNode.FirstChild == null)
                                            findnode = false;
                                        if (findnode == false)
                                        {
                                            projectNode.AppendChild(projectElement);
                                            XmlAttribute ID = projectdocument.CreateAttribute("employeeID");
                                            ID.Value = employeeID;
                                            projectElement.Attributes.Append(ID);
                                            XmlAttribute employeeName = projectdocument.CreateAttribute("name");
                                            employeeName.Value = name;
                                            projectElement.Attributes.Append(employeeName);
                                            XmlAttribute employeeSurname = projectdocument.CreateAttribute("surname");
                                            employeeSurname.Value = surname;
                                            projectElement.Attributes.Append(employeeSurname);
                                            findnode = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                projectdocument.Save(PathToFile);
            }
            catch (Exception e) { MessageBox.Show(ExeptionError + e.Message); }
        }

        public class EmployeeOnProject
        {
            public int ProjectID { get; private set; }
            public int EmployeeID { get; private set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            
            public EmployeeOnProject(int projectID,int emploeeID, string name, string surname)
            {
                this.ProjectID = projectID;
                this.EmployeeID = emploeeID;
                this.Name = name;
                this.Surname = surname;
            }

            public EmployeeOnProject()
            {
                this.ProjectID = 0;
                this.EmployeeID = 0;
                this.Name = "";
                this.Surname = "";
            }

            public void LoadFromNode(XmlNode employeeNode)
            {
                this.ProjectID = int.Parse(employeeNode.ParentNode.Attributes[0].Value);
                this.EmployeeID = int.Parse(employeeNode.Attributes[0].Value);
                this.Name = employeeNode.Attributes[2].Value;
                this.Surname = employeeNode.Attributes[1].Value;
            }
        }

        
    }
}

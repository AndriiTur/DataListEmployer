using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ManagerProject
{
    public class Project : ManagerBase
    {
        public enum ProjestStatus {start, active, suspended, done }

        public const string XmlAtributeEmployeeID = "employeeID";
        public const string XMLNodeProject = "Project";
        public const string XMLNodeAttributeID = "projectID";
        public const string XMLProjectAtributeName = "name";
        public const string XMLProjectAtributeCost = "cost";
        public const string XMLProjectAtributeStatus = "status";
        public const string XMLProjectAtributeCustomer = "customer";
        public const string XMLProjectAtributeDate = "dateAgreement";
        public const string DateFormat = "dd.MM.yyyy HH:mm";
        public const string XMLNodeEmployee = "Employee";
        public const string XMLEmployeeAtributeID = "employeeID";

        public int ProjectID { get; private set; }
        public string Name { get; set; }
        public DateTime DateAgreement { get; private set; }
        public double Cost { get; set; }
        public ProjestStatus Status { get; set; }
        public int CustomerID { get; set; }
        public List<int> EmployeesID{ get; set; }

        public Project(int projectID, string name, DateTime dateAgreement, 
                       double cost, ProjestStatus status , 
                       int customerID,List<int> employees, Manager manager) : base(manager)
        {
            this.ProjectID = projectID;
            this.Name = name;
            this.DateAgreement = dateAgreement;
            this.Cost = cost;
            this.Status = status;
            this.CustomerID = customerID;
            this.EmployeesID = employees;
        }

        public Project(Manager manager) : base(manager)
        {
            this.ProjectID = 1;
            this.Name = "";
            this.DateAgreement = new DateTime { };
            this.Cost = 0;
            this.Status = new ProjestStatus { };
            this.CustomerID = 1;
            this.EmployeesID = new List<int> { };
        }

        public void LoadFromNode(XmlNode projectNode)
        {
            this.ProjectID= int.Parse(projectNode.Attributes.GetNamedItem(XMLNodeAttributeID).Value);
            this.Name = projectNode.Attributes.GetNamedItem(XMLProjectAtributeName).Value;
            this.DateAgreement = DateTime.Parse(projectNode.Attributes.GetNamedItem(XMLProjectAtributeDate).Value);
            this.Cost = double.Parse(projectNode.Attributes.GetNamedItem(XMLProjectAtributeCost).Value);
            this.Status = (ProjestStatus)Enum.Parse(typeof(ProjestStatus), projectNode.Attributes.GetNamedItem(XMLProjectAtributeStatus).Value.ToString());
            this.CustomerID = int.Parse(projectNode.Attributes.GetNamedItem(XMLProjectAtributeCustomer).Value);
            for (XmlNode node = projectNode.FirstChild; node != null; node = node.NextSibling)
                this.EmployeesID.Add(int.Parse(node.Attributes.GetNamedItem(XmlAtributeEmployeeID).Value));
        }

        public void SaveToNode(XmlNode projectNode)
        {
            XmlNodeHelper.SetNodeAtribute(projectNode, XMLNodeAttributeID, this.ProjectID.ToString());
            XmlNodeHelper.SetNodeAtribute(projectNode, XMLProjectAtributeName, this.Name);
            XmlNodeHelper.SetNodeAtribute(projectNode, XMLProjectAtributeDate, this.DateAgreement.ToString(DateFormat));
            XmlNodeHelper.SetNodeAtribute(projectNode, XMLProjectAtributeCost, this.Cost.ToString());
            XmlNodeHelper.SetNodeAtribute(projectNode, XMLProjectAtributeStatus, this.Status.ToString());
            XmlNodeHelper.SetNodeAtribute(projectNode, XMLProjectAtributeCustomer, this.CustomerID.ToString());
            
            for (int i = 0; i < this.EmployeesID.Count; i++)
            {
                XmlNode projectEmployeeNode = XmlNodeHelper.RequiredNode(projectNode, Project.XMLNodeEmployee,
                    Project.XmlAtributeEmployeeID, this.EmployeesID[i].ToString());
            }

            XmlNodeList xmlProjectList = projectNode.SelectNodes(Project.XMLNodeEmployee);
            foreach (XmlNode node in xmlProjectList)
            {
                int employeeInProjectId = int.Parse(node.Attributes.GetNamedItem(Project.XmlAtributeEmployeeID).Value);
                if (this.EmployeesID.IndexOf(employeeInProjectId) < 0)
                {
                    node.ParentNode.RemoveChild(node);
                }
            }
        }
    }
}

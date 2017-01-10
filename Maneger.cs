using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ManagerProject
{
    public class Manager : ManagerBase
    {
        public const string XMLNodeManager = "Manager";
        public const string PathToFile = "WriteData.xml";

        public Employees Employees { get; internal set; }
        public Customers Customers { get; internal set; }
        public Projects Projects { get; internal set; }

        public Manager() : base(null)
        {
            Employees = new Employees(this);
            Customers = new Customers(this);
            Projects = new Projects(this);
        }

        public void LoadFromNode(XmlNode managerNode)
        {
            XmlNode employeesNode = XmlNodeHelper.RequiredNode(managerNode, Employees.XMLNodeEmployees);
            Employees.LoadFromNode(employeesNode);

            XmlNode customersNode = XmlNodeHelper.RequiredNode(managerNode, Customers.XMLNodeCustomers);
            Customers.LoadFromNode(customersNode);

            XmlNode projectsNode = XmlNodeHelper.RequiredNode(managerNode, Projects.XMLNodeProjects);
            Projects.LoadFromNode(projectsNode);
        }

        public void SaveToNode(XmlNode managerNode)
        {
            XmlNode employeesNode = XmlNodeHelper.RequiredNode(managerNode, Employees.XMLNodeEmployees);
            Employees.SaveToNode(employeesNode);

            XmlNode customersNode = XmlNodeHelper.RequiredNode(managerNode, Customers.XMLNodeCustomers);
            Customers.SaveToNode(customersNode);

            XmlNode projectsNode = XmlNodeHelper.RequiredNode(managerNode, Projects.XMLNodeProjects);
            Projects.SaveToNode(projectsNode);
        }
    }
}

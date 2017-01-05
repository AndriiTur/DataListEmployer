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

        public void LoadFromFile(XmlNode managerNode)
        {
            XmlNode employeesNode = XmlNodeHelper.RequiredNode(managerNode, Employees.XMLNodeEmployees);
            Employees.LoadFromFile(employeesNode);

            XmlNode customersNode = XmlNodeHelper.RequiredNode(managerNode, Customers.XMLNodeCustomers);
            Customers.LoadFromFile(customersNode);

            XmlNode projectsNode = XmlNodeHelper.RequiredNode(managerNode, Projects.XMLNodeProjects);
            Projects.LoadFromFile(projectsNode);
        }

        public void SaveToFile(XmlNode managerNode)
        {
            XmlNode employeesNode = XmlNodeHelper.RequiredNode(managerNode, Employees.XMLNodeEmployees);
            Employees.SaveToFile(employeesNode);

            XmlNode customersNode = XmlNodeHelper.RequiredNode(managerNode, Customers.XMLNodeCustomers);
            Customers.SaveToFile(customersNode);

            XmlNode projectsNode = XmlNodeHelper.RequiredNode(managerNode, Projects.XMLNodeProjects);
            Projects.SaveToFile(projectsNode);
        }
    }
}

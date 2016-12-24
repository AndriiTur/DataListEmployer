using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ManagerProject
{
    public class Project
    {
        public enum ProjestStatus {start, active, suspended, done}
        public int ProjectID { get; private set; }
        public string Name { get; set; }
        public DateTime DateAgreement { get; private set; }
        public double Cost { get; set; }
        public ProjestStatus Status { get; set; }
        public int CustomerID { get; set; }

        public Project(int projectID, string name, DateTime dateAgreement, double cost, ProjestStatus status , int customerID)
        {
            this.ProjectID = projectID;
            this.Name = name;
            this.DateAgreement = dateAgreement;
            this.Cost = cost;
            this.Status = status;
            this.CustomerID = customerID;
        }

        public Project()
        {
            this.ProjectID = 1;
            this.Name = "";
            this.DateAgreement = new DateTime { };
            this.Cost = 0;
            this.Status = new ProjestStatus { };
            this.CustomerID = 0;
        }

        public void LoadFromNode(XmlNode projectNode)
        {
            this.ProjectID= int.Parse(projectNode.Attributes[0].Value);
            this.Name = projectNode.Attributes[1].Value;
            this.DateAgreement = DateTime.Parse(projectNode.Attributes[2].Value);
            this.Cost = double.Parse(projectNode.Attributes[3].Value);
            this.Status = (ProjestStatus)Enum.Parse(typeof(ProjestStatus), projectNode.Attributes[4].Value.ToString());
            this.CustomerID = int.Parse(projectNode.Attributes[5].Value);
        }

        public XmlNode LoadToNode(Project project,string pathToFile)
        {
            XmlDocument projectdocument = new XmlDocument();
            projectdocument.Load(pathToFile);
            XmlNode projectElement = projectdocument.CreateElement("Project");
            XmlNodeList nodes = projectdocument.ChildNodes;

            foreach (XmlNode projectsnode in nodes)
            {
                if ("Manager".Equals(projectsnode.Name))
                {
                    for (XmlNode projectnode = projectsnode.FirstChild; projectnode != null; projectnode = projectnode.NextSibling)
                    {
                        if ("Projects".Equals(projectnode.Name))
                        {
                            projectnode.AppendChild(projectElement);
                            XmlAttribute projectID = projectdocument.CreateAttribute("projectID");
                            projectID.Value = project.ProjectID.ToString();
                            projectElement.Attributes.Append(projectID);
                            XmlAttribute name = projectdocument.CreateAttribute("name");
                            name.Value = project.Name;
                            projectElement.Attributes.Append(name);
                            XmlAttribute dateAgreement = projectdocument.CreateAttribute("dateAgreement");
                            dateAgreement.Value = project.DateAgreement.ToString("dd.MM.yyyy HH:mm");
                            projectElement.Attributes.Append(dateAgreement);
                            XmlAttribute cost = projectdocument.CreateAttribute("cost");
                            cost.Value = project.Cost.ToString();
                            projectElement.Attributes.Append(cost);
                            XmlAttribute status = projectdocument.CreateAttribute("status");
                            status.Value = project.Status.ToString();
                            projectElement.Attributes.Append(status);
                            XmlAttribute projectcustID = projectdocument.CreateAttribute("customer");
                            projectcustID.Value = project.CustomerID.ToString();
                            projectElement.Attributes.Append(projectcustID);
                            projectElement = projectElement.NextSibling;
                            projectdocument.Save(pathToFile);
                        }
                    }
                }
            }
            return projectElement;
        }
    }
}

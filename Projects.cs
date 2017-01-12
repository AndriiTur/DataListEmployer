using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ManagerProject
{
    public class Projects : ManagerBase
    {
        public const string XMLNodeProjects = "Projects";

        private List<Project> ListProjects { get; set; }
        public int Count { get { return ListProjects.Count; } }
        public Project this[int index] { get { return ListProjects[index]; } }

        public Projects(Manager manager) : base (manager) 
        {
            ListProjects = new List<Project>();
        }

        public Project GetProjectByID(int projectID)
        {
            foreach (var project in ListProjects)
                if (project.ProjectID == projectID)
                    return project;
            return null;
        }

        public void Add(Project project)
        {
            ListProjects.Add(project);
        }

        public void Remove(Project project)
        {
            ListProjects.Remove(project);
        }

        public int IndexOf(Project project)
        {
            return ListProjects.IndexOf(project); 
        }

        internal void LoadFromNode(XmlNode projectsNode)
        {
            XmlNodeList xmlProjectList = projectsNode.SelectNodes(Project.XMLNodeProject);
            foreach (XmlNode projectNode in xmlProjectList)
            {
                var attributeID = XmlNodeHelper.GetNodeAttribute(projectNode, Project.XMLNodeAttributeID);
                Project project = this.GetProjectByID(int.Parse(attributeID));
                if (project == null)
                {
                    project = new Project(this.Manager);
                    this.Add(project);
                }
                project.LoadFromNode(projectNode);   
            }

            for (int i = this.Count - 1; i >= 0 ; i--)
            {
                var project = this[i];
                string xPath = Project.XMLNodeProject + String.Format("[@{0}='{1}']", Project.XMLNodeAttributeID, project.ProjectID.ToString());
                var res = projectsNode.SelectSingleNode(xPath);
                if (res == null)
                    this.Remove(project);
            }
        }

        internal void SaveToNode(XmlNode projectsNode)
        {
            XmlNodeList xmlProjectList = projectsNode.SelectNodes(Project.XMLNodeProject);
            foreach (XmlNode node in xmlProjectList)
            {
                int projectID = int.Parse(XmlNodeHelper.GetNodeAttribute(node, Project.XMLNodeAttributeID));
                if (this.ListProjects.IndexOf(this.GetProjectByID(projectID)) < 0)
                {
                    node.ParentNode.RemoveChild(node);
                }
            }

            if (this.Count != 0)
            {
                for (var i = 0; i < this.Count; i++)
                {
                    Project project = this[i];
                    XmlNode projectNode = XmlNodeHelper.RequiredNode(projectsNode, Project.XMLNodeProject,
                        Project.XMLNodeAttributeID, project.ProjectID.ToString());
                    project.SaveToNode(projectNode);
                }
            }
            else
                projectsNode = null;
        }
    }
}

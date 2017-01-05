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

        private List<Project> listProjects;

        public int Count { get { return listProjects.Count; } }

        public Projects(Manager manager) : base (manager) 
        {
            listProjects = new List<Project>();
        }

        public Project this[int index] { get { return listProjects[index]; } }

        public Project GetProjectByID(int projectID)
        {
            foreach (var project in listProjects)
                if (project.ProjectID == projectID)
                    return project;
            return null;
        }

        public void Add(Project project)
        {
            listProjects.Add(project);
        }

        public void Remove(Project project)
        {
            listProjects.Remove(project);
        }

        public int IndexOf(Project project)
        {
            return listProjects.IndexOf(project); 
        }

        internal void LoadFromFile(XmlNode projectsNode)
        {
            XmlNodeList xmlProjectList = projectsNode.SelectNodes(Project.XMLNodeProject);
            foreach (XmlNode projectNode in xmlProjectList)
            {
                XmlNode attributeID = projectNode.Attributes.GetNamedItem(Project.XMLNodeAttributeID);
                Project project = this.GetProjectByID(int.Parse(attributeID.Value));
                if (project == null)
                {
                    project = new Project(this.Manager);
                    this.Add(project);
                }
                project.LoadFromNode(projectNode);   
            }

            for (int i = 0; i < this.Count; i++)
            {
                var project = this[i];
                string xPath = Project.XMLNodeProject + String.Format("[@{0}='{1}']", Project.XMLNodeAttributeID, project.ProjectID.ToString());
                var res = projectsNode.SelectSingleNode(xPath);
                if (res == null)
                    this.Remove(project);
            }
        }

        internal void SaveToFile(XmlNode projectsNode)
        {
            for (var i = 0; i < this.Count; i++)
            {
                Project project = this[i];
                XmlNode projectNode = XmlNodeHelper.RequiredNode(projectsNode, Project.XMLNodeProject,
                    Project.XMLNodeAttributeID, project.ProjectID.ToString());                
                project.SaveToNode(projectNode);
            }
        }
    }
}

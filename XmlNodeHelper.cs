using System;
using System.Xml;

namespace ManagerProject
{
    public class XmlNodeHelper
    {
        public static XmlNode RequiredNode(XmlNode parentNode, string xPath, string attribute = "", string value = "")
        {
            string newXPath = xPath;
            if (attribute != "")
                newXPath = newXPath + String.Format("[@{0}='{1}']", attribute, value);
            var res = parentNode.SelectSingleNode(xPath);
            if (res == null)
            {
                res = parentNode.OwnerDocument.CreateElement(xPath);
                if (attribute != "")
                {
                    XmlAttribute xmlAttribute = parentNode.OwnerDocument.CreateAttribute(attribute);
                    xmlAttribute.Value = value;
                    res.Attributes.Append(xmlAttribute);
                }
                parentNode.AppendChild(res);
            }
            return res;
        }

        public static void SetNodeAtribute(XmlNode node,string atributeName,string atributeValue)
        {
            XmlAttribute atribute = node.OwnerDocument.CreateAttribute(atributeName);
            atribute.Value = atributeValue;
            node.Attributes.Append(atribute);
        }
    }
}
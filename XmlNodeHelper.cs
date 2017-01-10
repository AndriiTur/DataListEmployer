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

        public static void SetNodeAtribute(XmlNode node, string atributeName, string value, string defaultValue = "")
        {
            if (node == null)
                return;

            if (value == defaultValue)
                return;

            if (value != "")
            {
                XmlAttribute atribute = node.OwnerDocument.CreateAttribute(atributeName);
                atribute.Value = value;
                node.Attributes.Append(atribute);
            }
        }

        public static void SetNodeAtributeI(XmlNode node, string atributeName, int value, int defaultValue = 0)
        {
            SetNodeAtribute(node, atributeName, value.ToString());
        }

        public static string GetNodeAtribute(XmlNode node, string atributeName, string defaultValue = "")
        {
            if (node == null)
                return defaultValue;

            XmlNode attributeID = node.Attributes.GetNamedItem(Customer.XMLCustomerAtributeID);
            if (attributeID == null)
                return defaultValue;
            return attributeID.Value;
        }

              public static int GetNodeAtributeI(XmlNode node, string atributeName, int defaultValue = 0)
        {
            int intValue;
            string strValue = GetNodeAtribute(node, atributeName, defaultValue.ToString());
            if (int.TryParse(strValue, out intValue))
                return intValue;
            return defaultValue;
        }
    }
}
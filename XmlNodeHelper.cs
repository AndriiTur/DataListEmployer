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
            var res = parentNode.SelectSingleNode(newXPath);
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

        public static void SetNodeAttribute(XmlNode node, string attributeName, string value, string defaultValue = "")
        {
            if (node == null)
                return;

            if (value == defaultValue)
                return;

            if (defaultValue != value)
            {
                XmlAttribute attribute = node.OwnerDocument.CreateAttribute(attributeName);
                attribute.Value = value;
                node.Attributes.Append(attribute);
            }
        }

        public static void SetNodeAttributeI(XmlNode node, string attributeName, int value, int defaultValue = 0)
        {
            int intValue;
            if (int.TryParse(value.ToString(), out intValue))
                SetNodeAttribute(node, attributeName, intValue.ToString());
            else
                defaultValue.ToString();
        }

        public static string GetNodeAttribute(XmlNode node, string attributeName, string defaultValue = "")
        {
            if (node == null)
                return defaultValue;

            XmlNode attribute = node.Attributes.GetNamedItem(attributeName);
            if (attribute == null)
                return defaultValue;
            return attribute.Value;
        }

        public static int GetNodeAttributeI(XmlNode node, string attributeName, int defaultValue = 0)
        {
            int intValue;
            string strValue = GetNodeAttribute(node, attributeName, defaultValue.ToString());
            if (int.TryParse(strValue, out intValue))
                return intValue;
            return defaultValue;
        }
    }
}
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

            XmlAttribute attribute = (XmlAttribute)node.Attributes.GetNamedItem(attributeName);
            if (value == defaultValue)
            {
                if (attribute != null)
                    attribute.ParentNode.RemoveChild(attribute);
            }
            else
            {
                if (attribute == null)
                {
                    attribute = node.OwnerDocument.CreateAttribute(attributeName);
                    node.Attributes.Append(attribute);
                    
                }
                attribute.Value = value;
            }
        }

        public static void SetNodeAttributeI(XmlNode node, string attributeName, int value, int defaultValue = 0)
        {
            SetNodeAttribute(node, attributeName, value.ToString(), defaultValue.ToString());
        }

        public static void SetNodeAttributeDT(XmlNode node, string attributeName, DateTime value, DateTime defaultValue)
        {
            SetNodeAttribute(node, attributeName, value.ToString(), defaultValue.ToString());
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

        public static DateTime GetNodeAttributeDT(XmlNode node, string attributeName, DateTime defaultValue, string dateFormat)
        {
            DateTime dateValue;
            string strValue = GetNodeAttribute(node, attributeName, 
                defaultValue.ToString(dateFormat));
            if (DateTime.TryParse(strValue, out dateValue))
                return dateValue;
            return defaultValue;
        }
        
        public static DateTime GetNodeAttributeDT(XmlNode node, string attributeName, string dateFormat)
        {
            return GetNodeAttributeDT(node, attributeName, new DateTime(), dateFormat);
        }
    }
}
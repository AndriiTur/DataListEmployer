using System;
using System.Xml;

namespace ManagerProject
{
    public class Customer : ManagerBase
    {
        public const string XMLNodeCustomer = "Customer";
        public const string XMLCustomerAtributeID = "customerID";
        public const string XMLCustomerAtributeName = "name";
        public const string XMLCustomerAtributeSurname = "surname";
        public const string XMLCustomerAtributeCountry = "country";
        public const string XMLCustomerAtributeDateAgreement = "dateAgreement";
        public const string DateFormat = "dd.MM.yyyy HH:mm";

        public int CustomerID { get; private set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Country { get; set; }
        public DateTime DateAgreement { get; private set; }
        
        public Customer(int customerID, string name, string surname, string country,
                        DateTime dateAgreement, Manager manager) : base(manager)
        {
            this.CustomerID = customerID;
            this.Name = name;
            this.Surname = surname;
            this.Country = country;
            this.DateAgreement = dateAgreement;
        }

        public Customer(Manager manager) : base(manager)
        {
            this.CustomerID = 1;
            this.Name = "";
            this.Surname = "";
            this.Country = "";
            this.DateAgreement = new DateTime { };
        }

        public void LoadFromNode(XmlNode customerNode)
        {
            this.CustomerID = int.Parse(customerNode.Attributes.GetNamedItem(XMLCustomerAtributeID).Value);
            this.Name = customerNode.Attributes.GetNamedItem(XMLCustomerAtributeName).Value;
            this.Surname = customerNode.Attributes.GetNamedItem(XMLCustomerAtributeSurname).Value;
            this.Country = customerNode.Attributes.GetNamedItem(XMLCustomerAtributeCountry).Value;
            this.DateAgreement = DateTime.Parse(customerNode.Attributes.GetNamedItem(XMLCustomerAtributeDateAgreement).Value);
        }

        public void SaveToNode(XmlNode customerNode)
        {
            XmlNodeHelper.SetNodeAtribute(customerNode, XMLCustomerAtributeID, this.CustomerID.ToString());
            XmlNodeHelper.SetNodeAtribute(customerNode, XMLCustomerAtributeName, this.Name);
            XmlNodeHelper.SetNodeAtribute(customerNode, XMLCustomerAtributeSurname, this.Surname);
            XmlNodeHelper.SetNodeAtribute(customerNode, XMLCustomerAtributeCountry, this.Country);
            XmlNodeHelper.SetNodeAtribute(customerNode, XMLCustomerAtributeDateAgreement, this.DateAgreement.ToString(DateFormat));
        }
    }
}
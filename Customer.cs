﻿using System;
using System.Xml;

namespace ManagerProject
{
    public class Customer : ManagerBase
    {
        public const string XMLNodeCustomer = "Customer";
        public const string XMLCustomerAttributeID = "customerID";
        public const string XMLCustomerAttributeName = "name";
        public const string XMLCustomerAttributeSurname = "surname";
        public const string XMLCustomerAttributeCountry = "country";
        public const string XMLCustomerAttributeDateAgreement = "dateAgreement";
        public const string DateFormat = "dd.MM.yyyy HH:mm";

        public int CustomerID { get; private set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Country { get; set; }
        public DateTime DateOfAgreement { get; private set; }
        
        public Customer(int customerID, string name, string surname, string country,
                        DateTime dateOfAgreement, Manager manager) : base(manager)
        {
            this.CustomerID = customerID;
            this.Name = name;
            this.Surname = surname;
            this.Country = country;
            this.DateOfAgreement = dateOfAgreement;
        }

        public Customer(Manager manager) : base(manager)
        {
            this.CustomerID = 1;
            this.Name = "";
            this.Surname = "";
            this.Country = "";
            this.DateOfAgreement = new DateTime { };
        }

        public void LoadFromNode(XmlNode customerNode)
        {
            this.CustomerID = int.Parse(XmlNodeHelper.GetNodeAttribute(customerNode,XMLCustomerAttributeID));
            this.Name = XmlNodeHelper.GetNodeAttribute(customerNode, XMLCustomerAttributeName);
            this.Surname = XmlNodeHelper.GetNodeAttribute(customerNode, XMLCustomerAttributeSurname); 
            this.Country = XmlNodeHelper.GetNodeAttribute(customerNode, XMLCustomerAttributeCountry);
            this.DateOfAgreement = DateTime.Parse(XmlNodeHelper.GetNodeAttribute(customerNode, XMLCustomerAttributeDateAgreement));
        }

        public void SaveToNode(XmlNode customerNode)
        {
            XmlNodeHelper.SetNodeAttribute(customerNode, XMLCustomerAttributeID, this.CustomerID.ToString());
            XmlNodeHelper.SetNodeAttribute(customerNode, XMLCustomerAttributeName, this.Name);
            XmlNodeHelper.SetNodeAttribute(customerNode, XMLCustomerAttributeSurname, this.Surname);
            XmlNodeHelper.SetNodeAttribute(customerNode, XMLCustomerAttributeCountry, this.Country);
            XmlNodeHelper.SetNodeAttribute(customerNode, XMLCustomerAttributeDateAgreement, this.DateOfAgreement.ToString(DateFormat));
        }
    }
}
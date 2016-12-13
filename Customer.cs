using System;
using System.Xml;

namespace ManagerProject
{
    public class Customer
    {
        public int CustomerID { get; private set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Country { get; set; }
        public DateTime DateAgreement { get; private set; }
        public double Money { get; set; }

        public Customer(int customerID, string name, string surname, string country,
                        DateTime dateAgreement, double money)
        {
            this.CustomerID = customerID;
            this.Name = name;
            this.Surname = surname;
            this.Country = country;
            this.DateAgreement = dateAgreement;
            this.Money = money;
        }

        public Customer()
        {
            this.CustomerID = 1;
            this.Name = "";
            this.Surname = "";
            this.Country = "";
            this.DateAgreement = new DateTime { };
            this.Money = 0;
        }

        public void LoadFromNode(XmlNode customerNode)
        {
            this.CustomerID = int.Parse(customerNode.Attributes[0].Value);
            this.Name = customerNode.Attributes[1].Value;
            this.Surname = customerNode.Attributes[2].Value;
            this.Country = customerNode.Attributes[3].Value;
            this.DateAgreement = DateTime.Parse(customerNode.Attributes[4].Value);
            this.Money = double.Parse(customerNode.Attributes[5].Value);
        }

        public XmlNode LoadToNode(Customer customer)
        {
            XmlDocument customerdocument = new XmlDocument();
            customerdocument.Load("WriteData.xml");
            XmlNode customerElement = customerdocument.CreateElement("customer");
            XmlNodeList nodes = customerdocument.ChildNodes;

            foreach (XmlNode customersnode in nodes)
            {
                if ("Manager".Equals(customersnode.Name))
                {
                    for (XmlNode customernode = customersnode.FirstChild; customernode != null; customernode = customernode.NextSibling)
                    {
                        if ("customers".Equals(customernode.Name))
                        {
                            customernode.AppendChild(customerElement);
                            XmlAttribute customerID = customerdocument.CreateAttribute("customerID");
                            customerID.Value = customer.CustomerID.ToString();
                            customerElement.Attributes.Append(customerID);
                            XmlAttribute name = customerdocument.CreateAttribute("name");
                            name.Value = customer.Name;
                            customerElement.Attributes.Append(name);
                            XmlAttribute surname = customerdocument.CreateAttribute("surname");
                            surname.Value = customer.Surname;
                            customerElement.Attributes.Append(surname);
                            XmlAttribute country = customerdocument.CreateAttribute("country");
                            country.Value = customer.Country;
                            customerElement.Attributes.Append(country);
                            XmlAttribute dateAgreement = customerdocument.CreateAttribute("dateAgreement");
                            dateAgreement.Value = customer.DateAgreement.ToString("dd.MM.yyyy HH:mm");
                            customerElement.Attributes.Append(dateAgreement);
                            XmlAttribute money = customerdocument.CreateAttribute("money");
                            money.Value = customer.Money.ToString();
                            customerElement.Attributes.Append(money);
                            customerElement = customerElement.NextSibling;
                            customerdocument.Save("WriteData.xml");
                        }
                    }
                }
            }
            return customerElement;
        }
    }
}
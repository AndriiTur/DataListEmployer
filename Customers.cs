using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ManagerProject
{
    public class Customers : ManagerBase
    {
        public const string XMLNodeCustomers = "Customers";

        public List<Customer> ListCustomers { get; set; }
        public int Count { get { return ListCustomers.Count; } private set { } }
        public Customer this[int index] { get { return ListCustomers[index]; } }

        public Customers(Manager manager) : base(manager)
        {
            ListCustomers = new List<Customer>();
        }

        public Customer GetCustomerByID(int customerID)
        {
            foreach (var customer in ListCustomers)
                if (customer.CustomerID == customerID)
                    return customer;
            return null;
        }

        public void Add(Customer customer)
        {
            ListCustomers.Add(customer);
        }

        public void Remove(Customer customer)
        {
            ListCustomers.Remove(customer);
        }

        public int IndexOf(Customer customer)
        {
            return ListCustomers.IndexOf(customer);
        }

        internal void LoadFromNode(XmlNode customersNode)
        {
            XmlNodeList xmlCustomerList = customersNode.SelectNodes(Customer.XMLNodeCustomer);
            foreach (XmlNode customerNode in xmlCustomerList)
            {
                var attributeID = XmlNodeHelper.GetNodeAttribute(customerNode, Customer.XMLCustomerAttributeID);
                Customer customer = this.GetCustomerByID(int.Parse(attributeID));
                if (customer == null)
                {
                    customer = new Customer(this.Manager);
                    this.Add(customer);
                }
                customer.LoadFromNode(customerNode);
            }

            for (int i = this.Count - 1; i >= 0; i--)
            {
                var customer = this[i];
                string xPath = Customer.XMLNodeCustomer + String.Format("[@{0}='{1}']", Customer.XMLCustomerAttributeID, customer.CustomerID.ToString());
                var res = customersNode.SelectSingleNode(xPath);
                if (res == null)
                    this.Remove(customer);
            }
        }

        internal void SaveToNode(XmlNode customersNode)
        {
            XmlNodeList xmlCustomerList = customersNode.SelectNodes(Customer.XMLNodeCustomer);
            foreach (XmlNode node in xmlCustomerList)
            {
                int customerID = int.Parse(XmlNodeHelper.GetNodeAttribute(node, Customer.XMLCustomerAttributeID));
                if (this.ListCustomers.IndexOf(this.GetCustomerByID(customerID)) < 0)
                {
                    node.ParentNode.RemoveChild(node);
                }
            }

            if (this.Count != 0)
            {
                for (var i = 0; i < this.Count; i++)
                {
                    Customer customer = this[i];
                    XmlNode customerNode = XmlNodeHelper.RequiredNode(customersNode, Customer.XMLNodeCustomer,
                        Customer.XMLCustomerAttributeID, customer.CustomerID.ToString());
                    customer.SaveToNode(customerNode);
                }
            }
            else
                customersNode = null;

        }
    }
}

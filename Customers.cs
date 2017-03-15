using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public void Clear()
        {
            ListCustomers.Clear();
        }
        public void Remove(Customer customer)
        {
            if (this.CustomerHasProject(customer))
                throw new Exception(string.Format("Cstomer {0}  {1} can't be Deleted, because has project",
                    customer.Name, customer.Surname));
            ListCustomers.Remove(customer);
        }

        private bool CustomerHasProject(Customer customer)
        {
            for (int i = 0; i < customer.Manager.Projects.Count; i++)
            {
                if (Manager.Projects[i].CustomerID == customer.CustomerID)
                    return true;
            }
            return false;
        }

        public int IndexOf(Customer customer)
        {
            return ListCustomers.IndexOf(customer);
        }

        //internal void LoadFromNode(XmlNode customersNode)
        //{
        //    XmlNodeList xmlCustomerList = customersNode.SelectNodes(Customer.XMLNodeCustomer);
        //    foreach (XmlNode customerNode in xmlCustomerList)
        //    {
        //        var attributeID = XmlNodeHelper.GetNodeAttribute(customerNode, Customer.XMLCustomerAttributeID);
        //        Customer customer = this.GetCustomerByID(int.Parse(attributeID));
        //        if (customer == null)
        //        {
        //            customer = new Customer(this.Manager);
        //            this.Add(customer);
        //        }
        //        customer.LoadFromNode(customerNode);
        //    }

        //    for (int i = this.Count - 1; i >= 0; i--)
        //    {
        //        var customer = this[i];
        //        string xPath = Customer.XMLNodeCustomer + String.Format("[@{0}='{1}']", Customer.XMLCustomerAttributeID, customer.CustomerID.ToString());
        //        var res = customersNode.SelectSingleNode(xPath);
        //        if (res == null)
        //            this.Remove(customer);
        //    }
        //}

        //internal void SaveToNode(XmlNode customersNode)
        //{
        //    XmlNodeList xmlCustomerList = customersNode.SelectNodes(Customer.XMLNodeCustomer);
        //    foreach (XmlNode node in xmlCustomerList)
        //    {
        //        int customerID = int.Parse(XmlNodeHelper.GetNodeAttribute(node, Customer.XMLCustomerAttributeID));
        //        if (this.ListCustomers.IndexOf(this.GetCustomerByID(customerID)) < 0)
        //        {
        //            node.ParentNode.RemoveChild(node);
        //        }
        //    }

        //    if (this.Count != 0)
        //    {
        //        for (var i = 0; i < this.Count; i++)
        //        {
        //            Customer customer = this[i];
        //            XmlNode customerNode = XmlNodeHelper.RequiredNode(customersNode, Customer.XMLNodeCustomer,
        //                Customer.XMLCustomerAttributeID, customer.CustomerID.ToString());
        //            customer.SaveToNode(customerNode);
        //        }
        //    }
        //    else
        //        customersNode = null;
        //}

        public void LoadCustomersFromSQL()
        {
            Manager.Customers.Clear();
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\job\projects\ManagerProject\ManagerProject\Manager.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection myConnection = new SqlConnection(con))
            {
                string oString = "Select * from Customers";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        int customerID = int.Parse(oReader["CustomerID"].ToString());
                        string name = oReader["Name"].ToString();
                        string surname = oReader["Surname"].ToString();
                        string country = oReader["Country"].ToString();
                        DateTime dateOfAgreement = DateTime.Parse(oReader["DateOfAgreement"].ToString());
                        var customer = new Customer(customerID, name, surname, country, dateOfAgreement, Manager.Manager);
                        Manager.Customers.Add(customer);
                    }
                    myConnection.Close();
                }
            }
        }

    }
}

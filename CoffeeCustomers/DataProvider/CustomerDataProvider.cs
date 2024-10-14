using CoffeeCustomers.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoffeeCustomers.DataProvider
{
    public class CustomerDataProvider
    {
        private static readonly string _customerFilePath = AppDomain.CurrentDomain.BaseDirectory + "CoffeeCustomers.xml";

        public List<Customer> LoadCustomers()
        {
            List<Customer> customerList = null;

            if (File.Exists(_customerFilePath))
            {
                var xmlSerializer = new XmlSerializer(typeof(List<Customer>));
                using (var reader = new StreamReader(_customerFilePath))
                {
                    customerList = (List<Customer>)xmlSerializer.Deserialize(reader);
                }
            }
            else
            {
                customerList = new List<Customer>
                {
                    new Customer{FirstName = "Thomas", LastName = "Huber", IsDeveloper = true},
                    new Customer{FirstName = "Anna", LastName = "Rockstar", IsDeveloper = true},
                    new Customer{FirstName = "Julia", LastName = "Master"},
                    new Customer{FirstName = "Urs", LastName = "Meier", IsDeveloper = true},
                    new Customer{FirstName = "Sara", LastName = "Ramone"},
                    new Customer{FirstName = "Elsa", LastName = "Queen"},
                    new Customer{FirstName = "Alex", LastName = "Baier", IsDeveloper = true},
                };
            }
            return customerList;
        }

        public void SaveCustomers(IEnumerable<Customer> customers)
        {
 
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Customer>));
            using (var writer = new StreamWriter(_customerFilePath))
            {
                xmlSerializer.Serialize(writer, customers);
                writer.Write(customers);
            }
        }
    }
}

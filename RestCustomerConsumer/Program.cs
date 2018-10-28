using System;
using System.Collections.Generic;
using System.Net.Http;
using ModelClassCustomer.model;
using Newtonsoft.Json;
using ModelClassCustomer.model;
using RestCustomerService.Controllers;

namespace RestCustomerConsumer
{
    class Program
    {
        public IList<Customer> GetCustomers()
        {
            using (HttpClient client = new HttpClient())
            {
                string content = client.GetStringAsync(CustomersUri).Result;
                IList<Customer> cList = JsonConvert.DeserializeObject<IList<Customer>>(content);
                return cList;
            }
        }

        static void Main(string[] args)
        {
         CustomersController customer = new CustomersController();
            customer.Start();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void List(Customer[] customers)
        {

            foreach (var Customer in customers)
            {
                Console.WriteLine(Customer.CustomerId + " " + Customer.Name + " " + Customer.Surname + " " +
                    Customer.Email + " " + Customer.Phone);
            }



        }
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer Added : " + customer.Name +" "+ customer.Surname);
        }
        public void Delete (Customer customer)
        {
            Console.WriteLine("Customer Deleted :" + customer.Name +" "+customer.Surname);
        }
            
       

    
}
}

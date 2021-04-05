using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 1;
            customer1.Name = "Deniz";
            customer1.Surname = "Çevik";
            customer1.Email = "denizcvk@gmail.com";
            customer1.Phone = "5498562134";

            Customer customer2 = new Customer();
            customer2.CustomerId = 2;
            customer2.Name = "Sıla";
            customer2.Surname = "Durak";
            customer2.Email = "sıladrk@gmail.com";
            customer2.Phone = "5863279654";

            Customer customer3 = new Customer();
            customer3.CustomerId = 3;
            customer3.Name = "Hakan";
            customer3.Surname = "Aslan";
            customer3.Email = "aslanhkn@hotmail.com";
            customer3.Phone = "5863147563";

            Customer customer4 = new Customer();
            customer4.CustomerId = 4;
            customer4.Name = "Şükran";
            customer4.Surname = "Şahin";
            customer4.Email = "sukransahin@hotmail.com";
            customer4.Phone = "5863112475";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);
            customerManager.Delete(customer2);
            


            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };
            customerManager.List(customers);

            Console.ReadLine();

        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

      //  1.	Write a function called GetCustomers that returns a List of all customers from the database.Test it from main().
//2.	Write a function called GetCustomerNames that returns a List<string> which is the full name of each customer in the database.Test it from main().
// 3.	Write a function called GetTopNCustomersSortedByLastName that returns the top N customers sorted by last name, then sorted by first name.Test it from main().

        static void Main(string[] args)
        {
            // var db = new AdventureWorksEntities();

            /*
            var customers = GetCustomers();
            
            foreach(var customer in customers)
            {
                Console.WriteLine(customer.FirstName + "" + customer.LastName);
            }

            Console.ReadLine();
            */

            var names = GetCustomerNames();
            names.ForEach(x => Console.WriteLine(x));

            Console.ReadLine();


        }

        public static List<Customer> GetCustomers()
        {
            using (var db = new AdventureWorksEntities())
            {
                return db.Customers.ToList();
            }

        }

        public static List<string> GetCustomerNames()
        {
            using(var db = new AdventureWorksEntities())
            {
                return db.Customers.Select(x => x.FirstName + "" + x.LastName).ToList();
            }
        }

        /*
        public static List<Customer> GetTopNCustomersSortedByLastName(int n)
        {

        }

    */

    }
}

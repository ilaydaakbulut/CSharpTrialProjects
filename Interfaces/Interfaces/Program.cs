using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "ilayda",
                LastName = "akbulut",
                Address = "Istanbul"
            };
            Student student = new Student
            {
                Id = 1,
                FirstName = "ilayda",
                LastName = "akbulut",
                Departmant = "Computer sciences"
            };
            manager.Add(customer);
            */
            /*
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlOracleCustomerDal());
            
            */
            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleServerCustomerDal()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            Console.ReadLine();
        }
    }
    interface Iperson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : Iperson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

    }
    class Student:Iperson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
    class PersonManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName);
        }
    }
}

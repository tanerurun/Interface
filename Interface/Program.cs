using System;
using Interface;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerDal[] customerDal = new ICustomerDal[2]
            {
                new SqlCustomerDal(),
                new OracleCustomerDal()
            };
            customerManager customerManager =new customerManager();
            customerManager.add(new SqlCustomerDal());
             
            PersonManager personManager = new PersonManager();
            personManager.add(new Customer { id = 1, firstName = "Taner", lastName = "ürün" });


            Customer customer = new Customer();
            customer.firstName = "Haşim";
            personManager.add(customer);

           
          

            

            Console.ReadLine();

        }
    }


    interface IPerson //soyut
    {
        int id { get; set; }
        string firstName { get; set; }
        string lastName { get; set; }
    }
    class Customer : IPerson
    //somut Customer
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
    //somut student
    class Student : IPerson
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }

    class PersonManager
    {
        public void add(Customer customer)
        {
            Console.WriteLine(customer.firstName);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    //Dal>data access layer
  public  interface ICustomerDal
    {
        void add();
        void update();
        void delete();
        //3 adet oparasyon
    }
    class SqlCustomerDal : ICustomerDal
    {
        public void add()
        {
            Console.WriteLine("Sql added");
        }

        public void delete()
        {
            Console.WriteLine("sql delete");
        }

        public void update()
        {
            Console.WriteLine("sql update");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void add()
        {
            Console.WriteLine("oracle add");
        }

        public void delete()
        {
            Console.WriteLine("oracle delete");
        }

        public void update()
        {
            Console.WriteLine("Oracle update");
        }
    }

  public  class customerManager
    {
        public void add(ICustomerDal customerDal)
        {
            customerDal.add();
        }
    }
}

using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer = new IndividualCustomer();
            customer.CustomerNo = "12345";
            customer.CustomerName = "Etibar";
            customer.CustomerSurname = "Yunusov";


            LegalCustomer customer1 = new LegalCustomer();
            customer1.CompanyName = "Veyseloglu";
            customer1.CustomerNo = "54321";

            Customer customer2 = new IndividualCustomer();
            Customer customer3 = new LegalCustomer();

            CustomerManager manager = new CustomerManager();
        }
    }
}

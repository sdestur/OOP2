using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.CustomerId = 1;
            customer1.CustomerNumber = "2055";
            customer1.CustomerName = "Ayaz";
            customer1.CustomerSurName = "Destur";
            customer1.CitizenshipNumber = "123";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.CustomerId= 2;    
            customer2.CustomerNumber = "1020";
            customer2.CompanyName = ".Core";
            customer2.VergiNumber = "321";

            Customer customer3 = new CorporateCustomer();
            Customer customer4 = new IndividualCustomer();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Greeting.ConsoleApp
{
    public class CustomConsole
    {
        public void PrintMainMenu()
        {
            Console.WriteLine("1. Add Customer to Database \n 2. See Customers in Database \n 3. Update Customer Information \n 4. Delete a Customer \n 5. Exit");
        }
        public string GetUserInput()
        {
            return Console.ReadLine();
        }

        public void EnterAFirstName()
        {
            Console.WriteLine("Enter the first name: \n");
        }

        public void EnterALastName()
        {
            Console.WriteLine("Enter the last name \n");
        }

        public void SelectCustomerType()
        {
            Console.WriteLine("Is the customer: 1. Current \n 2. Past \n 3. Potential \n");
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Greeting.Repository;

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

        public void PrintCustomer(Customer customer)
        {
            Console.WriteLine($"First name: {customer.FirstName} \n Last name: {customer.LastName} \n Type of customer: {customer.CustomerType} \n Email message: {customer.Email}");
        }

        public void PrintCustomers(List<Customer> customer)
        {
            foreach (Customer x in customer)
            {
                PrintCustomer(x);
            }
        }

        public void PressAnyKeyToContinue()
        {
            Console.WriteLine("Press any key to continue...\n");
            Console.ReadKey();
        }

        public void SelectACustomerToEdit()
        {
            Console.WriteLine("Enter the first name of the customer you would like to edit: \n");
        }

        public void EnterACustomerFirstNameToDelete()
        {
            Console.WriteLine("Enter the first name of the customer you would like to delete: \n");
        }

        public void CustomerSuccessfullyDeleted(Customer deletedCustomer)
        {
            Console.WriteLine($"{deletedCustomer.FirstName} successfully deleted.");
        }

        public void SomethingWentWrong()
        {
            Console.WriteLine("Something went wrong...");
        }

        public void CustomerNotFound()
        {
            Console.WriteLine("Customer Not Found. Press any key to continue...");
            Console.ReadKey();
        }

        public void ExitMessage()
        {
            Console.WriteLine("Adios muchachos");
        }
    }
}
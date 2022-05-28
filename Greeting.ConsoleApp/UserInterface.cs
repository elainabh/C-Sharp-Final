using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Greeting.Repository;

namespace Greeting.ConsoleApp
{
    public class UserInterface
    {
        GreetingRepository _repo = new GreetingRepository();
        CustomConsole _console = new CustomConsole();

        bool isRunning = true; // use this in your While Loop.

        public void Run()
        {
            _repo.SeedCustomerData();
            
            while(isRunning)
            {
                _console.PrintMainMenu();
                string userInput = _console.GetUserInput();
                
                UserInputPortal(userInput);

            }
        }

        private void UserInputPortal(string inputFromUser)
        {
            switch(inputFromUser)
            {
                case "1":
                CreateNewCustomer();
                break;
                case "2":
                ViewAllCustomers();
                break;
                case "3": 
                UpdateCustomerInfo();
                break;
                case "4":
                // DeleteACustomer();
                break;
                case "5":
                // ExitApp();
                break;

            }
        }

        private void CreateNewCustomer()
        {
            _console.EnterAFirstName();
            string firstName = _console.GetUserInput();

            _console.EnterALastName();
            string lastName = _console.GetUserInput();

            _console.SelectCustomerType();

            string customerTypeSelection = _console.GetUserInput().ToLower();

            string customerType = CustomerTypeSelection(customerTypeSelection);

            string customerEmail = _repo.GetEmailByType(customerType);
            
            //Constructor
            
            CustomerType typeOfCustomer = Enum.Parse<CustomerType>(customerType);

            Customer newCustomer = new Customer(firstName, lastName, typeOfCustomer, customerEmail);

            _repo.AddCustomerToDatabase(newCustomer);

        }

        private string CustomerTypeSelection(string userTypeInput)
        {
            switch(userTypeInput)
            {
                case "1":
                return CustomerType.Current.ToString();
                case "2":
                return CustomerType.Past.ToString();
                case "3":
                return CustomerType.Potential.ToString();
                default: 
                return null;
            }
        }

        //RUN method, seed data, and enter a WHILE Loop. Get user input based off of the Main Menu Options. Invoke the SwitchCasePortal.

        //Get the user's choice for a CRUD option
        //Switch case portal

        // Print a Main Menu

        //CREATE
        //Ask the customer for input - 

        //READ

        private void ViewAllCustomers()
        {
            List<Customer> allCustomers = _repo.GetAllCustomerInfoAndEmails();
            allCustomers = allCustomers.OrderBy(o=>o.LastName).ToList();
            _console.PrintCustomers(allCustomers);
            _console.PressAnyKeyToContinue();

        }

        //UPDATE A CUSTOMER

        private void UpdateCustomerInfo()
        {
            string name = _console.GetUserInput();
            Customer customer = _repo.GetCustomerByFirstName(name);
                _console.SelectACustomerToEdit(name);
                _repo.GetCustomerByFirstName(name);


            if (name != null)
            {
                // PrintName(name);

                Console.WriteLine("\n NEW first name: ");
                string newFirstName = _console.GetUserInput();


                Console.WriteLine("\n NEW last name: ");
                string newLastName = _console.GetUserInput();


                _console.SelectCustomerType();
                string newCustomerType = _console.GetUserInput().ToLower();

                string customerTypeNew = CustomerTypeSelection(newCustomerType);

                string customerEmail = _repo.GetEmailByType(customerTypeNew);


                CustomerType typeOfUpdatedCustomer = Enum.Parse<CustomerType>(customerTypeNew);

                Customer updatedCustomer = new Customer(newFirstName, newLastName, typeOfUpdatedCustomer, customerEmail);

            }
            else
            {
                Console.WriteLine("Customer Not Found. Press any key to continue...");
                Console.ReadKey();
            }

        }

    }
}
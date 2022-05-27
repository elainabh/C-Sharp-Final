using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Greeting.Repository
{
    public class GreetingRepository
    {
        //fake DB
        List<Customer> _emailDB = new List<Customer>();

        //fields
        string currentCustomerEmail = "Thank you for your work with us. We appreciate your loyalty. Here's a coupon.";

        string pastCustomerEmail = "It's been a long time since we've heard from you, pretty please come back to us.";

        string potentialCustomerEmail = "Yoooo we currently have the lowest rates on Helicopter Insurance! Come to us for your choppa needs.";

        private string GetCustomerEmailMessage(CustomerType customerType)
        {
            switch(customerType)
            {
                case CustomerType.Current:
                return currentCustomerEmail;
                case CustomerType.Past:
                return pastCustomerEmail;
                default:
                return potentialCustomerEmail;
            }
        }

        //Create

        public void AddCustomerToDatabase (Customer customer)
        {
            _emailDB.Add(customer);
        
        }

        public string GetEmailByType (string customerType)
        {

            if(customerType.ToString() == CustomerType.Current.ToString())
            {
                return currentCustomerEmail;
            }
            else if(customerType.ToString() == CustomerType.Past.ToString())
            {
                return pastCustomerEmail;
            }
            else if(customerType.ToString() == CustomerType.Potential.ToString())
            {
                return potentialCustomerEmail;
            }
            else
            {
                return null;
            }

        }

        //Read
        public List<Customer> GetAllCustomerInfoAndEmails()
        {
            return _emailDB;
        }

        public Customer GetCustomerByFirstName(string Name)
        {
            foreach (Customer x in _emailDB)
            {
                if (Name.ToUpper() == x.FirstName.ToUpper())
                {
                    return x;
                }
            }
            return null;
        }

        //Update
        public void SeedCustomerData()
        {
            Customer EricShafer = new Customer("Eric", "Shafer", CustomerType.Current, GetCustomerEmailMessage(CustomerType.Current));
            Customer CindyLong = new Customer("Cindy", "Long", CustomerType.Past, "It's been a long time since we've heard from you, pretty please come back to us.");
            Customer LawrenceFenderman = new Customer("Lawrence", "Fenderman", CustomerType.Potential, "Yoooo we currently have the lowest rates on Helicopter Insurance! Come to us for your choppa needs.");

            Customer[] customerArr = { EricShafer, CindyLong, LawrenceFenderman };

            foreach (Customer customer in customerArr)
            {
                AddCustomerToDatabase(customer);
            }
        }

        //Delete

        public bool DeleteCustomerFromDatabse(Customer customer)
        {
            int totalCustomersInDB = _emailDB.Count();
            
            _emailDB.Remove(customer);

            if(totalCustomersInDB == _emailDB.Count())
            {
                return false;
            }
            return true;

        }
        


    }
}
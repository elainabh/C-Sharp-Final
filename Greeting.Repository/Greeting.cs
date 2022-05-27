using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Greeting.Repository
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public CustomerType CustomerType {get; set;}


        public Customer(string firstName, string lastName, CustomerType customerType, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            CustomerType = customerType; 
        }
    }

    public enum CustomerType { Current, Potential, Past }

}
using Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Services
{
    public class BankServices
    {
        //Create connection to the database
        //Create new customer
        //Add customer to the database
        //save the database

        public bool CreateCustomer(int id, string firstName, string lastName)
        {
            using(var context = new BankAtmEntities())
            {
                var newCustomer = new Customer
                {
                    CustomerID = id,
                    FirstName = firstName,
                    LastName = lastName
                };
                context.Customers.Add(newCustomer);

                return context.SaveChanges() == 1;
            }
        }

    }
}

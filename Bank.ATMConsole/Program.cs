using Bank.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.ATMConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankServices customer = new BankServices();
            customer.CreateCustomer(3, "Gavin", "Williams");
        }
    }
}

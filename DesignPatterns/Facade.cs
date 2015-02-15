using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns
{
    public class Customer : ICustomer
    {
        public Customer(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
    }

    public interface ICustomer
    {
        string Name { get; set; }
    }

    class Bank
    {
        public bool HasSufficientFunds(ICustomer cust)
        {
            Console.WriteLine("Check funds for " + cust.Name + ".");
            return true;
        }
    }

    class Credit
    {
        public bool HasSufficientCredit(ICustomer cust)
        {
            Console.WriteLine("Check credit for " + cust.Name + "." );
            return true;
        }
    }
    public class MortageFacade
    {
        private Bank bank = new Bank();
        private Credit credit = new Credit();

        public bool IsEligible(ICustomer cust, int amount)
        {
            Console.WriteLine("Customer " + cust.Name + " is applying for loan worth " + amount.ToString() + " euro.");
            bool eligible = true;
            if(!bank.HasSufficientFunds(cust)) eligible = false;
            if(!credit.HasSufficientCredit(cust)) eligible = false;
            return eligible;
        }
    }


}

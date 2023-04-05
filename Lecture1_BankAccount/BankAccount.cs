using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1_BankAccount
{
    public class BankAccount
    {
        // Fields - fields have lowercased first letter
        float balance;


        // Properties - properties have uppercased first letter
        public float Balance   
        {
            get { return balance; }
            set { balance = value; }
        }


        // Methods
        public void Debit(float debitAmount)  // takes in a debit amount and subtracts from 'balance' 
        {
            balance -= debitAmount;
        }
    }
}

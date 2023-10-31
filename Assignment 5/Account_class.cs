using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class Account
    {
        int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        string? accountType;
        public string? AccountType
        {
            get
            {
                return accountType;
            }
            set
            {
                accountType = value;
            }
        }
        double balance;
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }

        public bool Withdraw(int amount)
        {
            if (balance < amount)
            {
                return false;
            }
            return true;
        }

        public string GetDetails()
        {
            string message = "";
            message += $"Account Id : {id}";
            message += $"Account Type: {accountType}";
            message += $"Balance: {balance}";
            return message;
        }
    }
}

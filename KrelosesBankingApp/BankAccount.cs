using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrelosesBankingApp
{
    public class BankAccount
    {
        private List<BankTransaction> bankTransactions;
        public decimal BankBalance
        {
            get
            {
                return bankTransactions.Sum(transaction => transaction.Amount);
            }
        }

        public BankAccount()
        {
            bankTransactions = new List<BankTransaction>();
        }

        public void DepositAmount(decimal _amount)
        {
            if(_amount <= 0)
            {
                Console.WriteLine("Amount must be greater then Zero");
                return;
            }
            var transaction = new BankTransaction(_amount);
            bankTransactions.Add(transaction);
            Console.WriteLine("Amount Successfully Deposited in your Account..");
        }

        public void WithDrawAmount(decimal _amount)
        {
            if (_amount <= 0)
            {
                Console.WriteLine("Amount must be greater then Zero");
                return;
            }
            if(_amount > BankBalance)
            {
                Console.WriteLine("Sorry.. Insufficient Fund Request");
                return;
            }
            var transaction = new BankTransaction(_amount*-1);
            bankTransactions.Add(transaction);
            Console.WriteLine(_amount + " Withdrawn from your Account..");
        }
    }
}

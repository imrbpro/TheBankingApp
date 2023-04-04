using KrelosesBankingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrelosesBankingApp
{
    public class BankTransaction
    {
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public BankTransaction(decimal _amount)
        {
            Amount = _amount;
            TransactionDate = DateTime.Now;
        }
    }
}

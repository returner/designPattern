using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Command.Example
{
    public class TransactionManager
    {
        private readonly List<ITransaction> _transactions = new List<ITransaction>();

        public bool HasPendingTransactions
        {
            get {  return _transactions.Any(x => !x.IsCompleted); }
        }

        public void AddTransaction(ITransaction transaction)
        {
            _transactions.Add(transaction);
        }

        public void ProcessPendingTransaction()
        {
            foreach (var transaction in _transactions.Where(d => !d.IsCompleted))
            {
                transaction.Execute();
            }
        }
    }
}

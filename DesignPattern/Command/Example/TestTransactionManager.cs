using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Command.Example
{
    [TestClass]
    public class TestTransactionManager
    {
        [TestMethod]
        public void Test_AllTransactionSuccessful()
        {
            var transactionManager = new TransactionManager();
            var suesAccount = new Account("Sue Smith", 0);
            var deposit = new Deposit(suesAccount, 100);
            transactionManager.AddTransaction(deposit);

            Assert.IsTrue(transactionManager.HasPendingTransactions);
            Assert.AreEqual(0, suesAccount.Balance);

            transactionManager.ProcessPendingTransaction();
            Assert.IsFalse(transactionManager.HasPendingTransactions);
            Assert.AreEqual(100, suesAccount.Balance);

            var withdraw = new Withdraw(suesAccount, 50);
            transactionManager.AddTransaction(withdraw);

            transactionManager.ProcessPendingTransaction();
            Assert.IsFalse(transactionManager.HasPendingTransactions);
            Assert.AreEqual(50, suesAccount.Balance);

            var aAccount = new Account("Aaa", 10);
            var bAccount = new Account("Bbb", 20);
            var transfer = new Transfer(aAccount, bAccount, 5);
            transactionManager.AddTransaction(transfer);
            transactionManager.ProcessPendingTransaction();

        }
    }
}

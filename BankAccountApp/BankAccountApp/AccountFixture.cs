using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BankAccountApp
{
    [TestFixture]
    public class AccountFixture
    {
        private Account anAccount;
        [SetUp]
        public void Initialization()
        {
            anAccount=new Account();
        }
        [Test]
        public void InitialBalanceTesst()
        {
            
            Assert.AreEqual(0,anAccount.Balance);
        }
        [Test]
        public void DepositeTest()
        {
            anAccount.Deposite(500);
            Assert.AreEqual(500,anAccount.Balance);
        }
        [Test]
        public void WithdrawTest()
        {
            anAccount.Deposite(550);
            anAccount.Withdraw(200);
            Assert.AreEqual(350, anAccount.Balance);
        }
        [Test]
        public void WithdrawPosiibleTest()
        {
            anAccount.Deposite(400);
            anAccount.Withdraw(230);
            anAccount.Withdraw(500);
            Assert.AreEqual(170, anAccount.Balance);
        }
        //[Test]
        //public void End()
        //{
        //    anAccount = null;
        //}

    }
}

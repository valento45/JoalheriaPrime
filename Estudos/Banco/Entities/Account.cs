using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estudos.Banco.Entities.Exceptions;

namespace Estudos.Banco.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            if (balance <= 0)
                throw new DomainException("Balance not can to be equal to zero or null");
            if(withdrawLimit <= 0)
                throw new DomainException("Withdraw Limit not can to be equal to zero or null");

            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double deposit)
        {
            if (deposit <= 0)
                throw new DomainException("Impossible depositing value small or equal to zero");

            Balance += deposit;
        }
        public void Withdraw(double value)
        {
            if(value <= 0)
                throw new DomainException("Impossible to withdraw value small or equal to zero");
            if (value > WithdrawLimit)
                throw new DomainException("Impossible to withdraw! Is value exceding value disponibility to withdraw");

            Balance -= value;
        }

    }
}

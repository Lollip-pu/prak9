using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _3
{
   class BankAccount
    {
        private string owner;
        private double balance;
        public string Owner { get { return owner;  } set { owner = value; } }   
        public double Balance {get { return balance; } set {
                if (balance < 0)
                balance = value;
            else Console.WriteLine("Недостаточно средств");
            } }
    public BankAccount(string owner, double balance)
        {
            this.owner = owner;
            this.balance = balance;
        }
        public void Deposit(double amon) {
            if (amon > 0)
                balance += amon;
                 Console.WriteLine($"{owner}, баланс: {balance}");
        }
        public void Withdraw(double amont)
        {
            if (amont <= 0)

                Console.WriteLine("Сумма снятия должна быть больше 0!");

            else if (amont > balance)
            {
                Console.WriteLine("Недостаточно средств!");
                Console.WriteLine($"{owner}, баланс: {balance}.");
            }
            else
            {
                balance -= amont;
                Console.WriteLine($"{owner}, баланс: {balance}.");
            }
        }
    }

 class Program
    {
        static void Main()
        {
            BankAccount bankAccount = new BankAccount("Данила", 5000);
            bankAccount.Deposit(1000);
            bankAccount.Withdraw(100);
            bankAccount.Withdraw(3000);
            Console.ReadLine();

        }
    }
}

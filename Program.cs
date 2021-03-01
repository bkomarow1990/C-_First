using System;
using System.Collections.Generic;
namespace ATM
{
    class Number
    {
        private int number;
        public void Inc()
        {
            ++number;
        }
        public Number(int number)
        {
            this.number = number;
        }
        public Number() :this(0)
        {

        }
        public override string ToString()
        {
            return $"Number : {number}";
        }
    }
    public class Account
    {
        private String login="admin";
        private String pass="admin";
        public Account(String login, String pass)
        {
            this.login = login;
            this.pass = pass;
        }
    }
    
    class Card
    {
        private int id = 0;
        private int money = 0;
        private int pin = 0;
    }
    class ATM
    {
       
        private Account = new Account("admin","admin");
        public ATM(int id,int money, Account acc)
        {
            this.account = acc;
            this.id = id;
            this.money = money;
        }
        void showBalance()
        {
            Console.WriteLine($"Balance: {money}");

        }
        void addMoney(int money) {
            this.money += money;
        }
        void withdraw(int money)
        {
            if (this.money-money < 0)
            {
                this.money = 0;
                return;
            }
            this.money = money;
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            int answer=228;
            do
            {
               answer = Console.Read();
                switch (answer)
                {
                    default:
                        break;
                }
            } while (true);
            //Number num = new Number(10);
            //Console.WriteLine("Hello World!");
            //Console.WriteLine(num.ToString());
        }
    }
}
//  class ATM  : login* password*
//
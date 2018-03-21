using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonClass
{
   public class Person
    {
        private string name;
        private List<BankAccount> accounts;
        private int age;

        public Person(string name,int age) :this(name,age, new List<BankAccount>())
        {
            this.name = name;
            this.age = age;
            this.accounts=new List<BankAccount>();
        }

        public Person(string name, int age, List<BankAccount> accounts)
        {
            this.name = name;
            this.age = age;
            this.accounts = accounts;
        }

        public decimal GetBalance()
        {
            return this.accounts.Sum(x => x.Balance);
        }
    }
}

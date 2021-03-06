﻿using System;
using System.Collections.Generic;
using System.Text;


    public class BankAccount
    {
        private int id;
        private decimal balance;

        public int Id
        {
            get { return this.id; }

            set { this.id = value; }
        }

        public decimal Balance
        {
            get { return this.balance; }

            set { this.balance = value; }
        }

        //Deposit(decimal amount) : void
        //Withdraw(decimal amount) : void
        //
        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (this.Balance - amount < 0)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                this.Balance -= amount;
            }
        }

        public override string ToString()
        {
            return $"Account ID{this.id}, balance {this.balance:F}";
        }
    }


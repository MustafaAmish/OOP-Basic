using System;
using System.Collections.Generic;
using System.Linq;

namespace BankAccount1
{
     class Program
    {
        public static void Main(string[] args)
        {
            var acc = new Dictionary<int, BankAccount>();

            string input;
            while ((input=Console.ReadLine())!="End")
            {
                var cmd = input.Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries).ToArray();
                int id = int.Parse(cmd[1]);
                var commad = cmd[0];
                switch (commad)
                {
                    case "Create":
                        if (acc.ContainsKey(id))
                        {
                            Console.WriteLine("Account already exists");
                        }
                        else
                        {
                            acc[id]=new BankAccount(){Id= id};
                        }
                        break;
                    case "Deposit":
                        if (!acc.ContainsKey(id))
                        {
                            Console.WriteLine("Account does not exist");
                        }
                        else
                        {
                            acc[id].Deposit(decimal.Parse(cmd[2]));
                        }
                        break;
                    case "Withdraw":
                        if (!acc.ContainsKey(id))
                        {
                            Console.WriteLine("Account does not exist");
                        }
                        else
                        {
                            acc[id].Withdraw(decimal.Parse(cmd[2]));
                        }
                        break;
                    case "Print":
                        if (!acc.ContainsKey(id))
                        {
                            Console.WriteLine("Account does not exist");
                        }
                        else
                        {
                            Console.WriteLine(acc[id].ToString());
                        }
                        break;
                }
            }

        }

        
    }
}

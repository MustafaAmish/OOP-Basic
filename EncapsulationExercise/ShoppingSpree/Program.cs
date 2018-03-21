using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var inputPersons = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
                var persons=new List<Person>();
                foreach (var inputPerson in inputPersons)
                {
                    var tokens = inputPerson.Split('=');
                    string name = tokens[0];
                    decimal money = decimal.Parse(tokens[1]);
                    var person=new Person(name,money);
                    persons.Add(person);
                }

                var inputProduct = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
                var product = new List<Product>();
                foreach (var products in inputProduct)
                {
                    var tokens = products.Split('=');
                    string name = tokens[0];
                    decimal money = decimal.Parse(tokens[1]);
                    var productss = new Product(name, money);
                    product.Add(productss);
                }

                string command;
                while ((command=Console.ReadLine())!="END")
                {
                    var token = command.Split();
                    Console.WriteLine(persons.First(p => p.Name == token[0]).TryBoughtPoduct(product.First(pc => pc.Name == token[1])));
                }
                foreach (var person in persons)
                {
                    Console.WriteLine(person);
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
               
            }
        }
    }
}

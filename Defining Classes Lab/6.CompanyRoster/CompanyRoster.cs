using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.CompanyRoster
{
    class CompanyRoster
    {
        static void Main(string[] args)
        {//string namee,int salaryy,string positionn,string depatmentt
            int count = int.Parse(Console.ReadLine());
            var dict = new  List<Employee>();
            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var name = input[0];
                var salary = double.Parse(input[1]);
                var position = input[2];
                var depatment = input[3];

                if (input.Length == 6)
                {
                    var email = input[4];
                    var age = int.Parse(input[5]);
                    var employe = new Employee(name, salary, position, depatment, email, age);
                    AddToDict(depatment, employe, dict);
                    continue;
                }
                else if (input.Length > 4)
                {
                    int age;
                    var check = int.TryParse(input[4], out age);
                    if (check)
                    {
                        var employe = new Employee(name, salary, position, depatment, age);
                        AddToDict(depatment, employe, dict);

                    }
                    else
                    {
                        var employe = new Employee(name, salary, position, depatment, input[4]);
                        AddToDict(depatment, employe, dict);

                    }
                    continue;
                }
                var employee = new Employee(name, salary, position, depatment);
                AddToDict(depatment, employee, dict);

            }
            var employers = dict.GroupBy(x => x.Depatment).OrderByDescending(c => c.Select(e => e.Salary).Sum())
                .First();
            Console.WriteLine($"Highest Average Salary: {employers.Key}");
            Console.WriteLine(string.Join(Environment.NewLine,employers.OrderByDescending(x=>x.Salary).Select(e=>$"{e.Name} {e.Salary:F2} {e.Email} {e.Age}")));
        }

        private static void AddToDict(string depatment, Employee employe, List<Employee> dict)
        {
            
            dict.Add(employe);
        }
    }
}

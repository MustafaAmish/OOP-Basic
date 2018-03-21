using System;
using System.Collections.Generic;
using System.Text;

//name, salary, position, department, email and age.
    public class Employee
    {
        private string name;
        private double salary;
        private string position;
        private string depatment;
        private string email;
        private int age;
        public string Depatment { get { return this.depatment; } }
    public double Salary { get { return this.salary; } }
        public int Age { get { return this.age; } }
        public string Name { get { return this.name; } }
        public string Position { get { return this.position; } }
        public string Email { get { return this.email; } }
    public Employee(string name,double salary,string position,string depatment)
        {
           this.name = name;
           this.salary = salary;
           this.position = position;
           this.depatment = depatment;
           this.email = "n/a";
           this.age = -1;
        }

        public Employee(string name, double salary, string position, string depatment,int age):this( name, salary, position, depatment)
        {
            this.age = age;
        }

        public Employee(string name, double salary, string position, string depatment, string email):this(name, salary, position, depatment)
        {
            this.email = email;
        }

        public Employee(string name, double salary, string position, string depatment, string email,int age):this(name, salary, position, depatment)
        {
            this.age = age;
            this.email = email;
        }
    }


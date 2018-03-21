using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Google
{
    class Persson
    {
        private string name;
        private Company company;
        private Car car;
        private List<Parents> parentses;
        private List<Children> childrens;
        private List<Pokemon> pokemons;

        public Persson(string name)
        {
            this.Name = name;
            this.Parentses=new List<Parents>();
            this.Childrens=new List<Children>();
            this.Pokemons=new List<Pokemon>();
        }

        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
            set { pokemons = value; }
        }

        public List<Children> Childrens
        {
            get { return childrens; }
            set { childrens = value; }
        }

        public List<Parents> Parentses
        {
            get { return parentses; }
            set { parentses = value; }
        }

        public Car Car
        {
            get { return car; }
            set { car = value; }
        }

        public Company Company
        {
            get { return company; }
            set { company = value; }
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"{nameof(Persson)}'s name can not be neither empty nor white space!!!");
                }

                this.name = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.name);

            sb.AppendLine("Company:");
            if (this.company != null)
            {
                sb.AppendLine(this.company.ToString());
            }

            sb.AppendLine("Car:");
            if (this.car != null)
            {
                sb.AppendLine(this.car.ToString());
            }

            sb.AppendLine("Pokemon:");
            if (this.pokemons.Count > 0)
            {
                sb.AppendLine(string.Join(Environment.NewLine, this.pokemons.Select(pok => pok.ToString())));
            }

            sb.AppendLine("Parents:");
            if (this.parentses.Count > 0)
            {
                sb.AppendLine(string.Join(Environment.NewLine, this.parentses.Select(par => par.ToString())));
            }

            sb.AppendLine("Children:");
            if (this.childrens.Count > 0)
            {
                sb.AppendLine(string.Join(Environment.NewLine, this.childrens.Select(c => c.ToString())));
            }

            return sb.ToString();
        }
    }
}

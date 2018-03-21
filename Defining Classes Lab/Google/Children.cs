using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{
    class Children
    {
        private string name;
        private string date;

        public Children(string name, string date)
        {
            this.Name = name;
            this.Date = date;
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }


        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"{nameof(Children)}'s name can not be neither empty nor white space!!!");
                }

                this.name = value;
            }
        }

        public override string ToString()
        {
         
            return $"{this.Name} {this.Date}";
        }
    }
}

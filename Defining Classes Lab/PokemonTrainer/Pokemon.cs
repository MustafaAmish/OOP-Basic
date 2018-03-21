using System;
using System.Collections.Generic;
using System.Text;


  public  class Pokemon
    {
        private string name;
        private string element;
        private int healt;

        public Pokemon(string name,string element,int healt)
        {
            this.Name = name;
            this.Element = element;
            this.Healt = healt;
        }
        public int Healt
        {
            get { return healt; }
            set { healt = value; }
        }


        public string Element
        {
            get { return element; }
            set { element = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }


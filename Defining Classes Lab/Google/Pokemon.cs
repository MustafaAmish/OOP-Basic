using System;
using System.Collections.Generic;
using System.Text;


  public  class Pokemon
    {
        private string name;
        private string element;
        

        public Pokemon(string name,string element)
        {
            this.Name = name;
            this.Element = element;
           
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
    public override string ToString()
    {
        
        return $"{this.Name} {this.Element}";
    }
}


using System;

namespace PizzaCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                var pizzaName = Console.ReadLine().Split()[1];
                var doutht = Console.ReadLine().Split();
                var type = doutht[1];
                var baking = doutht[2];
                var weight = double.Parse(doutht[3]);
                var douth=new Dough(type,baking,weight);
                var pizza=new Pizza(pizzaName,douth);
                string input;
                while ((input=Console.ReadLine())!="END")
                {
                    var topping = input.Split();
                    var name = topping[1];
                    var weightt = double.Parse(topping[2]);
                    var toppings=new Topping(name,weightt);
                    pizza.AddTopping(toppings);
                }
            
                Console.WriteLine($"{pizza.Name} - {pizza.Callories():F} Calories.");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                
            }
        }
    }
}

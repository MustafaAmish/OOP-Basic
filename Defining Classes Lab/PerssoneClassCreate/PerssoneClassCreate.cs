using System;

namespace PerssoneClassCreate
{
   public class PerssoneClassCreate
    {
       public static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            
            
            var family= new Family();
            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
               
                var persson = new Person(input[0], int.Parse(input[1]));
                family.AddMember(persson);
            }

            foreach (var pp in family.GetOldestMember())
            {
                Console.WriteLine($"{pp.Name} - {pp.Age}");
            }
        }
    }
}

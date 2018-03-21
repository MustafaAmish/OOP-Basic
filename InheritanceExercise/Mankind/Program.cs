using System;

namespace Mankind
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var studenInfoInput = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                var student=new Student(studenInfoInput[0],studenInfoInput[1],studenInfoInput[2]);
                var workerInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var worker=new Worker(workerInfo[0],workerInfo[1],decimal.Parse(workerInfo[2]),decimal.Parse(workerInfo[3]));
                Console.WriteLine(student+Environment.NewLine);
                Console.WriteLine(worker);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
               
            }
        }
    }
}

using System;
using System.Linq;

namespace P03_JediGalaxy
{
    class Program
    {
        static void Main()
        {
            int[] dimestions = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int x = dimestions[0];
            int y = dimestions[1];

            int[,] matrix =FillUpMatrix( new int[x, y]);

            

            string command ;
            
            while ((command = Console.ReadLine()) != "Let the Force be with you")
            {
                int[] ivoCordinate = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int[] dartVader = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                DartVaderMove(dartVader,matrix);
                IvoMove(ivoCordinate, matrix);
            }

            

        }

        private static void IvoMove(int[] ivoCordinate, int[,] matrix)
        {
            int row = ivoCordinate[0];
            int col = ivoCordinate[1];
            long sum = 0;
            while (row >= 0 && col < matrix.GetLength(1))
            {
                if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
                {
                    sum += matrix[row, col];
                }

                col++;
                row--;
            }
            Console.WriteLine(sum);
        }

        private static void DartVaderMove(int[] dartVader, int[,] matrix)
        {
            int rowVader = dartVader[0];
            int colVader = dartVader[1];
            while (rowVader >= 0 && colVader >= 0)
            {
                if (rowVader >= 0 && rowVader < matrix.GetLength(0) && colVader >= 0 && colVader < matrix.GetLength(1))
                {
                    matrix[rowVader, colVader] = 0;
                }
                rowVader--;
                colVader--;
            }
        }

        private static int[,] FillUpMatrix(int[,] ints)
        {
            int value = 0;
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    ints[i, j] = value++;
                }
            }
            return ints;
        }
    }
}

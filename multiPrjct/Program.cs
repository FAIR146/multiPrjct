using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiPrjct
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[2, 5];
            int multiply = 0;
            Random random = new Random();
            for (short i = 0; i < numbers.GetLength(0); i++)
            {
                for (short j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = random.Next(1, 20);

                }
            }
            for (short i = 0; i < numbers.GetLength(0); i++)
            {
                for (short j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write($"{numbers[i, j]}  ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    sum += numbers[i, j];
                }
                Console.WriteLine();
                Console.Write(sum + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                multiply = 1;
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        multiply = numbers[0, j] * numbers[1, j];

                    }
                }
                
            }
            Console.Write($"Ответ: {multiply}" + " ");
            Console.ReadKey();
        
        }

    }
}

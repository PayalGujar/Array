using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class _2DArrayUser
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4, 5];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }


            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine($"array[{i}, {j}]={array[i, j]}");
                }
            }

        }
    }
}

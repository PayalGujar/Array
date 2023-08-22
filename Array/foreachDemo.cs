using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class foreachDemo
    {
        public static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("1D Array");
            foreach (int i in array)
            {

                Console.WriteLine(i);
            }

            int[,] array2 = new int[2, 2]
            {
                { 10, 20 },
                { 30, 40 }

            };
            Console.WriteLine("2D Array");
            foreach(var j in array2)
            {
                Console.WriteLine(j);
            }

        }
    }
}

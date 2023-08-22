using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class PrintNegativeelements
    {
        static void Main(string[] args)
        {
            int[] negativenum = new int[10];
            int cnt = 0;
            for(int i=0;i<negativenum.Length;i++)
            {
                Console.WriteLine($"Enter Number {i}");
                negativenum[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0;i<negativenum.Length;i++)
            {
                if (negativenum[i] < 0) 
                {
                    Console.WriteLine($"{negativenum[i]} is Negative");
                    cnt++;
                }

            }
            Console.WriteLine($"Total {cnt} numbers are negative");
        }
    }
}

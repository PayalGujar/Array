using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class EvenNumberPrint
    {
        static void Main(string[] args)
        {
            int[] arr=new int[10];

            for(int i=0;i<arr.Length; i++)
            {
                Console.WriteLine($"Enter number {i}");
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0;i<arr.Length ;i++)
            {
                if (arr[i]%2==0)
                {
                    Console.WriteLine($"{arr[i]} is Even ");
                }

            }
        }
    }
}

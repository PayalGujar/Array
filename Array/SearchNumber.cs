using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class SearchNumber
    {
        static void Main(string[] args)
        {
            int[] array=new int[5];
            for(int i=0; i<array.Length; i++)
            {
                Console.WriteLine("Enter Number");
                array[i]=Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter Number to be search");
            int m=Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<=array.Length;i++)
            {
                if (array[i]==m)
                {
                    Console.WriteLine($"{m} found at {i} Index");
                }
            }
        }
    }
}

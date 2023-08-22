using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class MaxMinValue
    {
        public static void Main(string[] args)
        {
            int[] array = new int[5];
            for(int i=0; i<array.Length; i++)
            {
                Console.WriteLine("Enter Number");
                array[i] =Convert.ToInt32(Console.ReadLine());
            }
            int m = array[0];
            int n = array[0];
            for(int i=0;i<array.Length ; i++)
            {
                if (array[i] > m)
                {
                    m= array[i];
                }
                else if (array[i] < n) 
                {
                    n= array[i];
                }

            }
            Console.WriteLine(m);
            Console.WriteLine(n);
          
        }
    }
}

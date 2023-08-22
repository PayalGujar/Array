using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class OddEven
    {
        public static void Main(string[] args)
        {
            int[] array1 = new int[5];
            int[] array2 = new int[5];
            int[] array3 = new int[5];
            int j = 0, k = 0;

            for(int i=0;i<array1.Length; i++)
            {
                Console.WriteLine("Enter Number");
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] % 2 == 0)
                {
                    array2[j] = array1[i];
                    j++;
                }
                else
                {
                    array3[i] = array1[i];
                    k++;
                }

            }

            for(int i=0; i < j; i++)
            {
                    Console.WriteLine(array2[i]);
                
            }
            Console.WriteLine("................................................");

            for (int i = 0; i < k; i++)
            {
                
                    Console.WriteLine(array3[i]);
                
            }

        }
    }
}



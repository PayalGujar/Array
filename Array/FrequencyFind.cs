using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 9.	WAP to count frequency of each element in an array.
 */
namespace Array
{
    internal class FrequencyFind
    {
        public static void Main(string[] args)
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter Number");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                int cnt = 1;
                bool flag = false;

                for (int k = i - 1; k >= 0; k--)
                {
                    if (array[k] == array[i])
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] == array[j])
                        {
                            cnt++;
                        }

                    }
                }
                if (cnt > 1)
                {
                    Console.WriteLine($"Number={array[i]} frequency={cnt}");
                }

            }
        }
    }
}

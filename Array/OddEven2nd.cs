using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class OddEven2nd
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine( "Enter the total number of elements youo want to enter");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] TotalNum = new int[n];
            int j = 0, k = 0;
            int[] even = new int[5];
            int[] odd = new int[5];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the value");
                TotalNum[i]= Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 0; i < TotalNum.Length; i++)
            {
                if (TotalNum[i]% 2 == 0)
                {
                    even[j] = TotalNum[i];
                    j++;
                }
                else
                {
                    odd[k] = TotalNum[i];
                    k++;
                }



            }

            for (int i = 0; i <j; i++)
            {
                
                Console.WriteLine(even[i]);
            }


        }
    }


}

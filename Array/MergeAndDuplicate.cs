using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class MergeAndDuplicate
    {
        public static void Main(string[] args)
        {
            int[] array = new int[10];
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("Enter Number");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine("Enter Number");
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }
            int cnt = 0;
            for(int i=0; i < arr1.Length; i++)
            {
                //int cnt = 0;
                bool flag= false;
                for(int k=i-1;k>=0;k--)
                {
                    if (arr1[k] == arr1[i])
                    {
                        flag = true;
                        break;
                    }
                }
                
                if(flag==false)
                {
                    array[cnt]= arr1[i];
                    cnt++;
                }
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                //int cnt = 0;
                bool flag = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (arr2[k] == arr2[i])
                    {
                        flag = true;
                        break;
                    }
                }

                if (flag == false)
                {
                    array[cnt] = arr2[i];
                }
            }

            for(int i=0;i<array.Length;i++)
            {
                Console.WriteLine(array[i]);
            }

        }
    }
}

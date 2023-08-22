using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 10.	WAP to merge 2 arrays to 3rd array. 3rd array should not have elements of same value.
 */

namespace Array
{
    internal class Merge2Array
    {
        public static void Merge(int[] array)
        {
            int[] arr1= new int[5];
            int[] arr2= new int[5];

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
            for(int i=0;i<arr1.Length; i++)
            {
             
                                    
                    array[cnt] = arr1[i];
                     cnt++;  
                
              
            }
            for (int i = 0; i < arr2.Length; i++)
            {


                array[cnt++] = arr2[i];


            }

            for (int i=0;i<array.Length;i++)
            {
                
                Console.WriteLine(array[i]);
            }
            

        }
        public static void Main(string[] args)
        {
            int[] array1 = new int[10];
            Merge(array1);

        }
    }
}

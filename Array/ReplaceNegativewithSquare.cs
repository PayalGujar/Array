using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
  14.	WAP to replace all negative value with its immediate left elements square.
        Means arr[] = [12, 3,-19, 29, 5, -61, 44, 7, -9] Output array will be [12, 3, 9, 29, 5, 25, 44, 7, 49].
 */

namespace Array
{
    
    public class ReplaceNegativewithSquare
    {
        public static void NegativeSquare(int[] array)
        {
            int temp = array[1];
            if (array[0]<0)
            {
                array[0] = array[array.Length-1] * array[array.Length-1];
            }
            for (int i=0;i<array.Length; i++)
            {
              
                if (array[i] < 0)
                {
                    array[i] = temp * temp;
                    temp = array[i];
                }
                else
                {
                    temp= array[i];
                }
               
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public static void Main(string[] args)
        {
            /*int[] array = new int[] { 12, 3, -19, 29, 5, -61, 44, 7, -9 };
            NegativeSquare(array);*/
            int[] array1 = new int[] { -12, 3, -19, 29, 5, -61, 44, 7, -9 };
            NegativeSquare(array1);

        }
    }
}

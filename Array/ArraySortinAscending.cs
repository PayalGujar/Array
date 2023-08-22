using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class ArraySortinAscending
    {
        public static void Main(string[] args)
        {
            int[] array = new int[5] { 45, 67, 12, 89, 5 };

           for(int i=0;i<array.Length; i++)
            {
                for(int j=i+1;j<array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp;
                        temp= array[i];
                        array[i]= array[j];
                        array[j]= temp;
                    }
                }
            }
           foreach(int i in array)
            {
                Console.WriteLine(i);
            }
           
        }
    }
}

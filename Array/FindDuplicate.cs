using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/*
  1.WAP to find and count total number of duplicate elements in an array.
 */

namespace Array
{
    internal class FindDuplicate
    {
        public static void Main(string[] args)
        {
            int[] array=new int[10];
            for(int i=0;i<array.Length;i++)
            {
                Console.WriteLine("Enter Number");
                array[i]=Convert.ToInt32(Console.ReadLine());
            }
         
            for(int i=0;i<array.Length ; i++)
            {
                int cnt = 1;
                bool isvisited=false;
                for(int k=i-1;k>=0 ; k--) {
                    if (array[k] == array[i])
                    { 
                        isvisited = true;
                    break;
                    }
                }

                if (isvisited == false)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] == array[j])
                        {
                            cnt++;
                        }

                    }
                    if(cnt>1)
                    {
                        Console.WriteLine($"Duplicate found {array[i]}");
                    }

                }
            }
           
           // Console.WriteLine(cnt);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class AcceptName1D
    {
        public static void Main(string[] args)
        {
            string[] array = new string[5];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter Name");
                array[i]=Console.ReadLine();
            }

            /*for(int i=0;i< array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }*/

            foreach (string s in array)
            {
                Console.WriteLine(s);
            }
        }
    }
}
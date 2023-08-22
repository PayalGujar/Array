using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class AvgFind
    {
        public static int Average(int[] array)
        {
            int cnt = 0, sum = 0, avg;
            for(int i=0;i<array.Length; i++)
            {
                Console.WriteLine("Enter num");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
                cnt++;
            }
            avg = sum / cnt;
            return avg;

        }
        public static double Average(double[] array)
        {
            int cnt = 0;
            double avg, sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter num");
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                sum =(double)sum + array[i];
                cnt++;
            }
            avg = (double)sum / cnt;
            return avg;

        }
        static void Main(string[] args)
        {
            int[] array1 = new int[5];
            Console.WriteLine(Average(array1));
            double[] array2 = new double[3];
            Console.WriteLine(Average(array2));

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] rf = new double[7];
            for (int i = 0; i < rf.Length;i++)
            {
                Console.WriteLine($"Enter Rain fall for day {i}");
                rf[i]=Convert.ToDouble(Console.ReadLine());
            }

            for(int j=0; j<rf.Length;j++)
            {
                Console.WriteLine($"Rain Fall for Day {j} is {rf[j]}");
            }
        }
    }
}

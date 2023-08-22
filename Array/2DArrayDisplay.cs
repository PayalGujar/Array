using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class _2DArrayDisplay
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4, 5]
                {
                    {10,20,30,40,50},
                    {60,70,80,90,100},
                    {110,120,130,140,150},
                    {160,170,180,190,200}
                };

            for(int i=0;i<array.GetLength(0);i++)
            {
                for(int j=0;j<array.GetLength(1);j++)
                {
                    Console.WriteLine($"array[{i},{j}]={array[i,j]}");
                   
                }
                Console.WriteLine("\n");
            }
            
        }
    }
}

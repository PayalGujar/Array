using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Properties
{
    internal class Booklist
    {
        public class Book
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public float Price { get; set; }
        }
        public class ListandPropertiesEmployee
        {
            public static void Main(string[] args)
            {
                Book[] list = new Book[3]
                {
            new Book{Id=1,Name="Atomic Habbits",Price=400},
            new Book{Id=2,Name="secret",Price=300},
            new Book{Id=3,Name="Data Science",Price=3500}
                };

                foreach (Book a in list)
                {
                    Console.WriteLine($"{a.Id} {a.Name} {a.Price}");
                }
            }
        }
    }
}

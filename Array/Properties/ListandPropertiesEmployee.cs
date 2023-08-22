using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Array.Properties
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public float Salary { get; set; }
    }
    public class ListandPropertiesEmployee
    {
        public static void Main(string[] args)
        {
            Employee[] list = new Employee[3]
            {
            new Employee{Id=1,Name="Payal",Salary=40000},
            new Employee{Id=2,Name="Samruddhi",Salary=30000},
            new Employee{Id=3,Name="Ketki",Salary=35000}
            };

            foreach (Employee a in list)
            {
                Console.WriteLine($"{a.Id} {a.Name} {a.Salary}");
            }
        }
    }
}



	
    




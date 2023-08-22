using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public enum Designation { Traine, Manager, CEO, Employee };
    public enum Departments { HR, Admin, Dev, Testing, Marketing };
    public class Employee
    {
        private int id;
        private string name;
        private float salary;
        public Designation des;
        public Departments dep;

        public Employee(int id, string name, float salary,Designation des,Departments dep)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.des= des; 
            this.dep = dep;
        }

        public override string ToString()
        {
            return $"{id} {name} {salary} {des} {dep}";
        }
    }
    public class enumexample
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee(1,"Payal",40000,Designation.Manager,Departments.Dev);
            Console.WriteLine(e1);
            Employee e2 = new Employee(2, "Ketki", 30000, Designation.Employee, Departments.Testing);
            Console.WriteLine(e2);

        }

    }
}

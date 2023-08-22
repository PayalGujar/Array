using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Create Array of Object and store data.
 */

namespace Array
{
    public class ArrayOfObjectExample
    {
        private int id;
        public string name;
        public float salary;

        public ArrayOfObjectExample(int id, string name, float salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public override string ToString()
        {
            return $"{id} {name} {salary}";
        }

    }

    public class program
    {
        public static void Main(string[] args)
        {
            ArrayOfObjectExample[] emp = new ArrayOfObjectExample[3];
           emp[0]=new ArrayOfObjectExample(101,"Payal",40000);
            emp[1] = new ArrayOfObjectExample(202, "ketki", 5000);
            emp[2] = new ArrayOfObjectExample(303,"Samruddhi", 45000);

           /* for(int i=0; i<emp.Length; i++)
            {
                Console.WriteLine("Enter ID");
                int id=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Salary");
                float sal = Convert.ToSingle(Console.ReadLine());
                emp[i]=new ArrayOfObjectExample(id, name, sal);

            }*/
           /* for(int i=0;i<emp.Length;i++)
            {
                if (emp[i].salary>20000)
                {
                    Console.WriteLine(emp[i]);
                }
                
            }*/

            for(int i=0;i<emp.Length;i++)
            {
                char[] st = emp[i].name.ToCharArray();
                int cnt = 0;
                for(int j=0;j<st.Length;j++)
                {
                    if (st[j]=='a' || st[j]=='e' || st[j]=='i'|| st[j]=='o' || st[j]=='u')
                    {
                        cnt++;

                    }
                    
                }
                if(cnt >= 2)
                    {
                    Console.WriteLine(emp[i]);
                }


            }
           /* foreach(ArrayOfObjectExample e in emp)
            {
                Console.WriteLine(e);
            }
            for(int i=0;i<emp.Length;i++)
            {
                Console.WriteLine(emp[i]);
            }*/
        }
    }
}

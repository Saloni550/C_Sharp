using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deligated_method
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
    }
}
    
    public class DataManger
    {
        internal static List<Employee> GetData()
        {
            return new List<Employee>
            {
              new Employee {ID =1, FirstName ="john",LastName="Smith",Age=30,Department="HR",Salary=25000 },
              new Employee {ID =2, FirstName ="allea",LastName="jones",Age=40,Department="HR",Salary=35000 },
              new Employee {ID =3, FirstName ="aaliya",LastName="william",Age=30,Department="DEV",Salary=45000 },
              new Employee {ID =4, FirstName ="David",LastName="Brown",Age=32,Department="Client",Salary=15000 },
              new Employee {ID =5, FirstName ="roni",LastName="Miller",Age=38,Department="Manager",Salary=15000 },
              new Employee {ID =6, FirstName ="lija",LastName="disuja",Age=27,Department="Mangement",Salary=25000 },
              new Employee {ID =7, FirstName ="neel",LastName="pathak",Age=20,Department="QA",Salary=55000 },
              new Employee {ID =8, FirstName ="leeza",LastName="shri",Age=50,Department="HR",Salary=35000 },


            };


        }
    }
}

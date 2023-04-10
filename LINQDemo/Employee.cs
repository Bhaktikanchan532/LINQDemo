using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace LINQDemo
{
    public class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public override string ToString()
        {
            return $"{Id}->{Name}->{Salary}";
        }
    }
    public class Employee
    {
        static void Main(string[] args)
        {
            List<Emp> employeelist = new List<Emp>()
            {
                new Emp {Id=1,Name="Riya",Salary=10000},
                new Emp {Id=2, Name="Pooja", Salary= 12000},
                new Emp {Id=3, Name="Priyanka", Salary = 15000 },
                new Emp {Id=4, Name="Advik", Salary = 25000},
                new Emp {Id=5, Name="Onkar", Salary= 22000 },
                new Emp {Id=6, Name="Shree", Salary = 8000 },
            };
            //   var result = from e in employeelist select e;

            //var result = from e in employeelist
            //             where e.Salary<20000
            //             select e;

            //var result = from e in employeelist
            //             where e.Salary>10000  && e.Salary<20000
            //             select e;

            //var result = from e in employeelist
            //             where e.Name.Contains("Po")
            //             select e;

            //var result = from e in employeelist
            //             where e.Name.StartsWith("R")
            //             select e;

            //var result = from e in employeelist
            //             where e.Name.EndsWith("k")
            //             select e;


            //var result = from e in employeelist
            //             where e.Salary<22000
            //             orderby e.Name ascending
            //             select e;

            var result = from e in employeelist
                         where e.Salary < 15000
                         orderby e.Name descending
                         select e;
            foreach (Emp e in result)
            {
                Console.WriteLine(e);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace LINQDemo
{
    public class Stud
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Fees { get; set; }
        public override string ToString()
        {
            return $"{Id}->{Name}->{Fees}";
        }
    }
    public class Student
    {
        static void Main(string[] args)
        {
            List<Stud> studentlist = new List<Stud>()
            {
                new Stud {Id=1,Name="Riya",Fees=10000},
                new Stud {Id=2, Name="Pooja", Fees= 12000},
                new Stud {Id=3, Name="Priyanka", Fees = 15000 },
                new Stud {Id=4, Name="Advik", Fees = 25000},
                new Stud {Id=5, Name="Onkar", Fees= 22000 },
                new Stud {Id=6, Name="Shree", Fees = 8000 },
            };
            //   var result = from s in studentlist select s;

            //var result = from s in studentlist
            //             where s.Fees<20000
            //             select s;

            //var result = from s in studentlist
            //             where s.Fees>10000  && s.Fees<20000
            //             select s;

            //var result = from s in studentlist
            //             where s.Name.Contains("Po")
            //             select s;

            //var result = from s in studentlist
            //             where s.Name.StartsWith("R")
            //             select s;

            //var result = from s in studentlist
            //             where s.Name.EndsWith("k")
            //             select s;


            //var result = from s in studentlist
            //             where s.Fees<22000
            //             orderby s.Name ascending
            //             select s;

            var result = from s in studentlist
                         where s.Fees< 15000
                         orderby s.Name descending
                         select s;
            foreach (Stud s in result)
            {
                Console.WriteLine(s);
            }

        }
    }
}
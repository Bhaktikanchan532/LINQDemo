//using System;
//using System.Collections.Generic;
//using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

//namespace LINQDemo
//{
//    public class Product
//    {
//        public int Id { get; set;}
//        public string Name{ get; set; }
//         public int Price { get; set;}
//        public override string ToString()
//        {
//            return $"{Id}->{Name}->{Price}"; 
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            List<Product> productlist = new List<Product>()
//            {
//                new Product {Id=1,Name="Mouse",Price=999},
//                new Product {Id=2, Name="Pen", Price = 12 },
//                new Product {Id=3, Name="Pensil", Price = 10 },
//                new Product {Id=4, Name="Notebook", Price = 50},
//                new Product {Id=5, Name="Marker", Price = 20 },
//                new Product {Id=6, Name="Whitebord", Price = 800 },
//            };
//            //   var result = from p in productlist select p;

//            //var result = from p in productlist 
//            //             where p.Price<50
//            //             select p;

//            //var result = from p in productlist
//            //             where p.Price>10  && p.Price<30
//            //             select p;

//            //var result = from p in productlist
//            //             where p.Name.Contains("Pe")
//            //             select p;

//            //var result = from p in productlist
//            //             where p.Name.StartsWith("P")
//            //             select p;

//            //var result = from p in productlist
//            //             where p.Name.EndsWith("k")
//            //             select p;


//            //var result = from p in productlist
//            //             where p.Price<50
//            //             orderby p.Name ascending
//            //             select p;

//            var result = from p in productlist
//                         where p.Price < 50
//                         orderby p.Name descending
//                         select p;
//            foreach(Product p in result)
//            {
//                Console.WriteLine(p);
//            }

//        }
//    }
//}

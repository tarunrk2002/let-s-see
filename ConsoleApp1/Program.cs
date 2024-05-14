using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            //List<eco> ecos = new List<eco>();
            //ecos.Add(new eco
            //{
            //    name = "Tededst",
            //    description = "Teset1",
            //    type = "dewef"
            //});

            //ecos.Add(new eco
            //{
            //    name = "Teerfst",
            //    description = "Teserft1",
            //    type = "deef"
            //});

            //ecos.Add(new eco
            //{
            //    name = "Testfr",
            //    description = "Test1efw",
            //    type = "dewef"
            //});

            
            //foreach (eco e in ecos)
            //{
            //    Console.WriteLine(e.name);
            //    Console.WriteLine(e.description);
            //    Console.WriteLine(e.type);
            //    Console.WriteLine(e);
            //}
            //Console.WriteLine();

            //for (int i = 0; i < ecos.Count; i++)
            //{
            //    Console.WriteLine();
            //}


            List<int> ints = new List<int>();
            ints.Add(032);
            ints.Add(123);
            ints.Add(24);
            ints.Add(344444443);

            Console.WriteLine(ints[1]);

            List<eco> ecoob = new List<eco>();
            ecoob.Add(new eco
            {
                name = "a",
                description = "b",
                type = "c",
                age = 3
            });
            ecoob.Add(new eco
            {
                name = "ade",
                description = "wadb",
                type = "caed",
                age = 42
            });

            ecoob.Add(new eco
            {
                name = "afef",
                description = "bef",
                type = "sdc",
                age=21
            });




            //string name;
            //name = ecoob[2].name;
            //Console.WriteLine(name);
            //Console.WriteLine(ecoob[1].name);

            //test ab = new test();
            //ab.newfun();

            var ecoorder = ecoob.OrderBy(des => des.age);
            

            foreach ( eco i in ecoorder)
            {
                Console.WriteLine(i);
            }

            test test = new test();
            int a = 1;
            int b = 2;
            test.newfun2(a);
            
        }
       
    }
}

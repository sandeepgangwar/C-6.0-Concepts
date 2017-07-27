using System;
using System.Collections.Generic;
using System.Linq;
namespace LINQ
{

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int CrtId { get; set; }
    }

    class Certificate
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
    class JoinTest
    {

        public static void Test()
        {

            Func<Person, bool> pre = p => p.Age == 22;

            List<Person> persons = new List<Person>
            {
                new Person { Age=12, Name="A", CrtId=1 },
                new Person { Age=22, Name="B", CrtId=2 },
                new Person { Age=32, Name="C", CrtId=1 }
            };

            List<Certificate> certificates = new List<Certificate>
            {
                 new Certificate { Id=1, Title="MVP" },
                 new Certificate { Id=2, Title="MCP" },
            };


            //var fullDetails = from person in persons
            //                  join certificate in certificates on person.CrtId equals certificate.Id
            //                  select new { Name = person.Name, Age = person.Age, CertificateName = certificate.Title };

            //foreach (var item in fullDetails)
            //{
            //    System.Console.WriteLine($"{item.Name}:{item.Age}:{item.CertificateName}");
            //}

            var fullDetail = persons.Where(pre).Join(certificates, P => P.CrtId, c => c.Id, (per, cer) =>
            {
                System.Console.WriteLine($"Inside {per.Name}");
                return new { Name = per.Name, Title = cer.Title };
            });


            foreach (var item in fullDetail)
            {
                System.Console.WriteLine($"{item.Name}:{item.Title}");
            }

        }
    }
}

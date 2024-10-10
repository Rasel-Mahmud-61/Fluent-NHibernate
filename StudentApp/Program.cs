using System;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Microsoft.Identity.Client;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace StudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
           var sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008
                    .ConnectionString(@"Data Source=LAPTOP-SP1NASH4\SQLEXPRESS; 
                                       Initial Catalog=RASELMAHMUD; 
                                       Integrated Security=True; 
                                       Connect Timeout=15; 
                                       Encrypt=False; 
                                       TrustServerCertificate=False; 
                                       ApplicationIntent=ReadWrite; 
                                       MultiSubnetFailover=False"))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Student>())
                .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false, true))
                .BuildSessionFactory();

                     //  int hello =int.Parse(Console.ReadLine());

            using (var session = sessionFactory.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    var student1 = session.Get<Student>(1);
                    if (student1 != null ){
                        

                        Console.WriteLine($" {student1.FirstName} {student1.LastName}");
                    }

                    else
                    {
                        Console.WriteLine("no data available");

                    }
                     tx.Commit();

                }

                Console.WriteLine("Students saved successfully.");
                Console.ReadLine();
            }


        }

        
    }
}

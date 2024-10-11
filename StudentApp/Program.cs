using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
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


            int ask;
            Console.WriteLine("enter a id to retrive data from database");

                ask=int.Parse(Console.ReadLine());

            using (var session = NHibernateHelper.GetSession()) { 
            
                       using(var tx= session.BeginTransaction())
                {

                    //  read operation 
                    var studet1 = session.Get<Student>(ask);
                    if (studet1 != null)
                    {
                        Console.WriteLine($"{studet1.FirstName} {studet1.LastName}");   
                    }
                    tx.Commit();

                }



                Console.WriteLine("Students saved successfully.");
                Console.ReadLine();
            }


            //  write operation

            using (var session = NHibernateHelper.GetSession()) {

                using ( var tx = session.BeginTransaction()) {

                    try
                    {
                        var student3 = new Student()
                        {
                            ID = 3,
                            FirstName = "raselL",
                            LastName = "mahmud"
                        };


                        session.Save(student3);

                        tx.Commit();
                        Console.WriteLine("save sucessfully_");
                    }
                    catch (Exception ex) { } 

                
                }
            }

            


        }

        
    }
}

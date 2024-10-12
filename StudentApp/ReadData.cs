using Remotion.Linq.Clauses.ResultOperators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class ReadData
    {
        public void  show()
        {

              using(var session = NHibernateHelper.GetSession())
            {
                  using(var tx=session.BeginTransaction())
                {


                    //   var studentall=session.Query<Student>().FirstOrDefault();
                    //   foreach(var student in studentall)
                    //{
                    //    Console.WriteLine(student.FirstName);   


                    //}
                    try
                    {

                        Console.WriteLine("Enter id");
                        int idNumber = int.Parse(Console.ReadLine());

                        var studentA = session.Get<Student>(idNumber);

                        if (studentA != null)
                        {

                            Console.WriteLine($" {studentA.FirstName} {studentA.LastName}");

                        }
                        else Console.WriteLine("NO SYUDENT FOR THIS ID");

                    }
                    catch (Exception ex) { Console.WriteLine(ex.ToString()); }  

                    tx.Commit();


                }
            }
        }
    }
}

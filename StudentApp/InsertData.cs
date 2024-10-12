using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class InsertData
    {
        public void InsertValue()
        {
            using (var session = NHibernateHelper.GetSession())
            {

                using (var tx = session.BeginTransaction())
                {
                    try
                    {
                        var student5 = new Student()
                        {
                            ID = 6,
                            FirstName = "Rumel",
                            LastName = "naimur"
                        };

                        session.Save(student5);

                        tx.Commit();
                        Console.WriteLine("save sucessfully_");

                    }
                    catch (Exception ex) { }



                }

            }
        }
    }
}

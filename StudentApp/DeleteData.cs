using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class DeleteData
    {

        public void DeleteFromDatabase()
        {

            using (var session = NHibernateHelper.GetSession())
            {


                using (var tx = session.BeginTransaction())
                {
                    try
                    {
                        var deleteStudent = session.Get<Student>(1);

                        session.Delete(deleteStudent);
                        tx.Commit();

                    }
                    catch (Exception ex) { }


                }
            }



        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class UpdateClass
    {

        public void updateData()
        {
            using (var session = NHibernateHelper.GetSession())
            {
                using (var tx = session.BeginTransaction())
                {


                    try
                    {
                        var studentUpdate = session.Get<Student>(2);

                        studentUpdate.FirstName = "naim";
                       studentUpdate.LastName = "arafat";
                        session.Update(studentUpdate);
                        tx.Commit();

                    }

                    catch (Exception ex) { }


                }
            }
        }
    }
}
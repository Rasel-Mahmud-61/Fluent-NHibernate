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
            Console.WriteLine("enter  a digit to fix which type of operation you want to perform ");

                ask=int.Parse(Console.ReadLine());

            if (ask == 1) { 
               ReadData  readData = new ReadData();

                readData.show();

            }

            //  write operation 
            if (ask == 2) { 
              InsertData insertData = new InsertData();
                insertData.InsertValue();

             
            }
            //update 
            if (ask == 3) {
            
                 UpdateClass updateClass = new UpdateClass();

                updateClass.updateData();

            
            
            }


            // delete data from database 

            if (ask == 4) { 
            

                 DeleteData deleteData = new DeleteData();
                deleteData.DeleteFromDatabase();

            }


           


            


        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{

    class Program
    {
        static void Main(string[] args)
        {

            EFLogger logger = new EFLogger();
            using (EFContext db = new EFContext())
            {

                db.Database.Log = s => logger.Write(s);
                db.Employees.Where(e => e.EmployeeID == 0).ToList();

                Console.WriteLine("Press any key to close");
                Console.ReadKey();

            }

        }

    }

    public class EFLogger
    {
        public void Write(string log)
        {
            Console.Write(log);

            //You can write to a file
            //Or to a Database here

        }

    }



}

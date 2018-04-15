using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataServices;
using DataModel;

namespace DataServices
{
    public class InitialDb:SQLite.CodeFirst.SqliteCreateDatabaseIfNotExists<Context>
    {
        public InitialDb(DbModelBuilder modelBuilder) : base(modelBuilder)
        {

        }

        protected override void Seed(Context context)
        {
            var person = new Person()
            {
                FirstName = "Arash",
                LastName = "Goodarzi",
                //Numbers = new List<PhoneBook>()
                //{
                //    new PhoneBook()
                //    {
                //        Field = "Work",
                //        Number = "031551234"
                //    },
                //    new PhoneBook()
                //    {
                //        Field = "Mobile",
                //        Number = "09123456789"
                //    },
                //    new PhoneBook()
                //    {
                //        Field = "Home",
                //        Number = "031554321"
                //    }
                //}
            };

            context.Set<Person>().Add(person);
            base.Seed(context);
        }
    }
}

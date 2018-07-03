using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireDeCourse.data
{
    public class Context : IContext
    {
        public Context(string nameOrConnectionString = "BDPlanning") : base() {
            //Database.SetInitializer<Context>(new CreateDatabaseIfNotExists<Context>());
            //Database.SetInitializer(new ContextSeedInitializer());

        }
        /*
         
        public DbSet<Appelant> Appelants { get; set; }
        public DbSet<Chauffeur> Chauffeurs { get; set; }
        public DbSet<Course> Courses { get; set; }
        
        public DbSet<Home> Homes { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }

        */
    }

    /*public class ContextSeedInitializer : DropCreateDatabaseAlways<MonContexte>
    {
        protected override void Seed(Context context)
        {
            var test = new Test1 { maString = "coucou", montest = "cool" };
            var test2 = new Test2 { monInt = 5, monTest1 = test };

            context.Test1s.Add(test);
            context.Test2s.Add(test2);

            context.SaveChanges();
        }
    }*/
}

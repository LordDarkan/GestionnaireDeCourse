using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionnaireDeCourse.Model;

namespace GestionnaireDeCourse.data
{
    public class Context : DbContext, IContext
    {
        public Context(string nameOrConnectionString = "DBGestionCourse") : base(nameOrConnectionString) {
            //Database.SetInitializer<Context>(new CreateDatabaseIfNotExists<Context>());
            Database.SetInitializer(new ContextSeedInitializer());

        }
        
         
        public DbSet<Appelant> Appelants { get; set; }
        public DbSet<Chauffeur> Chauffeurs { get; set; }
        public DbSet<Course> Courses { get; set; }
        
        public DbSet<Home> Homes { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }

        
    }

    public class ContextSeedInitializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            var test = new Appelant { Id = 795, Nom = "Doe", Prenom = "John", Adresse = "qque part", NumTel = "04/546 64 45"};
            var test2 = new Chauffeur { Nom = "Valjean", Prenom = "Jean", Adresse = "qque part aussi", NumTel = "04/546 64 45" };
            var test3 = new Chauffeur { Nom = "Val", Prenom = "Jean", Adresse = "qque part aussi", NumTel = "04/546 64 45" };

            context.Appelants.Add(test);
            context.Chauffeurs.Add(test2);
            context.Chauffeurs.Add(test3);

            context.SaveChanges();
        }
    }
}

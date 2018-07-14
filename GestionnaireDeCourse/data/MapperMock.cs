using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionnaireDeCourse.Model;

namespace GestionnaireDeCourse.data
{
    public class MapperMock : IMapper
    {
        private List<Appelant> appelants;
        private List<Chauffeur> chauffeurs;
        private List<Course> courses;
        private List<Home> homes;
        private List<Hospital> hospitals;

        public MapperMock()
        {
            this.chauffeurs = new List<Chauffeur>();
            this.courses = new List<Course>();
            this.homes = new List<Home>();
            this.hospitals = new List<Hospital>();
            this.appelants = new List<Appelant>();
            data();
        }

        private void data()
        {

            Chauffeur chauffeur = new Chauffeur { Nom = "Valjean", Prenom = "Jean", Adresse = "qque part aussi", NumTel = "04/546 64 45" };
            chauffeurs.Add(chauffeur);
            chauffeur = new Chauffeur { Nom = "Val", Prenom = "Jean", Adresse = "qque part aussi", NumTel = "04/546 64 45" };
            chauffeurs.Add(chauffeur);


            Appelant appelant = new Appelant { Id = 795, Nom = "Doe", Prenom = "John", Adresse = "qque part", NumTel = "04/546 64 45" };
            appelants.Add(appelant);
        }
    }
}

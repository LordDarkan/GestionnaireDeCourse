using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireDeCourse.Model
{
    public class Chauffeur : IComparable<Chauffeur>
    {
        public long Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string NumTel { get; set; }
        public string Adresse { get; set; }


        public int CompareTo(Chauffeur other)
        {
            int resultat = String.Compare(Nom, other.Nom, StringComparison.OrdinalIgnoreCase);
            if (resultat == 0)
            {
                resultat = String.Compare(Prenom, other.Prenom, StringComparison.OrdinalIgnoreCase);
            }
            return resultat;
        }

        public Chauffeur Clone()
        {
            return new Chauffeur
            {
                Id = Id,
                Nom = Nom,
                Prenom = Prenom,
                NumTel = NumTel,
                Adresse = Adresse
            };
        }
    }
}

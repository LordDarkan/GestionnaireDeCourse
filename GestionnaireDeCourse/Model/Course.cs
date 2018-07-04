using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireDeCourse.Model
{
    public class Course : IComparable<Course>
    {
        [Key]
        public long CourseId { get; set; }

        public DateTime DateDomicile { get; set; } = DateTime.Now;
        public DateTime DateRdv { get; set; } = DateTime.Now;
        public string Adresse { get; set; }
        public string Destination { get; set; }
        public string Description { get; set; }

        public long ChauffeurId { get; set; }
        public virtual Chauffeur Chauffeur { get; set; }


        public string DateStr => DateDomicile.ToString("D");
        public int CompareTo(Course other)
        {
            int resultat = DateDomicile.CompareTo(other.DateDomicile);
            if (resultat == 0)
            {
                resultat = Chauffeur.CompareTo(other.Chauffeur);
            }
            return resultat;
        }

        public Course Clone()
        {
            return new Course
            {
                CourseId = CourseId,
                DateDomicile = DateDomicile.ToLocalTime(),
                DateRdv = DateRdv.ToLocalTime(),
                Adresse = Adresse,
                Destination = Destination,
                Description = Description
            };
        }
    }
}

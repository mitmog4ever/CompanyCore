using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Categorie
    {
        public Categorie()
        {
            Departements = new HashSet<Departement>();
        }

        public int IdCat { get; set; }
        public string DescriptionCat { get; set; }

        public virtual ICollection<Departement> Departements { get; set; }
    }
}

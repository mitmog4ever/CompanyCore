using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    [Table("Categorie")]
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

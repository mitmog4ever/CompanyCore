using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Departement
    {
        public Departement()
        {
            Employees = new HashSet<Employee>();
        }

        public int IdDep { get; set; }
        public string NomDep { get; set; }
        public string DescriptionDep { get; set; }
        public DateTime DateCreat { get; set; }
        public int IdCat { get; set; }

        public virtual Categorie IdCatNavigation { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}

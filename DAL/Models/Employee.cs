using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{   [Table("Employee")]
    public partial class Employee
    {
        public int IdEmp { get; set; }
        public string NomEmp { get; set; }
        public string PrenomEmp { get; set; }
        public double SalaireEmp { get; set; }
        public DateTime DateRecruteEmp { get; set; }
        public double TeleEmp { get; set; }
        public int IdDep { get; set; }

        public virtual Departement IdDepNavigation { get; set; }
    }
}

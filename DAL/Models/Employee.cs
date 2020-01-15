using System;
using System.Collections.Generic;

namespace DAL.Models
{
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

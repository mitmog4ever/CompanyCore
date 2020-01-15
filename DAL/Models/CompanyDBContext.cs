using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.Models
{
    public partial class CompanyDBContext : DbContext
    {
        public CompanyDBContext()
        {
        }

        public CompanyDBContext(DbContextOptions<CompanyDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categorie> Categories { get; set; }
        public virtual DbSet<Departement> Departements { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
    }
}

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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-3OSV42E\\SQLEXPRESS;Database=CompanyDB;Trusted_Connection=True;User ID=sa;password=Tiog*1991Mitmog*1991");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorie>(entity =>
            {
                entity.HasKey(e => e.IdCat);

                entity.Property(e => e.IdCat)
                    .HasColumnName("id_cat")
                    .ValueGeneratedNever();

                entity.Property(e => e.DescriptionCat)
                    .IsRequired()
                    .HasColumnName("description_cat")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Departement>(entity =>
            {
                entity.HasKey(e => e.IdDep);

                entity.Property(e => e.IdDep).HasColumnName("id_dep");

                entity.Property(e => e.DateCreat)
                    .HasColumnName("Date_creat")
                    .HasColumnType("date");

                entity.Property(e => e.DescriptionDep)
                    .IsRequired()
                    .HasColumnName("description_dep")
                    .HasMaxLength(250);

                entity.Property(e => e.IdCat).HasColumnName("id_cat");

                entity.Property(e => e.NomDep)
                    .IsRequired()
                    .HasColumnName("nom_dep")
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdCatNavigation)
                    .WithMany(p => p.Departements)
                    .HasForeignKey(d => d.IdCat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Departements_Categorie");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.IdEmp);

                entity.Property(e => e.IdEmp).HasColumnName("id_emp");

                entity.Property(e => e.DateRecruteEmp)
                    .HasColumnName("date_recrute_emp")
                    .HasColumnType("date");

                entity.Property(e => e.IdDep).HasColumnName("id_dep");

                entity.Property(e => e.NomEmp)
                    .IsRequired()
                    .HasColumnName("nom_emp")
                    .HasMaxLength(50);

                entity.Property(e => e.PrenomEmp)
                    .IsRequired()
                    .HasColumnName("prenom_emp")
                    .HasMaxLength(50);

                entity.Property(e => e.SalaireEmp).HasColumnName("Salaire_emp");

                entity.Property(e => e.TeleEmp).HasColumnName("tele_emp");

                entity.HasOne(d => d.IdDepNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.IdDep)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employees_Departements");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

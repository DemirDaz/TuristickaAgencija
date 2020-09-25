using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba1.BazaPodataka
{
    class DbStudentskaSl : DbContext
    {
        public DbSet<Departman> Departmans { get; set; }
        public DbSet<Predmet> Predmets { get; set; }
        public DbSet<Korisnik> Korisniks { get; set; }
        public DbSet<PolozeniIspiti> PolozeniIspitis { get; set; }
        public DbSet<Profesor> Profesors { get; set; }
        public DbSet<Referent> Referents { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StatusStudenta> StatusStudentas { get; set; }
        public DbSet<StudijskiProgram> StudijskiPrograms { get; set; }
        public object StatusStudenta { get; internal set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Korisnik>().HasKey(k => k.KorisnickoIme);
            modelBuilder.Entity<Korisnik>().Property(k => k.Lozinka).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<Korisnik>().Property(k => k.Ime).IsRequired().HasMaxLength(25);
            modelBuilder.Entity<Korisnik>().Property(k => k.Prezime).IsRequired().HasMaxLength(30);
            modelBuilder.Entity<Korisnik>().Property(ca => ca.Lozinka).HasMaxLength(20);

            modelBuilder.Entity<Departman>().HasKey(i => i.IdDepartmana);
            modelBuilder.Entity<Departman>().Property(k => k.ImeDepartmana).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Departman>().HasIndex(k => k.ImeDepartmana).IsUnique();

            modelBuilder.Entity<PolozeniIspiti>().HasKey(i => i.IdIspit);
            modelBuilder.Entity<PolozeniIspiti>().Property(k => k.idProfesora).IsRequired();
            modelBuilder.Entity<PolozeniIspiti>().Property(k => k.brIndeksa).IsRequired();
            modelBuilder.Entity<PolozeniIspiti>().Property(k => k.Sifra).IsRequired();
            modelBuilder.Entity<PolozeniIspiti>().HasRequired(b => b.Profesor).WithMany(a => a.PolozeniIspitis).HasForeignKey(b => b.idProfesora);
            modelBuilder.Entity<PolozeniIspiti>().HasRequired(b => b.Predmet).WithMany(a => a.PolozeniIspitis).HasForeignKey(b => b.Sifra);
            modelBuilder.Entity<PolozeniIspiti>().Property(k => k.datumPolaganja).IsRequired();
            modelBuilder.Entity<PolozeniIspiti>().Property(k => k.Ocena).IsRequired();

            modelBuilder.Entity<Predmet>().HasKey(s => s.Sifra);
            modelBuilder.Entity<Predmet>().Property(k => k.IdStudProg).IsRequired();
            modelBuilder.Entity<Predmet>().Property(k => k.NazivPredmeta).IsRequired().HasMaxLength(30);
            modelBuilder.Entity<Predmet>().HasRequired(b => b.StudijskiProgram).WithMany(a => a.Predmets).HasForeignKey(b => b.IdStudProg);

            modelBuilder.Entity<Profesor>().HasKey(i => i.IdProfesora);

            modelBuilder.Entity<Profesor>().Property(k => k.Ime).IsRequired().HasMaxLength(25);
            modelBuilder.Entity<Profesor>().Property(k => k.Prezime).IsRequired().HasMaxLength(30);

            modelBuilder.Entity<Student>().HasKey(i => i.IdStudent);
            modelBuilder.Entity<Student>().Property(k => k.brIndeksa).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<Student>().HasIndex(k => k.brIndeksa).IsUnique();
            modelBuilder.Entity<Student>().Property(k => k.Ime).IsRequired().HasMaxLength(25);
            modelBuilder.Entity<Student>().Property(k => k.Prezime).IsRequired().HasMaxLength(30);
            modelBuilder.Entity<Student>().Property(k => k.JMBG).IsRequired().HasMaxLength(13);
            modelBuilder.Entity<Student>().HasIndex(k => k.JMBG).IsUnique();


            modelBuilder.Entity<StudijskiProgram>().HasKey(i => i.IdStudProg);
            modelBuilder.Entity<StudijskiProgram>().Property(k => k.IdDepartmana).IsRequired();
            modelBuilder.Entity<StudijskiProgram>().Property(k => k.ImeSP).IsRequired().HasMaxLength(40);
            modelBuilder.Entity<StudijskiProgram>().HasRequired(b => b.Departman).WithMany(a => a.StudijskiPrograms).HasForeignKey(b => b.IdDepartmana);
            

            modelBuilder.Entity<Referent>().HasKey(i => i.IdReferenta);
            modelBuilder.Entity<Referent>().Property(k => k.Ime).IsRequired().HasMaxLength(25);
            modelBuilder.Entity<Referent>().Property(k => k.Prezime).IsRequired().HasMaxLength(30);

            modelBuilder.Entity<StatusStudenta>().HasKey(i => i.IdStatusa);

        }
    }
}

using StudentskaSluzba1.IRepository;
using StudentskaSluzba1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba1.BazaPodataka
{
    class UnitOfWork : IUnitOfWork
    {
        private BazaPodataka.DbStudentskaSl context;
        private DepartmanRepository departman;
        private KorisnikRepository korisnik;
        private PolozeniIspitiRepository polozeniIspiti;
        private PredmetRepository predmet;
        private ProfesorRepository profesor;
        private ReferentRepository referent;
        private IStatusStudRepository statusStudenta;
        private StudentRepository student;
        private StudijskiProgramRepository studijskiProgram;
        public UnitOfWork(DbStudentskaSl context)
        {
            this.context = context;
        }
        public IDepartmanRepository Departmans
        {
            get
            {
                return departman ?? (departman = new DepartmanRepository(context));
            }
        }


        public IKorisnikRepository Korisniks
        {
            get
            {
                return korisnik ?? (korisnik = new KorisnikRepository(context));
            }
        }

        public IPolozeniISpitiRepository PolozeniISpitis
        {
            get
            {
                return polozeniIspiti ?? (polozeniIspiti = new PolozeniIspitiRepository(context));
            }
        }

        public IPredmetRepository Predmets
        {
            get
            {
                return predmet ?? (predmet = new PredmetRepository(context));
            }
        }

        public IProfesorRepository Profesors
        {
            get
            {
                return profesor ?? (profesor = new ProfesorRepository(context));
            }
        }

        public IReferentRepository Referents
        {
            get
            {
                return referent ?? (referent = new ReferentRepository(context));
            }
        }


        public IStudentRepository Students
        {
            get
            {
                return student ?? (student = new StudentRepository(context));
            }
        }

        public IStudijskiProgramRepository StudijskiPrograms
        {
            get
            {
                return studijskiProgram ?? (studijskiProgram = new StudijskiProgramRepository(context));
            }
        }

        public IStatusStudRepository StatusStudentas
        {
            get
            {
                return statusStudenta ?? (statusStudenta = new StatusStudentaRepository(context));
            }
        }
        public void Complete()
        {
            context.SaveChanges();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

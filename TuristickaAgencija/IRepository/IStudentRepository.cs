using StudentskaSluzba1.BazaPodataka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba1.IRepository
{
    interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents();
        void AddStudents(Student student);
        Student GetStudentsByBrIndeksa(string brIndeksa);
        void DeleteStudents(Student student);
        Student FindByIme(string Ime);
    }
}

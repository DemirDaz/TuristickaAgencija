using StudentskaSluzba1.BazaPodataka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba1.IRepository
{
    interface IStatusStudRepository
    {
        IEnumerable<StatusStudenta> GetAllStatusStudentas();
        void AddStatusStudentas(StatusStudenta statusStudenta);
        StatusStudenta GetStatusStudentasById(int IdStatusStudenta);
        void DeleteStatusStudentas(StatusStudenta statusStudenta);
        StatusStudenta FindByOdslusaniSemestar(int OdslusaniSemestar);
    }
}

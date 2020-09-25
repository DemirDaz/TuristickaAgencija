using StudentskaSluzba1.BazaPodataka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba1.IRepository
{
    interface IPolozeniISpitiRepository
    {
        IEnumerable<PolozeniIspiti> GetAllPolozeniIspitis();
        void AddPolozeniIspitis(PolozeniIspiti polozeniIspiti);
        PolozeniIspiti GetPolozeniIspitisByIdIspit(int idIspit);
        void DeletePolozeniIspitis(PolozeniIspiti polozeniIspiti);
        PolozeniIspiti FindByOcena(int ocena);
        IEnumerable<PolozeniIspiti> ispitiStudenta(string BrIndeksa);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencija
{
    static class Globalne
    {
        public static string email;
        public static int idFil;
        public static bool menadzer;

       
      
        // global int using get/set  ALI NE TREBAJU JER SAMO POZIVANJE PROMENLJIVIH RADI GET SET
        
        public static string getsetemail
        {
            set { email = value; }
            get { return email; }
        }

        public static int getsetfil
        {
            set { idFil = value; }
            get { return idFil; }
        }
    }
}

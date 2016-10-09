using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    interface ISectie:IFacultate
    {
        int Nr_studenti
        {
            get;
            set;
        }
        string Nume_sectie
        {
            get;
            set;
        }
        void AddOrar(Orar Orar);
    }
}

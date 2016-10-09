using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public enum TipOra
    {
        Curs,
        Seminar,
        Laborator,
        Proiect
    }
    interface ICurs
    {
        TipOra Tip
        {
            get;
            set;
        }
        string Nume
        {
            get;
            set;
        }
        string Cadru_didactic
        {
            get;
            set;
        }
        int An_predare
        {
            get;
            set;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class CursFisa:Curs,ICursFisa
    {
        int nota;
        public int Nota
        {
            get { return nota; }
            set { nota = value; }
        }
        public CursFisa(TipOra Tip, string Nume, string Cadru_didactic, int An_predare, int Nota):base(Tip, Nume, Cadru_didactic, An_predare)
        {
            nota = Nota;
        }
    }
}

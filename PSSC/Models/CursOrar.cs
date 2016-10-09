using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class CursOrar:Curs,ICursOrar
    {
        string ora_incepere;
        int durata;
        public string Ora_incepere
        {
            get { return ora_incepere; }
            set { ora_incepere = value; }
        }
        public int Durata
        {
            get { return durata; }
            set { durata = value; }
        }
        public CursOrar(TipOra Tip, string Nume, string Cadru_didactic, int An_predare, string Ora_incepere, int Durata):base(Tip, Nume, Cadru_didactic, An_predare)
        {
            ora_incepere = Ora_incepere;
            durata = Durata;
        }
    }
}

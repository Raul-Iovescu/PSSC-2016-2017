using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Profesor:Sectie,IProfesor
    {
        TipTitlu titlu;
        string nume_profesor;
        public string Nume_profesor
        {
            get { return nume_profesor; }
            set { nume_profesor = value; }
        }
        public TipTitlu Titlu
        {
            get { return titlu; }
            set { titlu = value; }
        }
        public Profesor(string Nume_universitate,string Nume_facultate, string Nume_sectie,TipTitlu Titlu, string Nume_profesor):base(
            Nume_universitate, Nume_facultate,  Nume_sectie)
        {
            nume_profesor = Nume_profesor;
            titlu = Titlu;
        }
    }
}

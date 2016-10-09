using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Sectie:Facultate,ISectie
    {
        int nr_studenti;
        string nume_sectie;
        public int Nr_studenti
        {
            get { return nr_studenti; }
            set { nr_studenti = value; }
        }
        public string Nume_sectie
        {
            get { return nume_sectie; }
            set { nume_sectie = value; }
        }
        public Sectie(string Nume_universitate,string Nume_facultate, string Nume_sectie):base(Nume_universitate,Nume_facultate)
        {
            nume_sectie = Nume_sectie;
        }
        public void AddOrar(Orar Orar)
        {
            /*implementare*/
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    enum TipProportie
    {
        treime,
        jumatate
    }
    enum TipCurs
    {
        distribuit,
        examen
    }
    class Curs
    {
        string nume;
        int nr_credite;
        int an_studiu;
        TipProportie tipProportie;
        TipCurs tipCurs;
        string id_curs;
        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }
        public int Nr_credite
        {
            get { return nr_credite; }
            set { nr_credite = value; }
        }
        public int An_studiu
        {
            get { return an_studiu; }
            set { an_studiu = value; }
        }
        public TipCurs TipCurs
        {
            get { return tipCurs; }
            set { tipCurs = value; }
        }
        public TipProportie TipProportie
        {
            get { return tipProportie; }
            set { tipProportie = value; }
        }
        public string IdCurs
        {
            get { return id_curs; }
            set { id_curs = value; }
        }
        public Curs(string id_curs, string nume, int nr_credite, int an_studiu, TipCurs tipCurs, TipProportie tipProportie)
        {
            this.id_curs = id_curs;
            this.nume = nume;
            this.nr_credite = nr_credite;
            this.an_studiu = an_studiu;
            this.tipCurs = tipCurs;
            this.tipProportie = tipProportie;
        }
    }
}

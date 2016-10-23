using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Student
    {
        string nume;
        int an_studiu;
        int nr_matricol;
        string cnp;
        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }
        public int An_studiu
        {
            get { return an_studiu; }
            set { an_studiu = value; }
        }
        public int Nr_matricol
        {
            get { return nr_matricol; }
            set { nr_matricol = value; }
        }
        public string Cnp
        {
            get { return cnp; }
            set { cnp = value; }
        }
        public Student(string nume, int nr_matricol,string cnp)
        {
            this.nume = nume;
            this.nr_matricol = nr_matricol;
            this.cnp = cnp;
        }
    }
}

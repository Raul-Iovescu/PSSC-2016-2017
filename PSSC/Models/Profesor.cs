using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Profesor
    {
        string nume;
        List<Curs> cursuri = new List<Curs>();
        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }
        public Profesor(string nume, List<Curs> cursuri)
        {
            this.nume = nume;
            this.cursuri = cursuri;
        }
        public List<Curs> Cursuri
        {
            get { return cursuri; }
          
        }
    }
}

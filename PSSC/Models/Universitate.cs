using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Universitate:IUniversitate
    {
        string nume_universitate;
        public string Nume_Universitate
        {
            get { return nume_universitate; }
            set { nume_universitate = value; }
        }
        public Universitate(string Nume_universitate)
        {
            nume_universitate = Nume_universitate;
        }
    }
}

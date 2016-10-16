using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Nota
    {

        List<int> note_prezentari = new List<int>();
        List<int> note_prezentari_distribuita = new List<int>();
        int nota_activitate;
        List<int> prezenta_laborator = new List<int>();
        bool promovat = false;
        public List<int> Note_prezentari
        {
            get { return note_prezentari; }
        }
        public List<int> Note_prezentari_distribuita
        {
            get { return note_prezentari_distribuita; }
        }
            public List<int> Prezenta_laborator
        {
            get { return prezenta_laborator; }

        }
        public void AddPrezenta_laborator(int nrSaptamana)
        {
            prezenta_laborator.Add(nrSaptamana);
        }
        public void AddNota(int nota)
        {
            note_prezentari.Add(nota);
        }
        public void AddNota(int nota1,int nota2)
        {
            note_prezentari.Add(nota1);
            note_prezentari_distribuita.Add(nota2);
        }
        public int Nota_activitate
        {
            get { return nota_activitate; }
            set { nota_activitate = value; }
        }
        public void Medie()
        {
            //calculare medie si setare promovat
        }
    }
}

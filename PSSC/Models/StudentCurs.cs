using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class StudentCurs
    {
        string cnp;
        string id_curs;
        int nota_prez1;
        int nota_prez2;
        int nota_prez3;
        int nota_laborator;
        int nota_distribuita_prez1;
        int nota_distribuita_prez2;
        int nota_distribuita_prez3;
        public int NotaPrez1
        {
            get { return nota_prez1; }
            set { nota_prez1 = value; }
        }
        public int NotaPrez2
        {
            get { return nota_prez2; }
            set { nota_prez2 = value; }
        }
        public int NotaPrez3
        {
            get { return nota_prez3; }
            set { nota_prez3 = value; }
        }
        public int NotaDistribuitaPrez1
        {
            get { return nota_distribuita_prez1; }
            set { nota_distribuita_prez1 = value; }
        }
        public int NotaDistribuitaPrez2
        {
            get { return nota_distribuita_prez2; }
            set { nota_distribuita_prez2 = value; }
        }
        public int NotaDistribuitaPrez3
        {
            get { return nota_distribuita_prez3; }
            set { nota_distribuita_prez3 = value; }
        }
        public int NotaLaborator
        {
            get { return nota_laborator; }
            set { nota_laborator = value; }
        }
        public StudentCurs(string cnp, string id_curs)
        {
            this.cnp = cnp;
            this.id_curs = id_curs;
        }
    }
}

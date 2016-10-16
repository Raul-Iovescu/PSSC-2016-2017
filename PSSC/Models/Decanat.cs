using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Decanat
    {
        List<Curs> cursuri = new List<Curs>();
        List<Profesor> profesori = new List<Profesor>();
        List<Student> studenti = new List<Student>();
        public void AddCurs(Curs c)
        {
            cursuri.Add(c);
        }
        public void AddProfesor(Profesor p)
        {
            profesori.Add(p);
        }
        public void AddStudent(Student s)
        {
            studenti.Add(s);
        }
        public void Printare_raport_MedieGenerala(Student s)
        {

        }
        public void Printare raport_MedieCurs(Student s, Curs c)
        {

        }
        

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simple.Data;
namespace Models
{
    class Decanat
    {

        public void AddCurs(Curs c)
        {
            Database.Open().Curs.Insert(c);
        }
        public void AddProfesor(Profesor p)
        {
            Database.Open().Profesori.Insert(p);
        }
        public void AddStudent(Student s)
        {
            Database.Open().Studenti.Insert(s);
        }
        public void AddProfesorToCurs(Profesor p, Curs c)
        {
           var profesorcurs = new ProfesorCurs(p.Nume,c.IdCurs);
           Database.Open().ProfesorCurs.Insert(profesorcurs);
        }
        public void AddStudentToCurs(Student s, Curs c)
        {
            var studentCurs = new StudentCurs(s.Cnp, c.IdCurs);
            Database.Open().StudentCurs.Insert(studentCurs);
        }
        public float GetMedieGeneralaStudent(Student s)
        {
            var studentCurs = Database.Open().StudentCurs.FindAllByCnp(s.Cnp);
            int i = 0;
            int suma = 0;
            foreach (var student in studentCurs)
            {
                i++;
                suma += Math.Max(student.NotaPrez1, Math.Max(student.NotaPrez2, student.NotaPrez3));
            }
            return (float)suma / i;
        }
        public int GetMedieStudentCurs(Student s, Curs c)
        {
            var studentCurs = Database.Open().StudentCurs.FindAllByCnpAndIdCurs(s.Cnp,c.IdCurs);
            return Math.Max(studentCurs.NotaPrez1, Math.Max(studentCurs.NotaPrez2, studentCurs.NotaPrez3));
        }
    }
}

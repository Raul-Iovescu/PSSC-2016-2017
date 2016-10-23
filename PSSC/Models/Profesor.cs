using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simple.Data;
namespace Models
{
    class Profesor
    {
        string nume;
        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }
        public Profesor(string nume)
        {
            this.nume = nume;
        }
        public void SetNotaExamen(Student s, Curs c, int nr_prez,int nota)
        {
            var profesorcurs = Database.Open().ProfesorCurs.FindAllByNumeAndIdCurs(this.Nume,c.IdCurs);
            foreach (var profesor in profesorcurs)
            {
                var numeGasit = profesor.Nume;
                if(numeGasit == this.Nume)
                {
                    var studentCurs = Database.Open().StudentCurs.FindAllByCnpAndIdCurs(s.Cnp, c.IdCurs);
                    if(nr_prez == 1)
                    {
                        studentCurs.NotaPrez1 = nota;
                    }
                    if (nr_prez == 2)
                    {
                        studentCurs.NotaPrez2 = nota;
                    }
                    if (nr_prez == 3)
                    {
                        studentCurs.NotaPrez3 = nota;
                    }
                    Database.Open().StudentCurs.UpdateByCnpAndIdCurs(studentCurs);
                }
            }   
        }
        public void SetNotaLaborator(Student s, Curs c,int nota)
        {
            var profesorcurs = Database.Open().ProfesorCurs.FindAllByNumeAndIdCurs(this.Nume, c.IdCurs);
            foreach (var profesor in profesorcurs)
            {
                var numeGasit = profesor.Nume;
                if (numeGasit == this.Nume)
                {
                    var studentCurs = Database.Open().StudentCurs.FindAllByCnpAndIdCurs(this.Nume, c.IdCurs);
                    studentCurs.NotaLaborator = nota;
                    Database.Open().StudentCurs.UpdateByCnpAndIdCurs(studentCurs);
                }
            }   
        }
        public void SetNotaDistribuita(Student s, Curs c, int nr_prez,int nota1,int nota2)
        {
            var profesorcurs = Database.Open().ProfesorCurs.FindAllByNumeAndIdCurs(this.Nume,c.IdCurs);
            foreach (var profesor in profesorcurs)
            {
                var numeGasit = profesor.Nume;
                if(numeGasit == this.Nume)
                {
                    var studentCurs = Database.Open().StudentCurs.FindAllByCnpAndIdCurs(s.Cnp, c.IdCurs);
                    if(nr_prez == 1)
                    {
                        studentCurs.NotaPrez1 = nota1;
                        studentCurs.NotaDistribuitaPrez1 = nota2;
                    }
                    if (nr_prez == 2)
                    {
                        studentCurs.NotaPrez2 = nota1;
                        studentCurs.NotaDistribuitaPrez1 = nota2;
                    }
                    if (nr_prez == 3)
                    {
                        studentCurs.NotaPrez3 = nota1;
                        studentCurs.NotaDistribuitaPrez1 = nota2;
                    }
                    Database.Open().StudentCurs.UpdateByCnpAndIdCurs(studentCurs);
                }
            }   
        }
        public void SetProportieCurs(Curs c, TipProportie tip)
        {
            var profesorcurs = Database.Open().ProfesorCurs.FindAllByNumeAndIdCurs(this.Nume, c.IdCurs);
            profesorcurs.TipProportie = tip;
            Database.Open().ProfesorCurs.UpdateByIdCurs(profesorcurs);
        }
    }
}

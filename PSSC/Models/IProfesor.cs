using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public enum TipTitlu
    {
        Profesor,
        Conferentiar,
        Sef_lucrari,
        Asistent,
        Doctorand
    }
    interface IProfesor:ISectie
    {
        string Nume_profesor
        {
            get;
            set;
        }
        TipTitlu Titlu
        {
            get;
            set;
        }
    }
}

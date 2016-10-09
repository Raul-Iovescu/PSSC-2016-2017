using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    interface IStudent:ISectie
    {
        string Nume_student
        {
            get;
            set;
        }
        string Nr_matricol
        {
            get;
            set;
        }
        string CNP
        {
            get;
            set;
        }
        int An_studiu
        {
            get;
            set;
        }
    }
}

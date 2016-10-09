using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    interface IFacultate:IUniversitate
    {
        string Nume_facultate
        {
            get;
            set;
        }
    }
}

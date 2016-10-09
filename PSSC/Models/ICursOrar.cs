using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    interface ICursOrar:ICurs
    {
        string Ora_incepere
        {
            get;
            set;
        }
        int Durata
        {
            get;
            set;
        }
    }
}

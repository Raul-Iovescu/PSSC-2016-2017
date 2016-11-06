using Models.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Common
{
    //Entity
    /*Clasa Profesor care e generala in toate cele 3 contexte*/
    public class Professor
    {
        public PlainText Name { get; internal set; }

        public Professor(PlainText name)
        {
            Name = name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseTva
{
      public abstract class ClassPays
    {
        public abstract decimal calculTva(decimal montantTht);

    }
}
//public  interface IPays
//{
//    decimal CalculTva(decimal montantThc);

//} Ici au lieu de définir une classe pays on peut la définire comme une interface en créant une interface

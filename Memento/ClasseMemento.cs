using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class ClasseMemento
    {
        public List<string> options = new List<string>();

        protected string Etat;

        public string GetEtat(string Etat)
        {
            return "MonChariot est d'état " + Etat;

        }
        public string SetEtat(string option )
        {
            return Etat=option;

        }


    }
}

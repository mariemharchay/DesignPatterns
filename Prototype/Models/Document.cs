using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
    public abstract class Document
    {
        protected string contenu = "";
        //public Document(string contenu)
        //{
        //    this.contenu = contenu;
        //}
        public Document Duplique()
        {
            Document resultat;
            resultat = (Document)this.MemberwiseClone();
            return resultat;
        }
        public  abstract void Imprime();
        public  abstract void Affiche();
        public  void Remplit(string Informations)
        {
            contenu = Informations;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class Liasse
    {
        public List<string> contenu = new List<string>();
        //protected string Nom{ get; set; }
        //protected string Type { get; set; }    

        public abstract void AjouterDocument(string document);
        public abstract void Imprimer();
    }
}

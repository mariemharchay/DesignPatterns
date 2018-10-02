using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
    public class CertificatCession:Document
    {
        public override void Imprime()
        {
            Console.WriteLine("Imprimer le certificat de session " + contenu);
        }
        public override void Affiche()
        {
            Console.WriteLine("Afficher le certificat de session " + contenu);
        }
    }
}

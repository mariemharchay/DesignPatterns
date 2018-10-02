using Prototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class DemandeImmatriculation : Document
    {
        public override void Imprime()
        {
            Console.WriteLine("Imprimer le DemandeImmatriculation " + contenu);
        }
        public override void Affiche()
        {
            Console.WriteLine("Afficher le DemandeImmatriculation " + contenu);
        }


    }
}

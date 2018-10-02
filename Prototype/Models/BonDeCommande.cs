using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
    public class BonDeCommande:Document

    {
        //public BonDeCommande(string type):base ( type) { }
        public override void Imprime()
        {
            Console.WriteLine("Imprimer le bon de commande " + contenu);
        }
        public override void Affiche()
        {
            Console.WriteLine("Afficher le bon de commande " + contenu);
        }
    }
}

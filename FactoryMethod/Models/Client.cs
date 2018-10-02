using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Client
    {
        protected IList<Commande> commandes = new List<Commande>();

        protected abstract Commande CreeCommande(double montant);

        public void nouvelleCommande(double montant)
        {
            Commande commande = this.CreeCommande(montant);
            if (commande.Valider())
            {
                commande.Payer();
                commandes.Add(commande);
            }
        }

    }
}

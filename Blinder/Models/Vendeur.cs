
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Vendeur
    {
        protected ConstructeurLiasseVehicule constructeur;

        public Vendeur(ConstructeurLiasseVehicule constructeur)
        {
            this.constructeur = constructeur;
        }

        public Liasse construit(string nomClient)
        {
            constructeur.ConstruitBonDeCommande(nomClient);
            constructeur.ConstruitDemandeImmatriculation(nomClient);
            Liasse liasse = constructeur.resultat();
            return liasse;
        }
    }
}

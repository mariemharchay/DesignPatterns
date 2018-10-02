using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ConstructeurLiasseVehiculeHtml : ConstructeurLiasseVehicule
    {
        public ConstructeurLiasseVehiculeHtml()
        {
            liasse = new LiasseHtml();
        }

        public override void ConstruitBonDeCommande(string nomClient)
        {
            string document = "<HTML>Bon de commande Client : " + nomClient + "</HTML>";
            liasse.AjouterDocument(document);
        }

        public override void ConstruitDemandeImmatriculation(string nomDemandeur)
        {
            string document = "<HTML>Demande d'immatriculation Demandeur : " + nomDemandeur + "</HTML>";
            liasse.AjouterDocument(document);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Models
{
    public class ConstructeurLiasseVehiculeDoc : ConstructeurLiasseVehicule
    {
        public ConstructeurLiasseVehiculeDoc()
        {
            liasse = new LiasseDoc();
        }

        public override void ConstruitBonDeCommande(string nomClient)
        {
            string document = "<Doc>Bon de commande Client : " + nomClient + "</Doc>";
            liasse.AjouterDocument(document);
        }

        public override void ConstruitDemandeImmatriculation(string nomDemandeur)
        {
            string document = "<Doc>Demande d'immatriculation Demandeur : " + nomDemandeur + "</Doc>";
            liasse.AjouterDocument(document);
        }
    }
}

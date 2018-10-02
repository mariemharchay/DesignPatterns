using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ConstructeurLiasseVehiculePdf:ConstructeurLiasseVehicule
    {
        public ConstructeurLiasseVehiculePdf()
        {
            liasse = new LiassePdf();
        }

        public override void ConstruitBonDeCommande(string
          nomClient)
        {
            string document = "<PDF>Bon de commande Client : " + nomClient + "</PDF>";
            liasse.AjouterDocument(document);
        }

        public override void ConstruitDemandeImmatriculation(string nomDemandeur)
        {
            string document = "<PDF>Demande d'immatriculation Demandeur : " + nomDemandeur + "</PDF>";
            liasse.AjouterDocument(document);
        }
    }
}

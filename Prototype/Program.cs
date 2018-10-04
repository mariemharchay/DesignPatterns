using Prototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            LiasseVierge liasseVierge = LiasseVierge.Instance();
            liasseVierge.ajoute(new BonDeCommande());
            liasseVierge.ajoute(new CertificatCession());
            liasseVierge.ajoute(new DemandeImmatriculation());
            // cr¨¦tion d'une nouvelle liasse pour deux clients
            LiasseClient liasseClient1 = new LiasseClient(
              "Martin");
            liasseClient1.affiche();

            LiasseClient liasseClient2 = new LiasseClient(
              "Durant");
            liasseClient2.affiche();
        }
    }
}

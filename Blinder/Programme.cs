
using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Builder
{
    class Programme
    {
        static void Main(string[] args)
        {

            ConstructeurLiasseVehicule constructeur;
            Console.WriteLine("Voulez-vous construire " + "des liasses HTML (1) ou PDF (2) ou Doc(3) :");
            string choix = Console.ReadLine();
            if (choix == "1")
            {
                constructeur = new ConstructeurLiasseVehiculeHtml();
            }
            else if (choix == "2")
            {
                constructeur = new ConstructeurLiasseVehiculePdf();
            }
            else
            {
                constructeur = new ConstructeurLiasseVehiculeDoc();

            }
            Vendeur vendeur = new Vendeur(constructeur);
            Liasse liasse = vendeur.construit("Martin");
            liasse.Imprimer();

        }
    }
    }



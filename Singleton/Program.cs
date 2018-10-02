using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        public static void affiche()

        {
            Vendeur leVendeur = Vendeur.Instance();
        leVendeur.affiche();
        }
        static void Main(string[] args)
        {




            // initialisation du vendeur du système
            Vendeur leVendeur = Vendeur.Instance();
            leVendeur.nom = "Vendeur Auto";
            leVendeur.adresse = "Paris";
            leVendeur.email = "vendeur@vendeur.com";
            // affichage du vendeur du système
            affiche();
            Console.WriteLine(leVendeur.GetHashCode());
            Vendeur leVendeur2 = Vendeur.Instance();
            leVendeur2.nom = "Vendeur Auto Godwin";
            leVendeur2.adresse = "Lyon";
            leVendeur2.email = "vendeur@vendeurgodwin.com";
            affiche();
            Console.WriteLine(leVendeur2.GetHashCode()); 
            Vendeur vendeur3 = new Vendeur() { nom = "vvvv",adresse = "nnnn", email = "test" };
            vendeur3.affiche();
            Console.WriteLine(vendeur3.GetHashCode()); 


            }
        }
    }


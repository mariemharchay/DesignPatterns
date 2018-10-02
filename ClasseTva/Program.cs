using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseTva
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassCommande commande = new ClassCommande();
            ClassPays france = new ClassFrance();
            commande.pays = france;
            decimal prixht = 1896.6M;
            Console.WriteLine("Le prix hors Taxe en france est " + prixht);
            Console.WriteLine("Le prix TTC en france est " + commande.calculMontantTtc(prixht));
            Console.WriteLine("Le taux de TVA en france est " + commande.calculTva(prixht));


            ClassPays luxembourg = new ClassLuxembourg();
            commande.pays = luxembourg;
            decimal prixhtl = 2489.6M;
            Console.WriteLine("Le prix hors Taxe en france est " + prixhtl);
            Console.WriteLine("Le prix TTC en france est " + commande.calculMontantTtc(prixhtl));
            Console.WriteLine("Le taux de TVA en france est " + commande.calculTva(prixhtl));
        }
    }
}

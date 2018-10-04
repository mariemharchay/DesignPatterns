using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsabilityy
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjetBase vehicule1 = new Vehicule(
        "Auto++ KT500 Véhicule d'occasion en bon état ");
            Console.WriteLine(vehicule1.DonneDescription());
            ObjetBase modele1 = new Modele("KT400",
                                           "Le véhicule spacieux et confortable");
            ObjetBase vehicule2 = new Vehicule(null);
            vehicule2.Suivant = modele1;
            Console.WriteLine(vehicule2.DonneDescription());
            ObjetBase marque1 = new Marque("Auto++",
                                           "La marque des autos", "de grande qualité");
            ObjetBase modele2 = new Modele("KT700", null);
            modele2.Suivant = marque1;
            ObjetBase vehicule3 = new Vehicule(null);
            vehicule3.Suivant = modele2;
            Console.WriteLine(vehicule3.DonneDescription());
            ObjetBase vehicule4 = new Vehicule(null);
            Console.WriteLine(vehicule4.DonneDescription());

        }
    }
}

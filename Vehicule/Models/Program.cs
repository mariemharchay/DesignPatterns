using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicule.Models;

namespace Vehicule
{
    class Program
    {
        
            public static int nbAutos = 3;
            public static int nbScooters = 2;
            static void Main(string[] args)
        {
            IFabriqueVehicule fabrique;
            Automobile[] autos = new Automobile[nbAutos];
            Scooter[] scooters = new Scooter[nbScooters];
            Console.WriteLine("Voulez-vous utiliser " +
              "des véhicules électriques (1) ou à essence (2) ou hybride (3) :");
            string choix = Console.ReadLine();
            if (choix == "1")
            {
                fabrique = new FabriqueVehiculeElectricite();
            }
            else if (choix == "2")
            {
                fabrique = new FabriqueVehiculeEssence();
            }
            else 
            {
                fabrique = new FabriqueVehiculeHybride();
            }
            
            

            for (int index = 0; index < nbAutos; index++)
                autos[index] = fabrique.CreerAutomobile("standard",
                  "jaune", 6 + index, 3.2);
            for (int index = 0; index < nbScooters; index++)
                scooters[index] = fabrique.CreerScooter("classic",
                  "rouge", 2 + index);
            foreach (Automobile auto in autos)
                auto.AfficherCaracteristique();
            foreach (Scooter scooter in scooters)
                scooter.AfficherCaracteristique();
        }
    }

}
    


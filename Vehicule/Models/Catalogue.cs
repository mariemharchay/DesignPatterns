﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicule.Models
{
    public class Catalogue
    {
        public static int nbAutos = 3;
        public static int nbScooters = 2;

        public void LoadCatalogue()
        {
            IFabriqueVehicule fabrique;
            Automobile[] autos = new Automobile[nbAutos];
            Scooter[] scooters = new Scooter[nbScooters];
            Console.WriteLine("Voulez-vous utiliser " +
              "des véhicules électriques (1) ou à essence (2) :");
            string choix = Console.ReadLine();
            if (choix == "1")
            {
                fabrique = new FabriqueVehiculeElectricite();
            }
            else
            {
                fabrique = new FabriqueVehiculeEssence();
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

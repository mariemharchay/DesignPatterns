﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicule.Models
{
    public class FabriqueVehiculeEssence:IFabriqueVehicule
    {
        public Automobile CreerAutomobile(string modele, string
     couleur, int puissance, double espace)
        {
            return new AutomobileEssence(modele, couleur, puissance, espace);
        }

        public Scooter CreerScooter(string modele, string couleur, int puissance)
        {
            return new ScooterEssence(modele, couleur, puissance);
        }
    }
}


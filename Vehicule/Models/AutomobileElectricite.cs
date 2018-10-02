﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicule
{
   public class AutomobileElectricite:Automobile
    {
        public AutomobileElectricite(string modele, string couleur, int puissance, double espace) :
            base(modele, couleur, puissance, espace)
        { }
        public override  void AfficherCaracteristique()
        {
            Console.WriteLine("Automobile Electrique de type: "+ modele + ", de couleur: " +couleur+
                ",de puissance: " +puissance+",d'espace: "+espace);
        }
    }
}

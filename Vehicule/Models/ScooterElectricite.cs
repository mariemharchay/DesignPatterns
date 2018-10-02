using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicule
{
    public class ScooterElectricite : Scooter
    {
        public ScooterElectricite(string modele, string couleur, int puissance) :
            base(modele, couleur, puissance)
        { }
        public override void AfficherCaracteristique()
        {
            Console.WriteLine("Scooter Electrique de type: " + modele + ", de couleur: " + couleur +
                ",de puissance: " + puissance );
        }
    }
        
}

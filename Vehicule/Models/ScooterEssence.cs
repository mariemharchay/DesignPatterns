using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicule
{
    public class ScooterEssence : Scooter
    {
        public ScooterEssence(string modele, string couleur, int puissance) :
            base(modele, couleur, puissance)
        { }
        public override void AfficherCaracteristique()
        {
            Console.WriteLine("Scooter a essence de type: " + modele + ", de couleur: " + couleur +
                ",de puissance: " + puissance);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicule.Models
{
    public class ScooterHybride:Scooter
    {
        public ScooterHybride(string modele, string couleur, int puissance) :
            base(modele, couleur, puissance)
        { }
        public override void AfficherCaracteristique()
        {
            Console.WriteLine("Scooter Hybride de type: " + modele + ", de couleur: " + couleur +
                ",de puissance: " + puissance);
        }
    }
}

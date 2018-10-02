using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicule
{
    public class AutomobileEssence:Automobile
    {
        public AutomobileEssence(string modele, string couleur, int puissance, double espace) :
                    base(modele, couleur, puissance, espace)
        { }
        public override void AfficherCaracteristique()
        {
            Console.WriteLine("Automobile a essence de type: " + this.modele + ", de couleur: " + couleur +
                ",de puissance: " + puissance + ",d'espace: " + espace);
        }

    }
}

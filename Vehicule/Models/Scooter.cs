using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicule
{
    public abstract class Scooter
    {
        protected string modele { get; set; }
        protected string couleur { get; set; }
        protected int  puissance { get; set; }
        
        public Scooter(string modele, string couleur, int puissance)
        {
            this.modele = modele;
            this.couleur = couleur;
            this.puissance = puissance;
           

    }
        public abstract void AfficherCaracteristique();
    }
}

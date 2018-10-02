using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicule
{
    public abstract class Automobile
    {
        protected string modele { get; set; }
        protected string couleur { get; set; }
        protected int puissance { get; set; }
        protected double espace { get; set; }
        public Automobile(string modele, string couleur, int puissance, double espace)
        {
            this.modele = modele;
            this.couleur = couleur;
            this.puissance = puissance;
            this.espace = espace;

        }
        public abstract void AfficherCaracteristique();
    }
}


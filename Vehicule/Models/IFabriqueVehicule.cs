using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicule
{
    public interface IFabriqueVehicule
    {
        //public string Nom { get; set; }
        //public void CreerScooter()
        //{

        //}
        //public void CreerAutomobile()
        //{ }
       Automobile CreerAutomobile(string modele, string couleur, int puissance, double espace);
       Scooter CreerScooter (string modele, string couleur, int puissance);
        
    }
}


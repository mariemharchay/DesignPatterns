using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsabilityy
{
    public abstract class ObjetBase
    {
        public ObjetBase Suivant { protected get; set; }
        private string DescriptionParDefaut()
        {
            return "Description Par Default";
        }
        protected abstract string description { get; }
               
        public  string DonneDescription()
        {
            string resultat;
            resultat = this.description;
            if (resultat != null)
                return resultat;
            if (Suivant != null)
                return Suivant.DonneDescription();
            else
                return this.DescriptionParDefaut();
            

    }
        

    }
}

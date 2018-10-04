using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsabilityy
{
    public class Modele : ObjetBase
    {
        //public string modele { get; set; } 
        //protected override void GetDescription(string Type)
        //{
        //    Console.WriteLine(" mon objet est de modele "+ modele); ;
        //}
        protected string laDescription;
        protected string nom;

        public Modele(string nom, string description)
        {
            this.laDescription = description;
            this.nom = nom;
        }

        protected override string description
        {
            get
            {
                if (laDescription != null)
                    return "Modèle " + nom + " : " + laDescription;
                else
                    return null;
            }
        }
    }
}

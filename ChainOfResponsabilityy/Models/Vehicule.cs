using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsabilityy
{
    public class Vehicule : ObjetBase
    {
        //protected Vehicule vehicule = new Vehicule();
        protected string laDescription;

        public Vehicule(string description)
        {
            this.laDescription = description;
        }

        protected override string description
        {
            get
            {
                return laDescription;
            }
        }
    }
}

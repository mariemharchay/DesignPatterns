using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseTva
{
    public class ClassCommande
    {
        public ClassPays pays { get; set; }
        public decimal montantTtc { get; set; }
        public decimal montantTht { get; set; }

        public decimal calculMontantTtc(decimal montantTht)
        {
            return montantTht + this.calculTva(montantTht);
        }

        public decimal calculTva(decimal montantTht)
        {
            return pays.calculTva(montantTht);
        }


}
}



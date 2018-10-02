using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseTva
{
    public class ClassFrance : ClassPays
    {
        public override decimal calculTva(decimal montantTht)
        {
        return montantTht * 0.196M;
        }

}
}

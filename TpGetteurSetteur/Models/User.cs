using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpGetteurSetteur
{
    public class User
    {
        protected string _myNom;
        protected string _myPrenom;
        protected int _myAge;

        public string Nom 
        {
            protected get { return _myNom; }
             set { _myNom = value; }
        }
        

        public string Prenom
        {
            get { return _myPrenom; }
             set { _myPrenom = value; }
        }
        

        public int Age
        {
            get { return _myAge; }
             set { _myAge = value; }
        }



    }
}

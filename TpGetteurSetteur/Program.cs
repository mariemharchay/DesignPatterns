using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpGetteurSetteur
{
    class Program
    {
        static void Main(string[] args)
        {
            User monUtilisateur = new User();
            monUtilisateur.Nom = "Harchay";
            monUtilisateur.Prenom = "Mariem";
            monUtilisateur.Age = 29;
            string nom = monUtilisateur.Nom;
        }
    }
}

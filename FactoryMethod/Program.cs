using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client;
            client = new ClientComptant();
            client.nouvelleCommande(2000.0);
            client.nouvelleCommande(10000.0);
            client = new ClientCredit();
            client.nouvelleCommande(2000.0);
            client.nouvelleCommande(10000.0);
        }
    }
}

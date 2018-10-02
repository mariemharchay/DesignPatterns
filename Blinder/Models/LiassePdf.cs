using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class LiassePdf:Liasse
    {
        public override void AjouterDocument(string document)
        {
            if (document.StartsWith("<PDF>"))
                contenu.Add(document);
        }

        public override void Imprimer()
        {
            Console.WriteLine("Liasse PDF");
            foreach (string s in contenu)
                Console.WriteLine(s);
        }
    }
}

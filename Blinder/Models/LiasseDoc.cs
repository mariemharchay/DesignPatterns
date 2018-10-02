using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class LiasseDoc : Liasse
    {
        public override void AjouterDocument(string document)
        {
            if (document.StartsWith("<Doc>"))
                contenu.Add(document);
        }

        public override void Imprimer()
        {
            Console.WriteLine("Liasse Doc");
            foreach (string s in contenu)
                Console.WriteLine(s);
        }

    }
}

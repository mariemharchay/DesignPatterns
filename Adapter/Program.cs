using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IDocument document1, document2;
            document1 = new DocumenHtml();
            document1.Contenu = "Hello";
            document1.Dessine();
            Console.WriteLine();
            document2 = new DocumentPdf();
            document2.Contenu = "Bonjour";
            document2.Dessine();
        }
    }
}

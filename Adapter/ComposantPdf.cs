using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class ComposantPdf
    {
        //ComposantPdf composantspdf = new ComposantPdf();
        protected string contenu;

        public void PdfFixeContenu(string contenu)
        {
            this.contenu = contenu;
        }

        public void PdfPrepareAffichage()
        {
            Console.WriteLine("Affichage PDF : Début");
        }

        public void PdfRafraichit()
        {
            Console.WriteLine("Affichage contenu PDF : " +
              contenu);
        }

        public void PdfTermineAffichage()
        {
            Console.WriteLine("Affichage PDF : Fin");
        }

        public void PdfEnvoieImprimante()
        {
            Console.WriteLine("Impression PDF : " + contenu);
        }
      
       
       


    }
}

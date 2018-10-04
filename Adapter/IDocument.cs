using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public interface IDocument
    {
        //List<IDocument> documents = new List<IDocument>(); fait par moi
        //string Contenu { get; set; } fait par moi
        string Contenu { set; }
        //void SetContenu(string Contenu); c'est le meme de dire que string Contenu { set; }
        //void GetContenu(string Contenu); c'est le meme de dire que string Contenu { grt; }
        void Dessine();
        void Imprime();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
    public abstract class Liasse
    {

        public IList<Document> documents { get; protected set; }
        //public List<Document> documents = new List<Document>();
        //public abstract void GetDocument();
        //protected abstract void SetDocument();
        //public Document document;
    }
}

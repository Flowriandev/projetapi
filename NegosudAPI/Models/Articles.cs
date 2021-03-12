using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NegosudAPI
{
    public class Articles
    {
        public long Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public string Famille { get; set; }
        public string Annee { get; set; }
        public double Prix { get; set; }
    }
}

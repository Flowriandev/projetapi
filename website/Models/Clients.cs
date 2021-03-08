using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NegosudAPI.Models
{
    public class Clients
    {
        public long Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Ville { get; set; }
        public string CodePostal { get; set; }
        public string Pays { get; set; }

    }
}

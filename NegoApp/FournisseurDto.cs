using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegoApp
{
    class FournisseurDto
    {
        public long Id { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Ville { get; set; }
        public string CodePostal { get; set; }
        public string Pays { get; set; }
    }

    class Datalist_Fournisseur
    {
        public List<FournisseurDto> ListFournisseur { get; set; }
    }
}

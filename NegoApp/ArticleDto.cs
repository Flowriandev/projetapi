using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegoApp
{
    class ArticleDto
    {
        public long id { get; set; }
        public long idProduit { get; set; }
        public int quantite { get; set; }
        public int quantiteCommande { get; set; }
    }


    class Datalist_Articles
    {
        public List<ArticleDto> ListArticle { get; set; }
    }


}

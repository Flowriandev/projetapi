using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegoApp
{
    class ArticleDto
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string description { get; set; }
        public string famille { get; set; }
        public string annee { get; set; }
        public int prix { get; set; }

    }


    class Datalist_Articles
    {
        public List<ArticleDto> ListArticle { get; set; }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace website.Models
{
    public class ArticleViewModels
    {

        public List<Articles> Articles { get; set; }
        public SelectList Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public string Famille { get; set; }
        public string Annee { get; set; }
        public double Prix { get; set; }
        public int Stock { get; set; }
    }
}


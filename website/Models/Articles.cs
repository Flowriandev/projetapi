﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace website.Models
{
    public class Articles
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public string Famille { get; set; }
        public string Annee { get; set; }
        public double Prix { get; set; }
        public string stock { get; set; }

    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using website.Models;

namespace website.Data
   //NegosudDB
{
    public class NegosudContext : DbContext
    {
        public NegosudContext(DbContextOptions<NegosudContext> options)
            : base(options)
        {
        }

        public DbSet<Articles> Articles { get; set; }
    }

}


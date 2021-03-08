using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NegosudAPI.Models;

namespace NegosudAPI.Models
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options)
            : base(options)
        {
        }
        public DbSet<Clients> TodoItems { get; set; }
        public DbSet<Articles> Articles { get; set; }
        public DbSet<Familles> Familles { get; set; }
        public DbSet<Fournisseurs> Fournisseurs { get; set; }
    }
}

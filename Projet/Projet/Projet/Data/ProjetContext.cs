using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projet.Models;

namespace Projet.Data
{
    public class ProjetContext : DbContext
    {
        public ProjetContext (DbContextOptions<ProjetContext> options)
            : base(options)
        {
        }

        public DbSet<Projet.Models.Pays> Pays { get; set; } = default!;

        public DbSet<Projet.Models.Population> Population { get; set; } = default!;

        public DbSet<Projet.Models.Continent>? Continent { get; set; }
    }
}

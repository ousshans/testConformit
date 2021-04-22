using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestProgrammationConformit.Models;

namespace TestProgrammationConformit.Infrastructures
{
    public class ConformitContext : DbContext
    {
        public ConformitContext(DbContextOptions<ConformitContext> options) : base(options)
        {
        }

        public DbSet<Commentaire> Commentaires { get; set; }
        public DbSet<Evenement> Evenements { get; set; }

     
    }
}

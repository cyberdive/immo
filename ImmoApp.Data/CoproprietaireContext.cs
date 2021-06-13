using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ImmoApp.domain;

namespace ImmoApp.Data
{
    public class CoproprietaireContext : DbContext
    {
  
        public DbSet<Coproprietaire> Coproprietaires { get; set ; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            optionsBuilder.UseSqlServer("");
            // base.OnConfiguring(optionsBuilder);
        }
    }
}

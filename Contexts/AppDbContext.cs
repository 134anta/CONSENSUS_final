using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_Consensus.Entities;

namespace WebAPI_Consensus.Contexts
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        
        }

        public DbSet<ProduccionDiaria> ProduccionDiaria { get; set; }
    }
}

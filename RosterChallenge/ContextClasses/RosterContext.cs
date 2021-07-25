using Microsoft.EntityFrameworkCore;
using RosterChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RosterChallenge.ContextClasses
{
    public class RosterContext : DbContext
    {
        public RosterContext(DbContextOptions<RosterContext> options) : base(options)
        { 
        
        }

        public DbSet<Artist> Artists { get; set; }
    }
}
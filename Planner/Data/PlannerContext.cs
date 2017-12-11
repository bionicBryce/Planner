using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Planner.Models
{
    public class PlannerContext : DbContext
    {
        public PlannerContext (DbContextOptions<PlannerContext> options)
            : base(options)
        {
        }

        public DbSet<Planner.Models.Sacrament> Sacrament { get; set; }
    }
}

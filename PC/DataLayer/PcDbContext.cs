using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PC.DataLayer
{
    public class PcDbContext : DbContext
    {
        public PcDbContext(DbContextOptions<PcDbContext> options) : base(options)
        {
        }
        public DbSet<UserScore> UserScores { get; set; }

    }
}

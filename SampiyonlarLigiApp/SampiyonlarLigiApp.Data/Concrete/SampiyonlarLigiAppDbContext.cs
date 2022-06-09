using Microsoft.EntityFrameworkCore;
using SampiyonlarLigiApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampiyonlarLigiApp.Data.Concrete
{
    public class SampiyonlarLigiAppDbContext : DbContext
    {
        public DbSet<Group1> Group1 { get; set; }
        public DbSet<Group2> Group2 { get; set; }
        public DbSet<Group3> Group3 { get; set; }
        public DbSet<Group4> Group4 { get; set; }
        public DbSet<Last32Group1> last32Group1 { get; set; }
        public DbSet<Last32Group2> last32Group2 { get; set; }
        public DbSet<Last32Group3> last32Group3 { get; set; }
        public DbSet<Last32Group4> last32Group4 { get; set; }
        public DbSet<Last32Group5> last32Group5 { get; set; }
        public DbSet<Last32Group6> last32Group6 { get; set; }
        public DbSet<Last32Group7> last32Group7 { get; set; }
        public DbSet<Last32Group8> last32Group8 { get; set; }
        public DbSet<Fixture> Fixture { get; set; }
        public DbSet<Teams> Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=SampiyonlarLigiApp");
        }
    }
}

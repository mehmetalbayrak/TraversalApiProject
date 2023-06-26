using Microsoft.EntityFrameworkCore;
using TraversalApiProject.DataAccess.Entities;

namespace TraversalApiProject.DataAccess.Context
{
    public class VisitorContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-JDE28UMP;database=TraversalApiDb;integrated security=true;");
        }
        public DbSet<Visitor> Visitors { get; set; }
    }
}

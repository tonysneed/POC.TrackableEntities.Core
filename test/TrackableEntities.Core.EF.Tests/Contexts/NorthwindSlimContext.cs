using Microsoft.EntityFrameworkCore;
using TrackableEntities.Core.EF.Tests.Models;

namespace TrackableEntities.Core.EF.Tests.Contexts
{
    public class NorthwindSlimContext : DbContext
    {
        public NorthwindSlimContext() { }

        public NorthwindSlimContext(DbContextOptions<NorthwindSlimContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}

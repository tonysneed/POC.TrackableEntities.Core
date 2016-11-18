using Xunit;
using Microsoft.EntityFrameworkCore;
using TrackableEntities.Core.Common;
using TrackableEntities.Core.EF.Tests.Contexts;
using TrackableEntities.Core.EF.Tests.Models;

namespace TrackableEntities.Core.EF.Tests
{
    public class DbContextExtensionsTests
    {
        private readonly DbContextOptions<NorthwindSlimContext> _options;

        public DbContextExtensionsTests()
        {
            _options = new DbContextOptionsBuilder<NorthwindSlimContext>()
                .UseInMemoryDatabase("NorthwindSlim")
                .Options;
        }

        [Fact]
        public void ApplyChanges_Should_Mark_Entity_As_Added()
        {
            using (var context = new NorthwindSlimContext(_options))
            {
                // Arrange
                var product = new Product
                {
                    ProductId = 1,
                    ProductName = "Chai",
                    UnitPrice = 10
                };
                product.TrackingState = TrackingState.Added;

                // Act
                context.ApplyChanges(product);

                // Assert
                Assert.Equal(EntityState.Added, context.Entry(product).State);
            }
        }
    }
}

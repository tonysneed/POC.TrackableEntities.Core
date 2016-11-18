using Microsoft.EntityFrameworkCore;
using TrackableEntities.Core.Common;

namespace TrackableEntities.Core.EF
{
    /// <summary>
    /// Extension methods for DbContext to persist trackable entities.
    /// </summary>
    public static class DbContextExtensions
    {
        /// <summary>
        /// Update entity state on DbContext for an object graph.
        /// </summary>
        /// <param name="context">Used to query and save changes to a database</param>
        /// <param name="item">Object that implements ITrackable</param>
        public static void ApplyChanges(this DbContext context, ITrackable item)
        {
            // Recursively set entity state for DbContext entry
            context.ChangeTracker.TrackGraph(item, e =>
            {
                var entityState = item.TrackingState.ToEntityState();
                e.Entry.State = entityState;
            });
        }
    }
}

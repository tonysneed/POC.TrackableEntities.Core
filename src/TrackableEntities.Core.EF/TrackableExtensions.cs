using Microsoft.EntityFrameworkCore;
using TrackableEntities.Core.Common;

namespace TrackableEntities.Core.EF
{
    /// <summary>
    /// Extension methods for classes implementing ITrackable.
    /// </summary>
    public static class TrackableExtensions
    {
        /// <summary>
        /// Convert TrackingState to EntityState.
        /// </summary>
        /// <param name="state">Trackable entity state</param>
        /// <returns>EF entity state</returns>
        public static EntityState ToEntityState(this TrackingState state)
        {
            switch (state)
            {
                case TrackingState.Added:
                    return EntityState.Added;
                case TrackingState.Modified:
                    return EntityState.Modified;
                case TrackingState.Deleted:
                    return EntityState.Deleted;
                default:
                    return EntityState.Unchanged;
            }
        }

    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TrackableEntities.Core.Common;

namespace TrackableEntities.Core.EF.Tests.Helpers
{
    public class EntityBase : ITrackable
    {
        [NotMapped]
        public TrackingState TrackingState { get; set; }
        [NotMapped]
        public ICollection<string> ModifiedProperties { get; set; }
    }
}

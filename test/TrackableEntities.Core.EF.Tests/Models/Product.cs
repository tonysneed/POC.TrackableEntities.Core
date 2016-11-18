using System.Collections.Generic;
using TrackableEntities.Core.Common;
using TrackableEntities.Core.EF.Tests.Helpers;

namespace TrackableEntities.Core.EF.Tests.Models
{
    public class Product : EntityBase
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }
}

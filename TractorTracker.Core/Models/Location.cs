using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractorTracker.Core.Models
{
    public class Location : EntityBase
    {
        public int Id { get; set; }
        public double? LatLocation { get; set; }
        public double? LongLocation { get; set; }
        public string? FieldIdentifier { get; set; }
        public string? FieldName { get; set; }
        public ICollection<Equipment> Equipment { get; set; } = new List<Equipment>();

        public string ConvertLatLong (double lat, double lon)
        {
            return null;
        }
    }
}

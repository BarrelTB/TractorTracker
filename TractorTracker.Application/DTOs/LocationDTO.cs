using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractorTracker.Application.DTOs
{
    public class LocationDTO
    {
        public double LatLocation { get; set; }
        public double LongLocation { get; set; }
        public string FieldIdentifier { get; set; }
        public string FieldName { get; set; }
    }
}

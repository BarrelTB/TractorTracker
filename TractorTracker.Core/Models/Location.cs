using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractorTracker.Core.Models
{
    public class Location
    {
        public int Id { get; set; }
        public double LatLocation { get; set; }
        public double LongLocation { get; set; }
        public string FieldIdentifier { get; set; }
        public List<Equipment> Equipment { get; set; }
    }
}

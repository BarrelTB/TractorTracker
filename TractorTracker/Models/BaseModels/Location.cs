using TractorTracker.Web.Models.Interfaces;

namespace TractorTracker.Web.Models.BaseModels
{
    public class Location : IBaseInterface
    {
        public double LatLocation { get; set; }
        public double LongLocation { get; set; }
        public string FieldIdentifier { get; set; }
        public string FieldName { get; set; }
    }
}

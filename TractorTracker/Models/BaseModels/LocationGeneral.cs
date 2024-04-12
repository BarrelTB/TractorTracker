using TractorTracker.Web.Models.Interfaces;

namespace TractorTracker.Web.Models.BaseModels
{
    public class LocationGeneral : IBaseInterface
    {
        public string FieldIdentifier { get; set; }
        public string FieldName { get; set; }
    }
}

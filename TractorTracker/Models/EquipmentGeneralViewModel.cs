using TractorTracker.Web.Models.BaseModels;

namespace TractorTracker.Web.Models
{
    public class EquipmentGeneralViewModel
    {
        public int Id { get; }
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public LocationGeneral Location { get; set; }
    }
}

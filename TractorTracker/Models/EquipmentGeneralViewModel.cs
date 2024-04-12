using TractorTracker.Web.Models.BaseModels;

namespace TractorTracker.Web.Models
{
    public class EquipmentGeneralViewModel : EquipmentBase
    {
        public int Id { get; set;  }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public LocationGeneral Location { get; set; }
    }
}

using TractorTracker.Web.Models.Interfaces;

namespace TractorTracker.Web.Models.BaseModels
{
    public class Part : EquipmentBase
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Quantity { get; set; }
    }
}

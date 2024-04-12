namespace TractorTracker.Web.Models.BaseModels
{
    public class Transmission : EquipmentBase
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime LastFluidChange { get; set; }
        public DateTime LastFilterChange { get; set; }
    }
}

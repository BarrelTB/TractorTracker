namespace TractorTracker.Web.Models.BaseModels
{
    public class Wheel : EquipmentBase
    {
        public string Brand { get; set; }
        public int BrakeRating { get; set; }
        public DateTime LastBrakeChange { get; set; }
        public string Notes { get; set; }
    }
}

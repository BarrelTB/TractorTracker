namespace TractorTracker.Web.Models.BaseModels
{
    public class Chassis : EquipmentBase
    {
        public double Weight { get; set; }
        public int RustRating { get; set; }
        public DateTime LastCleaningAndLubricationDate { get; set; }
    }
}

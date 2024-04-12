namespace TractorTracker.Web.Models.BaseModels
{
    public class Wheel
    {
        public string Brand { get; set; }
        public int BrakeRating { get; set; }
        public DateTime LastBrakeChange { get; set; }
        public Tire Tire { get; set; }
        public Rim Rim { get; set; }
    }
}

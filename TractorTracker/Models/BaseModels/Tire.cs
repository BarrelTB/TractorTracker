namespace TractorTracker.Web.Models.BaseModels
{
    public class Tire : EquipmentBase
    {
        public string Brand { get; set; }
        public string Size { get; set; }
        public int Psi { get; set; }
        public string TreadPattern { get; set; }
        public int WearRating { get; set; }
    }
}

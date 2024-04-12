namespace TractorTracker.Web.Models.BaseModels
{
    public class Engine : EquipmentBase
    {
        public string Type { get; set; }
        public double Weight { get; set; }
        public double Size { get; set; }
        public int HorsePower { get; set; }
        public int NumberOfCylinders { get; set; }
        public string Fuel { get; set; }
        public string OilType { get; set; }
        public DateTime LastOilChange { get; set; }
        public DateTime LastFilterChange { get; set; }
    }
}

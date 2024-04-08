namespace TractorTracker.Web.Models
{
    public class EquipmentGeneral
    {
        public int Id { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public LocationGeneral Location { get; set; }
    }
}

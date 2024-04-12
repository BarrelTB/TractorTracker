using TractorTracker.Web.Models.BaseModels;

namespace TractorTracker.Web.Models
{
    public class EquipmentViewModel : EquipmentBase
    {
        public int Id { get; }
        public List<Note> Notes { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public Engine Engine { get; set; }
        public Chassis Chassis { get; set; }
        public Transmission Transmission { get; set; }
        public List<Part> Parts { get; set; }
        public List<Wheel> Wheels { get; set; }
        public Location Location { get; set; }
        public List<Worker> Workers { get; set; }
    }
}

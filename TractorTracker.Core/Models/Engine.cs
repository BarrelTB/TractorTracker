using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TractorTracker.Core.Enums;

namespace TractorTracker.Core.Models
{
    public class Engine : EquipmentBase
    {
        public string? Type { get; set; }
        public double Weight { get; set; }
        public double size { get; set; }
        public int HorsePower { get; set; }
        public int NumberOfCylinders {  get; set; }
        public FuelEnum Fuel {  get; set; }
        public string? OilType { get; set; }
        public DateTime LastOilChange { get; set; }
        public DateTime LastFilterChange { get; set; }
        public Equipment Equipment { get; set; }
        public int EquipmentId { get; set; }
        public override ICollection<Note> Notes { get; set; } = new List<Note>();

    }
}

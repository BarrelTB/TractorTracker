using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractorTracker.Core.Models
{
    public class Chassis : EquipmentBase
    {
        public double Weight { get; set; }
        public int RustRating { get; set; }
        public DateTime LastCleaningAndLubricationDate { get; set; }
        public Equipment Equipment { get; set; }
        public int EquipmentId { get; set; }
        public ICollection<Wheel> Wheels { get; } = new List<Wheel>();
        public override ICollection<Note> Notes { get; set; } = new List<Note>();
    }
}

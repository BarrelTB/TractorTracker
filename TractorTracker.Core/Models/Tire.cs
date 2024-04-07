using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractorTracker.Core.Models
{
    public class Tire : EquipmentBase
    {
        public string? Brand { get; set; }
        public string Size { get; set; }
        public int Psi { get; set; }
        public string? TreadPattern { get; set; }
        public int WearRating { get; set; }
        public Wheel Wheel { get; set; }
        public int WheelId { get; set; }
        public override ICollection<Note> Notes { get; set; } = new List<Note>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractorTracker.Core.Models
{
    public class Rim : EquipmentBase
    {
        public string? Brand { get; set; }
        public int Size { get; set; }
        public int RustRating { get; set; }
        public Wheel Wheel {  get; set; }
        public int WheelId { get; set; }
        public override ICollection<Note> Notes { get; set; } = new List<Note>();
    }
}

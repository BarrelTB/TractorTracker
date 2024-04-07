using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractorTracker.Core.Models
{
    public class Wheel : EquipmentBase
    {
        public string? Brand { get; set; }
        public int BrakeRating { get; set; }
        public DateTime LastBrakeChange { get; set; }
        public ICollection<Rim> Rims { get; set; } = new List<Rim>();
        public ICollection<Tire> Tires { get; set; } = new List<Tire>();
        public override ICollection<Note> Notes { get; set; } = new List<Note>();
        public Chassis Chassis { get; set; }
        public int ChassisId { get; set; }


    }
}

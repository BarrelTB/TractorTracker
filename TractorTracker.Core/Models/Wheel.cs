using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractorTracker.Core.Models
{
    public class Wheel : EquipmentBase
    {
        public string Brand { get; set; }
        public int BrakeRating { get; set; }
        public DateTime LastBrakeChange { get; set; }
        public string Notes { get; set; }
        public ICollection<Rim> Rims { get; } = new List<Rim>();
        public override ICollection<Note> Notes { get; set; } = new List<Note>();
        public Chassis Chassis { get; set; }
        public int ChassisId { get; set; }


    }
}

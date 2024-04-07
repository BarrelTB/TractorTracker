using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractorTracker.Core.Models
{
    public class Part : EquipmentBase
    {
        public string Name { get; set; }
        public string? Type { get; set; }
        public int Quantity { get; set; }
        public override ICollection<Note> Notes { get; set; } = new List<Note>();
        public Equipment Equipment { get; set; }
        public int EquipmentId { get; set; }

    }
}

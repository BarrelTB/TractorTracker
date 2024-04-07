using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractorTracker.Core.Models
{
    public class Transmission : EquipmentBase
    {
        public string Name { get; set; }
        public string Type {  get; set; }
        public DateTime LastFluidChange {  get; set; }
        public DateTime LastFilterChange { get; set; }
        public override ICollection<Note> Notes { get; set; } = new List<Note>();


    }
}

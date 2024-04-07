using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractorTracker.Core.Models
{
    public abstract class EquipmentBase
    {
        public int Id { get; set; }
        public string SerialNumber { get; set; }
        public abstract ICollection<Note> Notes { get; set; }
    }
}

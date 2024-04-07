using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractorTracker.Core.Models
{
    public abstract class EquipmentBase : EntityBase
    {
        public int Id { get; set; }
        public string? SerialNumber { get; set; }
        public abstract ICollection<Note> Notes { get; set; }
    }
}

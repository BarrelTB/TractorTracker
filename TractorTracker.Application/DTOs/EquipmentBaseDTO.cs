using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractorTracker.Application.DTOs
{
    public abstract class EquipmentBaseDTO
    {
        public string SerialNumber { get; set; }
        public List<NoteDTO> Notes { get; set; }
    }
}

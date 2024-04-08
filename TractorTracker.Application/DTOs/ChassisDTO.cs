using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractorTracker.Application.DTOs
{
    public class ChassisDTO : EquipmentBase
    {
        public double Weight { get; set; }
        public int RustRating { get; set; }
        public DateTime LastCleaningAndLubricationDate { get; set; }
        public List<WheelDTO> Wheels { get; }
    }
}

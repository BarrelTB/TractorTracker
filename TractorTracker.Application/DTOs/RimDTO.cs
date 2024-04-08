using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractorTracker.Application.DTOs
{
    public class RimDTO : EquipmentBase
    {
        public string Brand { get; set; }
        public int Size { get; set; }
        public int RustRating { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractorTracker.Application.DTOs
{
    public class PartDTO : EquipmentBase
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Quantity { get; set; }

    }
}

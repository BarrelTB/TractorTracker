using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractorTracker.Application.DTOs
{
    public class WheelDTO : EquipmentBaseDTO
    {
        public string Brand { get; set; }
        public int BrakeRating { get; set; }
        public DateTime LastBrakeChange { get; set; }
        public string Notes { get; set; }
        public List<RimDTO> Rims { get; set; }
        public List<TireDTO> Tires { get; set; }


    }
}

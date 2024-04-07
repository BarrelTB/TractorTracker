using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractorTracker.Application.DTOs
{
    public class EngineDTO : EquipmentBaseDTO
    {
        public string Type { get; set; }
        public double Weight { get; set; }
        public double size { get; set; }
        public int HorsePower { get; set; }
        public int NumberOfCylinders {  get; set; }
        public string Fuel {  get; set; }
        public string OilType { get; set; }
        public DateTime LastOilChange { get; set; }
        public DateTime LastFilterChange { get; set; }

    }
}

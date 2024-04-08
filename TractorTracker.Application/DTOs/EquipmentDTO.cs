using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractorTracker.Application.DTOs
{
    public class EquipmentDTO : EquipmentBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public EngineDTO Engine { get; set; }
        public ChassisDTO Chassis { get; set; }
        public TransmissionDTO Transmission { get; set; }
        public List<PartDTO> Parts { get; set; }
        public LocationDTO Location { get; set; }
        public List<WorkerDTO> Workers { get; set; }

    }
}

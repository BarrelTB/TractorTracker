using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractorTracker.Core.Models
{
    public class Note : EntityBase
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public EquipmentBase? EquipmentBase { get; set; }
        public int EquipmentBaseId { get; set; }
        public Rim? Rim { get; set; }
        public int RimId { get; set; }
        public Tire? Tire { get; set; }
        public int TireId { get; set; }
        public Part? Part { get; set; }
        public int PartId { get; set; }
        public Wheel? Wheel { get; set; }
        public int WheelId { get; set; }
        public Transmission? Transmission { get; set; }
        public int TransmissionId { get; set; }
        public Chassis? Chassis { get; set; }
        public int ChassisId { get; set; }
        public Engine? Engine { get; set; }
        public int EngineId { get; set; }
        public Equipment? Equipment { get; set; }
        public int EquipmentId { get; set; }


    }
}

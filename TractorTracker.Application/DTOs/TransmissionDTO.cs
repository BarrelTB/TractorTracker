using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractorTracker.Application.DTOs
{
    public class TransmissionDTO : EquipmentBase
    {
        public string Name { get; set; }
        public string Type {  get; set; }
        public DateTime LastFluidChange {  get; set; }
        public DateTime LastFilterChange { get; set; }


    }
}

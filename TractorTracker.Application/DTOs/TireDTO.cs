using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractorTracker.Application.DTOs
{
    public class TireDTO : EquipmentBase
    {
        public string Brand { get; set; }
        public string Size { get; set; }
        public int Psi { get; set; }
        public string TreadPattern { get; set; }
        public int WearRating { get; set; }
    }
}

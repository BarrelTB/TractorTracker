using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractorTracker.Application.DTOs
{
    public class WorkerDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeIdNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int YearsOfService { get; set; }
        public int MonthsOfService { get; set; }
        public List<EquipmentDTO> Equipment { get; set; }

    }
}

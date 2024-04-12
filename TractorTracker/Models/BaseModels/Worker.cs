using TractorTracker.Application.DTOs;
using TractorTracker.Web.Models.Interfaces;

namespace TractorTracker.Web.Models.BaseModels
{
    public class Worker : IBaseInterface
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

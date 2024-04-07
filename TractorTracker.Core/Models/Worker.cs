using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractorTracker.Core.Models
{
    public class Worker : EntityBase
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeIdNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int YearsOfService { get; set; }
        public int MonthsOfService { get; set; }
        public ICollection<Equipment> Equipment { get; set; } = new List<Equipment>();

    }
}

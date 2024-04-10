using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractorTracker.Core.Models
{
    public class User : EntityBase
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email {  get; set; }
        public string TimeZoneId { get; set; }
        public ICollection<Equipment>? Equipment { get; set; }



    }
}

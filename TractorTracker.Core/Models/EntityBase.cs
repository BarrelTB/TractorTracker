using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractorTracker.Core.Models
{
    public abstract class EntityBase
    {
        public bool IsDeleted { get; set; } = false;
    }
}

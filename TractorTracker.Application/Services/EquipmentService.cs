using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TractorTracker.Application.DTOs;

namespace TractorTracker.Application.Services
{
    public class EquipmentService
    {
        public List<EquipmentDTO> GetAllEquipmentForUser(int userId)
        {
            return null;
        }

        public EquipmentDTO GetSingleEquipmentForUser(int userId)
        {
            return null;
        }

        public List<EquipmentDTO> GetAllEquipmentWithLastChangeDateBeforeGivenDate(int userId, DateTime minLastChangeDate)
        {
            return null;
        }
    }
}

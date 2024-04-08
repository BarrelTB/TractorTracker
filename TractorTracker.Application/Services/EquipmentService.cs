using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TractorTracker.Application.DTOs;
using TractorTracker.Core;
using TractorTracker.Core.Models;

namespace TractorTracker.Application.Services
{
    public class EquipmentService
    {
        private readonly CoreDbContext _coreDbContext;
        private readonly AutoMapper.Mapper _mapper;
        public List<EquipmentDTO> GetAllEquipmentForUser(int userId)
        {
            using (_coreDbContext)
            {
                var equipment = _coreDbContext.Equipment.Where(e => e.User.Id == userId).ToList();
                var equipmentDTOs = _mapper.Map<List<Equipment>, List<EquipmentDTO>>(equipment);
                return equipmentDTOs;
            }
      
        }

        public EquipmentDTO GetSingleEquipmentForUser(int id)
        {
            using (_coreDbContext)
            {
                var equipment = _coreDbContext.Equipment.Find(id);
                var equipmentDTO = _mapper.Map<Equipment, EquipmentDTO>(equipment);
                return equipmentDTO;
            }
        }

        public List<EquipmentDTO> GetAllEquipmentWithLastChangeDateBeforeGivenDate(int userId, DateTime minLastChangeDate)
        {
            using (_coreDbContext)
            {
                var equipment = _coreDbContext.Equipment
                    .Where(e => e.User.Id == userId 
                    && (e.Chassis.LastCleaningAndLubricationDate < minLastChangeDate
                    || e.Engine.LastFilterChange < minLastChangeDate
                    || e.Engine.LastOilChange < minLastChangeDate
                    || e.Transmission.LastFilterChange < minLastChangeDate
                    || e.Transmission.LastFluidChange < minLastChangeDate))
                    .ToList();
                var equipmentDTOs = _mapper.Map<List<Equipment>, List<EquipmentDTO>>(equipment);
                return equipmentDTOs;
            }
        }
    }
}

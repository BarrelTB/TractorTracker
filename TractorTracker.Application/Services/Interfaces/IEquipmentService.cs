using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TractorTracker.Application.DTOs;
using TractorTracker.Core.Models;
using TractorTracker.Core;

namespace TractorTracker.Application.Services.Interfaces
{
    public interface IEquipmentService
    {
        List<EquipmentDTO> GetAllEquipmentForUser(int userId);

        List<EquipmentGeneralDTO> GetAllEquipmentGeneralForUser(int userId);


        EquipmentDTO GetSingleEquipmentForUser(int equipmentId);


        List<EquipmentDTO> GetAllEquipmentWithLastChangeDateBeforeGivenDate(int userId, DateTime minLastChangeDate);


        bool AssignWorkerToEquipment(List<int> equipmentIds, string employeeIdNumber);

        bool CreateEquipmentFromGeneral(EquipmentGeneralDTO equipmentGeneralDTO, int userId);

        bool UpdateEquipment(EquipmentDTO equipmentDTO, int userId);

        bool DeleteEquipment(int id);
    }
}

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
    public class WorkerService
    {
        private readonly CoreDbContext _coreDbContext;
        private readonly AutoMapper.Mapper _mapper;
        public bool AssignWorkerToEquipment(List<int> equipmentIds, string employeeIdNumber)
        {
            using (_coreDbContext) 
            {
                try
                {
                    var worker = _coreDbContext.Worker.Where(e => e.EmployeeIdNumber == employeeIdNumber).FirstOrDefault();

                    var equipment = new List<Equipment>();
                    foreach (var id in equipmentIds)
                    {
                        equipment.Add(_coreDbContext.Equipment.Find(id));
                    }
                    foreach (var item in equipment)
                    {
                        item.Workers.Add(worker);
                    }
                    _coreDbContext.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
                
            }
        }
    }
}

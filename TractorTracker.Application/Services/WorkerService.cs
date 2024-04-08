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

        public WorkerDTO GetWorker(int id)
        {
            using (_coreDbContext)
            {
                var worker = _coreDbContext.Worker.Where(w => w.Id == id && w.IsDeleted == false).First();
                return _mapper.Map<Worker, WorkerDTO>(worker);
            }
        }

        public bool CreateOrUpdateWorker(WorkerDTO workerDTO)
        {
            //change to Id
            using (_coreDbContext)
            {
                try
                {
                    var worker = new Worker();
                    if (workerDTO.EmployeeIdNumber != null)
                    {
                        //probably not needed if workerDTO contains appropriate Id
                        worker = _coreDbContext.Worker.Find(workerDTO.EmployeeIdNumber);
                        worker = _mapper.Map<WorkerDTO, Worker>(workerDTO);
                        _coreDbContext.Worker.Update(worker);
                    }
                    else
                    {
                        worker = _mapper.Map<WorkerDTO, Worker>(workerDTO);
                        _coreDbContext.Worker.Add(worker);
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

        //Implement employer entity, with one to many employer to worker relationship
        /*public List<WorkerDTO> GetWorkers(int userId)
        {
            using (_coreDbContext)
            {
                var workers = _coreDbContext.Worker.Where(w => w.);
                return _mapper.Map<Worker, WorkerDTO>(worker);
            }
        }*/

        public bool DeleteWorker(int id)
        {
            using (_coreDbContext)
            {
                try
                {
                    var worker = _coreDbContext.Worker.Find(id);
                    worker.IsDeleted = true;
                    _coreDbContext.Worker.Update(worker);
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

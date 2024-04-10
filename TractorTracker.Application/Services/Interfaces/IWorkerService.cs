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
    public interface IWorkerService
    {
        WorkerDTO GetWorker(int id);

        bool CreateOrUpdateWorker(WorkerDTO workerDTO);

        //Implement employer entity, with one to many employer to worker relationship
        /*List<WorkerDTO> GetWorkers(int userId);*/

        bool DeleteWorker(int id);
    }
}

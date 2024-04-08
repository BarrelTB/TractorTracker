using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TractorTracker.Application.DTOs;
using TractorTracker.Core.Models;

namespace TractorTracker.Application.Profiles
{
    public class AutoMapperConfigProfile : Profile
    {
        public AutoMapperConfigProfile() 
        {
            CreateMap<User, UserDTO>().ReverseMap();

            CreateMap<Equipment, EquipmentDTO>();
            CreateMap<Equipment, EquipmentGeneralDTO>();
            CreateMap<Chassis, ChassisDTO>();
            CreateMap<Engine, EngineDTO>();
            CreateMap<Part, PartDTO>();
            CreateMap<Rim, RimDTO>();
            CreateMap<Tire, TireDTO>();
            CreateMap<Transmission, TransmissionDTO>();
            CreateMap<Wheel, WheelDTO>();

            CreateMap<Worker, WorkerDTO>().ReverseMap();
            CreateMap<Location, LocationDTO>();
            CreateMap<Location, LocationGeneralDTO>();
            CreateMap<Note, NoteDTO>().ReverseMap();
        }
    }
}

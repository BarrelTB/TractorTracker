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
            CreateMap<User, UserDTO>()
                .ForMember(dest => dest.TimeZoneInfo, opt => opt.MapFrom(src => TimeZoneInfo.FindSystemTimeZoneById(src.TimeZoneId)));
            CreateMap<UserDTO, User>()
                .ForMember(dest => dest.TimeZoneId, opt => opt.MapFrom(src => src.TimeZoneInfo.Id));

            CreateMap<Equipment, EquipmentDTO>().ReverseMap();
            CreateMap<Equipment, EquipmentGeneralDTO>().ReverseMap();
            CreateMap<Chassis, ChassisDTO>().ReverseMap();
            CreateMap<Engine, EngineDTO>().ReverseMap();
            CreateMap<Part, PartDTO>().ReverseMap();
            CreateMap<Rim, RimDTO>().ReverseMap();
            CreateMap<Tire, TireDTO>().ReverseMap();
            CreateMap<Transmission, TransmissionDTO>().ReverseMap();
            CreateMap<Wheel, WheelDTO>().ReverseMap();

            CreateMap<Worker, WorkerDTO>().ReverseMap();
            CreateMap<Location, LocationDTO>().ReverseMap();
            CreateMap<Location, LocationGeneralDTO>().ReverseMap();
            CreateMap<Note, NoteDTO>().ReverseMap();
        }
    }
}

using AutoMapper;
using TractorTracker.Application.DTOs;
using TractorTracker.Web.Models;
using TractorTracker.Web.Models.BaseModels;

namespace TractorTracker.Web.Profiles
{
    public class AutoMapperConfigProfile : Profile
    {
        public AutoMapperConfigProfile() 
        {
            CreateMap<UserDTO, UserViewModel>().ReverseMap();
            CreateMap<EquipmentGeneralDTO, EquipmentGeneral>().ReverseMap();
            CreateMap<ChassisDTO, Chassis>().ReverseMap();
            CreateMap<EngineDTO, Engine>().ReverseMap();
            CreateMap<LocationDTO, Location>().ReverseMap();
            CreateMap<NoteDTO, Note>().ReverseMap();
            CreateMap<PartDTO, Part>().ReverseMap();
            CreateMap<TransmissionDTO, Transmission>().ReverseMap();
            CreateMap<WorkerDTO, Worker>().ReverseMap();
            CreateMap<EquipmentDTO, EquipmentViewModel>().ReverseMap();
        }
    }
}

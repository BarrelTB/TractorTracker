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
            CreateMap<UserDTO, UserViewModel>()
                .ForMember(dest => dest.TimeZoneId, opt => opt.MapFrom(src => src.TimeZoneInfo.Id));
            CreateMap<UserViewModel, UserDTO>()
                .ForMember(dest => dest.TimeZoneInfo, opt => opt.MapFrom(src => TimeZoneInfo.FindSystemTimeZoneById(src.TimeZoneId)));
            CreateMap<EquipmentGeneralDTO, EquipmentGeneralViewModel>().ReverseMap();
            CreateMap<ChassisDTO, Chassis>().ReverseMap();
            CreateMap<EngineDTO, Engine>().ReverseMap();
            CreateMap<LocationDTO, Location>().ReverseMap();
            CreateMap<LocationGeneralDTO, LocationGeneral>().ReverseMap();
            CreateMap<NoteDTO, Note>().ReverseMap();
            CreateMap<PartDTO, Part>().ReverseMap();
            CreateMap<TransmissionDTO, Transmission>().ReverseMap();
            CreateMap<WorkerDTO, Worker>().ReverseMap();
            CreateMap<EquipmentDTO, EquipmentViewModel>().ReverseMap();
        }
    }
}

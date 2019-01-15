namespace MappingObjects.App.Core
{
    using AutoMapper;

    using Data.Models;
    using Dtos;

    public class MappingObjectsProfile : Profile
    {
        public MappingObjectsProfile()
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<Employee, EmployeePersonalInfoDto>().ReverseMap();
            CreateMap<Employee, ManagerDto>()
                .ForMember(dest => dest.EmployeesDto, from => from.MapFrom(x => x.ManagerEmployees))
                .ReverseMap();
            CreateMap<Employee, EmployeeOlderThanDto>().ReverseMap();
        }
    }
}

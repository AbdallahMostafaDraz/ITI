using AutoMapper;
using Lab2.DataAccess;
using Lab2.Entities.DTOs.DepartmentDTOs;
using Lab2.Entities.DTOs.StudentDTOs;

namespace Lab2.Entities.Mapper
{
    public class MapperConfig : Profile
    {
        public MapperConfig() 
        {
            CreateMap<Student, GetStudentDTO>()
           .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.StId))
           .ForMember(dest => dest.Name, opt => opt.MapFrom(src => $"{src.StFname} {src.StLname}".Trim()))
           .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.StAddress))
           .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.StAge))
           .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.Dept != null ? src.Dept.DeptName : null))
           .ForMember(dest => dest.SupervisorName, opt => opt.MapFrom(src => src.StSuperNavigation != null ? $"{src.StSuperNavigation.StFname} {src.StSuperNavigation.StLname}".Trim() : null))
           .ReverseMap();

            CreateMap<AddStudentDTO, Student>()
            .ForMember(dest => dest.StId, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.StFname, opt => opt.MapFrom(src => src.Name != null && src.Name.Contains(" ") ? src.Name.Substring(0, src.Name.IndexOf(" ")) : src.Name))
            .ForMember(dest => dest.StLname, opt => opt.MapFrom(src => src.Name != null && src.Name.Contains(" ") ? src.Name.Substring(src.Name.IndexOf(" ") + 1) : ""))
            .ForMember(dest => dest.StAddress, opt => opt.MapFrom(src => src.Address))
            .ForMember(dest => dest.StAge, opt => opt.MapFrom(src => src.Age))
            .ForMember(dest => dest.DeptId, opt => opt.MapFrom(src => src.DeptId))
            .ForMember(dest => dest.StSuper, opt => opt.MapFrom(src => src.StSuper));

            CreateMap<GetDepartmentDTO, Department>().ReverseMap();
            CreateMap<AddDepartmentDTO, Department>().ReverseMap();
        }
    }
}

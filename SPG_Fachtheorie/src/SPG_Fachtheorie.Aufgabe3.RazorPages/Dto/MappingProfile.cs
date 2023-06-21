using AutoMapper;
using SPG_Fachtheorie.Aufgabe2.Domain;

namespace SPG_Fachtheorie.Aufgabe3.RazorPages.Dto
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<NewAdvertisementDto, Advertisement>();
        }
    }
}

using AutoMapper;
using Project.DtoLayer.SikayetDTO;
using ProjectAPI.EntityLayer.Entities;

namespace ProjectAPI.Mapping
{
    public class SikayetMapping : Profile 
    {
        public SikayetMapping() 
        {
            CreateMap<Sikayet, ResultSikayetDTO>().ReverseMap();
            CreateMap<Sikayet, GetSikayetDTO>().ReverseMap();
            CreateMap<Sikayet, CreateSikayetDTO>().ReverseMap();
            CreateMap<Sikayet, UpdateSikayetDTO>().ReverseMap();
            
            
        }
    }
}

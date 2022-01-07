using AutoMapper;
using InsightDB.Demo.Data;
using InsightDB.Demo.Models;
namespace InsightDB.Demo.MappingProfiles
{
    public class DataToModelProfile : Profile
    {
        public DataToModelProfile()
        {
            CreateMap<PagedData<Product>, PageableObject<Product>>();
            
        }
    }
}

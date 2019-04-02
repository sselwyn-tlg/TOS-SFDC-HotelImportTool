using AutoMapper;

namespace DataFeed.HotelImport.Entities
{
    /// <summary>
    /// Represents the class that contains the mapping between source entities 
    /// and their corresponding target entities.
    /// </summary>
    public class HotelMapperProfile : Profile
    {
        /// <summary>
        /// Creates a new instance of HotelMapperProfile
        /// </summary>
        public HotelMapperProfile()
        {
            CreateMap<Source.Hotel__c, Target.Hotel>()
                .ForMember(dest => dest.HotelId, opt => opt.MapFrom(src => src.Id));
        }
    }
}

using AutoMapper;
using CoreCodeCamp.Data.Entities;
using CoreCodeCamp.Models;

namespace CoreCodeCamp.Data
{
    public class CampProfile : Profile
    {
        public CampProfile()
        {
            CreateMap<Speaker, SpeakerModel>().ReverseMap();
            //this.CreateMap<SpeakerModel, Speaker>();
            CreateMap<Talk, TalkModel>().ReverseMap()
                .ForMember(t => t.Camp, opt => opt.Ignore());
            //this.CreateMap<TalkModel, Talk>();
            CreateMap<CampModel, Camp>().ReverseMap()
                //this.CreateMap<Camp, CampModel>();
                // To the Venue property of the model, I'm going to map the VenueName property of the location object
                .ForMember(c => c.Venue, o => o.MapFrom(m => m.Location.VenueName));
        }
    }
}
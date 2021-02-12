
using AutoMapper;
using CoreCodeCamp.Models;

namespace CoreCodeCamp.Data
{
    public class CampProfile: Profile
    {
        public CampProfile()
        {

            this.CreateMap<Speaker, SpeakerModel>();
            this.CreateMap<Talk, TalkModel>();
            this.CreateMap<CampModel, Camp>();
            this.CreateMap<Camp, CampModel>()
                // To the Venue property of the model, I'm going to map the VenueName property of the location object
                .ForMember(c => c.Venue, o => o.MapFrom(m => m.Location.VenueName));



        }
    }
}

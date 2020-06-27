namespace Pluralsight_Gighub.App_Start
{
    using AutoMapper;
    using Pluralsight_Gighub.Dto;
    using Pluralsight_Gighub.Models;

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ApplicationUser, UserDto>();
            CreateMap<Gig, GigDto>();
            CreateMap<Notification, NotificationDto>();
        }
    }
}
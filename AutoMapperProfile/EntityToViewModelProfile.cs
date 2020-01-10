using AutoMapper;
using ProjectAboutMe.Models;
using ProjectAboutMe.ViewModels;

namespace ProjectAboutMe.AutoMapperProfile
{
    public class EntityToViewModelProfile : Profile
    {
        public EntityToViewModelProfile()
        {
            CreateMap<Square, SquareViewModel>();
        }
    }
}

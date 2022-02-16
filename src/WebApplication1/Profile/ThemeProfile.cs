using Quizzator.Entity;
using Quizzator.Quizzator.Dtos;

namespace Quizzator.API_REST.Profile
{
    public class ThemeProfile : AutoMapper.Profile
    {
        public ThemeProfile()
        {
            CreateMap<ThemeExEntity, ThemeDtos>().ReverseMap();
            CreateMap<QuestionEntity, QuestionDtos>().ReverseMap();
            CreateMap<ReponseEntity, ReponseDtos>().ReverseMap();
            CreateMap<LinksEntity, LinkDtos>().ReverseMap();

        }
    }
}

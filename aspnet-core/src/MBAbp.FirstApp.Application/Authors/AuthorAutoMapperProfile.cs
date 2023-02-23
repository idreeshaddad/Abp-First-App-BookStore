using AutoMapper;

namespace MBAbp.FirstApp.Authors
{
    public class AuthorAutoMapperProfile : Profile
    {
        public AuthorAutoMapperProfile()
        {
            CreateMap<Author, AuthorDto>();
        }
    }
}

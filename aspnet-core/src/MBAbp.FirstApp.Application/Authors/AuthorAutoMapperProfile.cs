using AutoMapper;
using MBAbp.FirstApp.Books;

namespace MBAbp.FirstApp.Authors
{
    public class AuthorAutoMapperProfile : Profile
    {
        public AuthorAutoMapperProfile()
        {
            CreateMap<Author, AuthorDto>();
            CreateMap<Author, AuthorLookupDto>();
        }
    }
}

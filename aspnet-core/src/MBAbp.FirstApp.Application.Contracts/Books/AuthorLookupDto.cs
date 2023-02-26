using System;
using Volo.Abp.Application.Dtos;

namespace MBAbp.FirstApp.Books
{
    public class AuthorLookupDto : EntityDto<Guid>
    {
        public string Name { get; set; }
    }
}

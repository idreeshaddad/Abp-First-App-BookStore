using Volo.Abp.Application.Dtos;

namespace MBAbp.FirstApp.Authors
{
    public class GetAuthorListDto : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}

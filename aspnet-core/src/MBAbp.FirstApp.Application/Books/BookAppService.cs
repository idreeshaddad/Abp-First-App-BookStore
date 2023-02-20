using MBAbp.FirstApp.Permissions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace MBAbp.FirstApp.Books
{
    public class BookAppService :
        CrudAppService<Book, BookDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateBookDto>,
        IBookAppService
    {
        private readonly IRepository<Book, Guid> bookRepository;

        public BookAppService(IRepository<Book, Guid> bookRepository) : base(bookRepository)
        {
            GetPolicyName = FirstAppPermissions.Books.Default;
            GetListPolicyName = FirstAppPermissions.Books.Default;
            CreatePolicyName = FirstAppPermissions.Books.Create;
            UpdatePolicyName = FirstAppPermissions.Books.Edit;
            DeletePolicyName = FirstAppPermissions.Books.Delete;
            this.bookRepository = bookRepository;
        }

        public override async Task<PagedResultDto<BookDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            await CheckGetListPolicyAsync();
           
            var books = await bookRepository.GetListAsync();

            var bookDtos = ObjectMapper.Map<List<Book>,List<BookDto>>(books);

            var pagedResultDto = new PagedResultDto<BookDto>();
            pagedResultDto.Items = bookDtos;
            pagedResultDto.TotalCount = bookDtos.Count;

            return pagedResultDto;
        }
    }
}

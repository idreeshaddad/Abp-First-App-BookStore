using System.Threading.Tasks;
using MBAbp.FirstApp;
using MBAbp.FirstApp.Books;
using Shouldly;
using Volo.Abp.Application.Dtos;
using Xunit;

namespace Acme.FirstApp.Books;

public class BookAppService_Tests : FirstAppApplicationTestBase
{
    private readonly IBookAppService _bookAppService;

    public BookAppService_Tests()
    {
        _bookAppService = GetRequiredService<IBookAppService>();
    }

    [Fact]
    public async Task Should_Get_List_Of_Books()
    {
        //Act
        var result = await _bookAppService.GetListAsync(
            new PagedAndSortedResultRequestDto()
        );

        //Assert
        result.TotalCount.ShouldBeGreaterThan(0);
        result.Items.ShouldContain(b => b.Name == "1984");
    }
}

using MBAbp.FirstApp;
using Volo.Abp;

namespace MBAbp.FirstApp.Authors;

public class AuthorAlreadyExistsException : BusinessException
{
    public AuthorAlreadyExistsException(string name)
        : base(FirstAppDomainErrorCodes.AuthorAlreadyExists)
    {
        WithData("name", name);
    }
}

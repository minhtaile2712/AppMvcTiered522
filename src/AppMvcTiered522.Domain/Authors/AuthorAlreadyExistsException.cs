using Volo.Abp;

namespace AppMvcTiered522.Authors;

public class AuthorAlreadyExistsException : BusinessException
{
    public AuthorAlreadyExistsException(string name)
        : base(AppMvcTiered522DomainErrorCodes.AuthorAlreadyExists)
    {
        WithData("name", name);
    }
}

using AppMvcTiered522.Permissions;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AppMvcTiered522.Books;

public class BookAppService :
    CrudAppService<
        Book, //The Book entity
        BookDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateBookDto>, //Used to create/update a book
    IBookAppService //implement the IBookAppService
{
    public BookAppService(
        IRepository<Book, Guid> repository
    ) : base(repository)
    {
        GetPolicyName = AppMvcTiered522Permissions.Books.Default;
        GetListPolicyName = AppMvcTiered522Permissions.Books.Default;
        CreatePolicyName = AppMvcTiered522Permissions.Books.Create;
        UpdatePolicyName = AppMvcTiered522Permissions.Books.Edit;
        DeletePolicyName = AppMvcTiered522Permissions.Books.Delete;
    }
}

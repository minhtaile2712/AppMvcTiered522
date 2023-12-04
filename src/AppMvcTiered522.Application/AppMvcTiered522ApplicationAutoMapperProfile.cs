using AppMvcTiered522.Authors;
using AppMvcTiered522.Books;
using AutoMapper;

namespace AppMvcTiered522;

public class AppMvcTiered522ApplicationAutoMapperProfile : Profile
{
    public AppMvcTiered522ApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<Author, AuthorDto>();

        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
    }
}

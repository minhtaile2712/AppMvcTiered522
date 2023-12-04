using System;
using Volo.Abp.Application.Dtos;

namespace AppMvcTiered522.Authors;

public class AuthorDto : EntityDto<Guid>
{
    public string Name { get; set; }

    public DateTime BirthDate { get; set; }

    public string ShortBio { get; set; }
}

using Volo.Abp.Application.Dtos;

namespace AppMvcTiered522.Authors;

public class GetAuthorListDto : PagedAndSortedResultRequestDto
{
    public string Filter { get; set; }
}

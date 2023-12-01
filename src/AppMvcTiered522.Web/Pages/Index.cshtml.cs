using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace AppMvcTiered522.Web.Pages;

public class IndexModel : AppMvcTiered522PageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}

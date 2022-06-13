using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Logbog.Pages
{
  public class IndexModel : PageModel
  {
    public readonly string Src = "https://docs.google.com/document/d/e/2PACX-1vQKNGrFal348LsGNdnyECgMFe2J1NsPWLMMAtn19tGdMAr9TafDj8X6eqJ1pGXvNfBZn2cBVXgr3XgH/pub?embedded=true";
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
      _logger = logger;
    }

    public void OnGet()
    {

    }
  }
}
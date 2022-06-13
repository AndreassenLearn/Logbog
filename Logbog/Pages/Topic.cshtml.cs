using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Logbog.Pages
{
  [BindProperties]
  public class TopicModel : PageModel
  {
    public Topic Topic { get; set; } = new Topic();

    public void OnGet(ushort m, ushort? s, ushort? ss)
    {
      Topic = TopicService.GetTopic(m, s, ss);
    }
  }
}

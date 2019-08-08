using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BOP.Pages
{
    public class IndexModel : PageModel
    {
        public IActionResult OnGet()
        {
            return new RedirectResult("/Startseite");
        }
    }
}
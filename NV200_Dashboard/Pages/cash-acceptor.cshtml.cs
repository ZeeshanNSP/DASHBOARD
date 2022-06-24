using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NV200_Dashboard.Pages
{
    public class cash_acceptorModel : PageModel
    {
        public string? Message { get; set; }
        public void OnGet()
        {
            this.Message = "Accepting Cash";
        }
    }
}

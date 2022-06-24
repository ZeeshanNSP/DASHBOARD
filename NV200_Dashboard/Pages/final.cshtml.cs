using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NV200_Dashboard.Pages
{
    public class finalModel : PageModel
    {
        public string? Message { get; set; }
        public void OnGet()
        {
            this.Message = "Successfully Transferred Amount";
        }
    }
}

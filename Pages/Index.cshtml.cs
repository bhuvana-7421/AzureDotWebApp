using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AzureDotNetApp.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; private set; } = "Hello, Azure from .NET!";

        public void OnGet()
        {
            Message = "Welcome to my first .NET app deployed on Azure!";
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AvogatoWizardWhisker.github.io.Pages.BlogsContents
{
    public class OnlineProtectionModel : PageModel
    {
        private readonly ILogger<OnlineProtectionModel> _logger;
        
        public OnlineProtectionModel(ILogger<OnlineProtectionModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}

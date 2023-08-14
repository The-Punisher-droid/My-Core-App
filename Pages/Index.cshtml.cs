using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace MyCoreApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            string dateTime = DateTime.Now.ToString("d", new CultureInfo("en-US"));
            ViewData[nameof(dateTime)] = dateTime;
        }
    }
}
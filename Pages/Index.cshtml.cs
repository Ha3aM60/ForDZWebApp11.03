using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ForDZWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public char randomLetter { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Random random = new Random();
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            randomLetter = alphabet[random.Next(alphabet.Length)];

        }
    }
}
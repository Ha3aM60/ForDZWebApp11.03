using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ForDZWebApp.Pages
{
    public class Country
    {
        public string Name { get; set; }
        public string Population { get; set; }
        public string Language { get; set; }
        public string Capital { get; set; }
    }
    public class Task5PageModel : PageModel
    {
        public List<Country> country = new List<Country>();
        public void OnGet()
        {
            country = new List<Country>{
                new Country { Name = "Україна", Population = "42 238 000", Language = "українська", Capital = "Київ" },
                new Country { Name = "Німеччина", Population = "83 190 556", Language = "німецька", Capital = "Берлін" },
                new Country { Name = "Франція", Population = "67 408 000", Language = "французька", Capital = "Париж" }
            };
        
        }
    }
}

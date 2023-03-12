using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ForDZWebApp.Pages
{
    
    public class Restaurant
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public string HoursOfOperation { get; set; }
    }
    public class Index1Model : PageModel
    {
        public List<Restaurant> restaurants = new List<Restaurant>();
        public void OnGet()
        {


            restaurants = new List<Restaurant>{
                new Restaurant() { Name = "Restaurant 1", Address = "Address 1", Phone = "123-456-7890", Website = "www.restaurant1.com", HoursOfOperation = "Mon-Fri 11am-10pm" },
                new Restaurant() { Name = "Restaurant 2", Address = "Address 2", Phone = "123-456-7891", Website = "www.restaurant2.com", HoursOfOperation = "Mon-Sat 11am-11pm" },
                new Restaurant() { Name = "Restaurant 3", Address = "Address 3", Phone = "123-456-7892", Website = "www.restaurant3.com", HoursOfOperation = "Mon-Sun 12pm-9pm" },
            };
        }
    }
}

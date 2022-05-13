using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstWebApp032022.Pages.Pets
{
    public class CatModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int Age { get; set; }

        [BindProperty(SupportsGet = true)]
        public bool IsVaccinated { get; set; }

        public IActionResult OnGet()
        {
            //string? dogUrl = Url.Page("/Pets/Dog",
            //    new
            //    {
            //        Breed = "Cat",
            //        Age = 3,
            //        IsVaccinated = false
            //    });
            //return Redirect(dogUrl);

            //return Redirect("https://google.com");
            //return RedirectToPage("/Pets/Dog", 
            //    new 
            //    { 
            //        Breed = "Cat", 
            //        Age = 3, 
            //        IsVaccinated = false
            //    });

            return Page();
        }
    }
}

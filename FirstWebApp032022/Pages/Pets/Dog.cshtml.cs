using FirstWebApp032022.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstWebApp032022.Pages
{
    public class DogModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public Dog? Dog { get; set; }

        

        
        public bool IsModelValid { get; private set; }


        public void OnGet()
        {
            DateTime time = DateTime.Now;

            ViewData["RequestType"] = "GET";

            IsModelValid = ModelState.IsValid;

        }

        public void OnPost()
        {
            ViewData["RequestType"] = "POST";

            IsModelValid = ModelState.IsValid;
        }
    }
}

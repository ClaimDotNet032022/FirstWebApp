using FirstWebApp032022.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstWebApp032022.Pages.Pets
{
    public class DogListModel : PageModel
    {
        public List<Dog> Dogs = new List<Dog>
        {
            new Dog()
            {
                Name = "Rover",
                Age = 2,
                Color = "Red",
                IsVaccinated = true,
                Breed = "Terrier"
            },
            new Dog()
            {
                Name = "Rex",
                Age = 12,
                Color = "Yellow",
                IsVaccinated = true,
                Breed = "Retriever"
            },
            new Dog()
            {
                Name = "Spot",
                Age = 1,
                Color = "Brown",
                IsVaccinated = false,
                Breed = "Chihuahua"
            },
            new Dog()
            {
                Name = "Spike",
                Age = 3,
                Color = "White",
                IsVaccinated = false,
                Breed = "Mutt"
            },
            new Dog()
            {
                Name = "Rascal",
                Age = 3,
                Color = "Black",
                IsVaccinated = true,
                Breed = "Labrador"
            },
        };



        public void OnGet()
        {
        }
    }
}

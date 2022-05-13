using System.ComponentModel.DataAnnotations;

namespace FirstWebApp032022.Data.Models
{
    public class Dog
    {
        [Display(Name = "Dog Name")]
        public string? Name { get; set; }

        [Display(Name = "Breed or Variety")]
        public string? Breed { get; set; }
        public string? Color { get; set; }
        public int Age { get; set; }

        [Display(Name = "Vaccinated?")]
        public bool IsVaccinated { get; set; }
    }
}

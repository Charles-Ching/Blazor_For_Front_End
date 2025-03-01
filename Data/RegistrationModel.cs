using System.ComponentModel.DataAnnotations;
namespace EventEase.Data
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email address is required")]
        public string Email { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using LoginRegister.Models.Attributes;


namespace LoginRegister.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "User is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [InvalidCharacters(ErrorMessage = "Password Invalido")]
        public string Password { get; set;}
    }
}

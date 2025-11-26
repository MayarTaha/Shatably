using System.ComponentModel.DataAnnotations;

namespace Shatably.DTO
{
    public class SignupDTO
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}

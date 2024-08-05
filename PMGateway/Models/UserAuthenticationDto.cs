using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PMGateway.Models
{
    public class UserAuthenticationDto:IdentityUser
    {
        [Required(ErrorMessage = "Email is required.")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        public string? Password { get; set; }
    }
}

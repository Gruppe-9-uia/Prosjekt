
using System.ComponentModel.DataAnnotations;

namespace Prosjekt.Models
{
    public class LoginModell
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
namespace Prosjekt.Models
{
    public class LoginModel
    {
        [Required]
        public string Email_str { get;set; }
        [Required]
        public string Password_str { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}

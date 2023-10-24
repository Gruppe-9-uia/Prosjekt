

namespace Prosjekt.Models
{
    public class LoginModell
    {
        public LoginModell(int id, string username, string passord)
        {
            Id = id;
            Username = username;
            Passord = passord;
        }

        public int Id { get; set; }
        public required string Username { get; set; }
        public required string Passord { get; set; }
    }
}

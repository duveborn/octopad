namespace OctoPad.Models
{
    public class LoginCredentials
    {
        public string Server { get; set; }
        public string ApiKey { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public AuthenticationMethod AuthenticationMethod { get; set;}
    }
}
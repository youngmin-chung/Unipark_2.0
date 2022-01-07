using serverapp.Models;

namespace serverapp.DTOs
{
    public class UserDTO
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public UserMode CurrentUserMode { get; set; }
        public string Token { get; set; }
    }
}

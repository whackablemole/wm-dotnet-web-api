namespace SuperHeroAPI
{
    public class UserDto
    {
        public string Username { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;

        public int RoleId { get; set; } = 1; // Member
    }
}

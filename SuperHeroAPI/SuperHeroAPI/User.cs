using System.Data;
using System.ComponentModel.DataAnnotations;

namespace SuperHeroAPI
{
    public class User
    {
        [Key]
        public string Username { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public virtual Role Role { get; set; }
    }
}

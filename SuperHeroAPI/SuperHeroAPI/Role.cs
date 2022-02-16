using System.ComponentModel.DataAnnotations;

namespace SuperHeroAPI
{
    public class Role
    {
        public int RoleId { get; set; }
        public string Name { get; set; } = string.Empty;

    }
}

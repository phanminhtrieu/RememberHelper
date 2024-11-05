using rmbh.Entity.Enums;

namespace rmbh_backoffice.MVC.Models.Dtos.Users
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public byte[]? Avatar { get; set; }
        public string? FisrtName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set;}
        public string? Bio { get; set;}
        public ClassRole ClassRole { get; set; }
        public UserRole Role { get; set;}
        public DateTime LastLearningDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

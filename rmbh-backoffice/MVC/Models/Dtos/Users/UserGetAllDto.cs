using rmbh.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rmbh_backoffice.MVC.Models.Dtos.Users
{
    public class UserGetAllDto
    {
        public Guid Id { get; set; }
        public byte[]? Avatar { get; set; }
        public string? FisrtName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Bio { get; set; }
        public UserRole Role { get; set; }
        public DateTime LastLearningDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

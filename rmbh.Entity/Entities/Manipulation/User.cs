using rmbh.Entity.Enums;
using rmbh.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace rmbh.Entity.Entities.Manipulation
{
    public class User :  IHasDateTracking
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public byte[]? Avatar { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? SchoolName { get; set; }
        public string? Bio { get; set; }
        public string? Password { get; set; }
        public UserRole Role { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public ICollection<UserClass>? UserClasses { get; set; }
        public ICollection<UserTeam>? UserTeams { get; set; }
    }
}

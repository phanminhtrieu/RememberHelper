using rmbh.Entity.Entities.Manipulation;
using rmbh.Entity.Enums;

namespace rmbh_backoffice.MVC.Models.Dtos.Classes
{
    public class ClassDto
    {
        public int? Id { get; set; }
        public byte[]? Logo { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Owner { get; set; }
        public ClassRole Role { get; set; }
        public ClassVisibility Visibility { get; set; }
        public DateTime LastLearningDate { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

using rmbh.Entity.Enums;

namespace rmbh_backoffice.MVC.Models.Dtos.Classes
{
    public class ClassRequest
    {
        public Guid CreatedUserId { get; set; }
        public int? Id { get; set; }
        public byte[]? Logo { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Owner { get; set; }
        public ClassVisibility Visibility { get; set; }
        public DateTime LastLearningDate { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

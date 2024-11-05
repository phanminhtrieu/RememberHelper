using rmbh.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rmbh_backoffice.MVC.Models.Dtos.Decks
{
    public class DeckRequest
    {
        public int Id { get; set; } 
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int SortOrder { get; set; }
        public StudyDeckType StudyDeckType { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ClassId { get; set; }
    }
}

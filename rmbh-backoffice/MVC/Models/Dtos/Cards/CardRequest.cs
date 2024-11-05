using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rmbh_backoffice.MVC.Models.Dtos.Cards
{
    public class CardRequest
    {
        public string? Question { get; set; }
        public string? Answer { get; set; }
        public string? QuestionClarifier { get; set; }
        public string? AnswerClarifier { get; set; }
        public string? QuestionFootnote { get; set; }
        public string? AnswerFootnote { get; set; }
        public int? SortOrder { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? CreatedUserName { get; set; }
        public string? ModifiedUserName { get; set; }
        public string? DeckName { get; set; }
    }
}

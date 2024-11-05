using rmbh.Entity.Entities.Manipulation;
using rmbh_backoffice.MVC.Models.Dtos.Cards;
using rmbh_backoffice.MVC.Models.Dtos.Decks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rmbh_backoffice.MVC.Views.Learning.Card
{
    public partial class CardAddModal : Form
    {
        public CardRequest CardRequest { get; set; } = new CardRequest();
        public ComboBox ComboBoxDeck => comboBox_Deck;

        public CardAddModal()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            DeckDto deck = (DeckDto)comboBox_Deck.SelectedItem;
            CardRequest.DeckId = deck.Id;
            CardRequest.Question = textBox_Question.Text;
            CardRequest.Answer = textBox_Answer.Text;
            CardRequest.QuestionClarifier = textBox_QuestionClarifier.Text;
            CardRequest.AnswerClarifier = textBox_QuestionClarifier.Text;
            CardRequest.QuestionFootnote = textBox_QuestionFootnote.Text;
            CardRequest.AnswerFootnote = textBox_AnswerFootnote.Text;
            CardRequest.CreatedDate = dateTimePicker_CreatedDate.Value;
            CardRequest.ModifiedDate = dateTimePicker_ModifiedDate.Value;

            this.DialogResult = DialogResult.OK; // Thiết lập kết quả modal là OK

            DialogResult result = MessageBox.Show(
                "Do you want to create a card?",
                "Create Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void CardAddModal_Load(object sender, EventArgs e)
        {
            dateTimePicker_CreatedDate.Value = DateTime.Now;
            dateTimePicker_ModifiedDate.Value = DateTime.Now;
        }
    }
}

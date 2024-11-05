using rmbh_backoffice.MVC.Models.Dtos.Cards;
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

        private void textBox_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Add_Click(object sender, EventArgs e)
        {

        }

        private void CardAddModal_Load(object sender, EventArgs e)
        {
            //comboBox_Deck.DataSource = 
        }
    }
}

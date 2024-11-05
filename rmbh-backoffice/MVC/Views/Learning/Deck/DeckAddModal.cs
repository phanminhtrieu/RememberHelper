using rmbh.Entity.Enums;
using rmbh_backoffice.MVC.Models.Dtos.Classes;
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

namespace rmbh_backoffice.MVC.Views.Learning.Deck
{
    public partial class DeckAddModal : Form
    {
        public DeckRequest DeckRequest { get; set; } = new DeckRequest();
        public ComboBox ComboBoxStudyMode => comboBox_StudyMode;
        public ComboBox ComboBoxClassTitle => comboBox_ClassTitle;

        public DeckAddModal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void DeckAddModal_Load(object sender, EventArgs e)
        {
            comboBox_StudyMode.DataSource = Enum.GetValues(typeof(StudyDeckType));
            //comboBox_ClassTitle.DataSource = 

            dateTimePicker_CreatedDate.Value = DateTime.Now;
            dateTimePicker_ModifiedDate.Value = DateTime.Now;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Are you sure you want to exit? Unsaved changes will be lost!",
               "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            ClassDto classDto = (ClassDto)comboBox_ClassTitle.SelectedItem;
            DeckRequest.Title = textBox_Title.Text;
            DeckRequest.Description = textBox_Description.Text;
            DeckRequest.SortOrder = Convert.ToInt32(textBox_SortOrder.Text);
            DeckRequest.StudyDeckType = (StudyDeckType)comboBox_StudyMode.SelectedItem;
            DeckRequest.ClassId = classDto.Id;
            DeckRequest.CreatedDate = dateTimePicker_CreatedDate.Value;
            DeckRequest.ModifiedDate = dateTimePicker_ModifiedDate.Value;

            this.DialogResult = DialogResult.OK; // Thiết lập kết quả modal là OK

            DialogResult result = MessageBox.Show(
                "Do you want to create a deck?",
                "Create Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void comboBox_ClassTitle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Title_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}

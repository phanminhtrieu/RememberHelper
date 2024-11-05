using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using rmbh.Entity;
using System.Data;

namespace rmbh_backoffice.MVC.Views.Learning.Card
{
    public partial class CardView : BaseChildForm, IView
    {
        public Button AddButton => button_Add;
        public TextBox TextBoxSearching => textBox_Searching;
        public DataGridView DataGridView => dataGridView;

        public Form Form
        {
            get
            {
                return this;
            }
        }

        public string Title
        {
            get
            {
                return Text;
            }

            set
            {
                Text = value;
            }
        }

        public CardView()
        {
            InitializeComponent();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

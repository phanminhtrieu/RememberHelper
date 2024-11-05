
namespace rmbh_backoffice.MVC.Views.Learning.Deck
{
    public partial class DeckView : BaseChildForm, IView
    {
        public Button AddButton => button_Add; 
        public TextBox TextBox => textBox_Searching;
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

        

        public DeckView()
        {
            InitializeComponent();
        }

        private void panel_Operation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Add_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Searching_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

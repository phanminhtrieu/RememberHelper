namespace rmbh_backoffice.MVC.Views.Learning.Card
{
    public partial class CardView : BaseChildForm, IView
    {
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

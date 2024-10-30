namespace rmbh_backoffice.MVC.Views.Learning.Deck
{
    public partial class DeckView : BaseChildForm, IView
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

        public DeckView()
        {
            InitializeComponent();
        }
    }
}

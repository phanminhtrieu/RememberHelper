namespace rmbh_backoffice.MVC.Views.User
{
    public partial class UserView : BaseChildForm, IView
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

        public UserView()
        {
            InitializeComponent();
        }
    }
}

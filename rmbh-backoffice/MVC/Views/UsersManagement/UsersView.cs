namespace rmbh_backoffice.MVC.Views.UsersManagement
{
    public partial class UsersView : Form, IView
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

        public UsersView()
        {
            InitializeComponent();
        }
    }
}

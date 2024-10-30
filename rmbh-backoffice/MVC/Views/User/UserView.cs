namespace rmbh_backoffice.MVC.Views.User
{
    public partial class UserView : BaseChildForm, IView
    {
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

        public UserView()
        {
            InitializeComponent();
        }

        private void UserView_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}

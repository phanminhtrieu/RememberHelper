namespace rmbh_backoffice.MVC.Views.User
{
    public partial class UserView : BaseChildForm, IView
    {
        public DataGridView DataGridView => dataGridView;
        public TextBox TextBoxSearching => textBox_Searching;
        public Button AddButton => button_Add;

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

        private void textBox_Searching_TextChanged(object sender, EventArgs e)
        {
            //string searchValue = textBox_Search.Text.ToLower();
            //var filteredUsers = _userService.GetAll().Where(user =>
            //    user.Name.ToLower().Contains(searchValue) ||
            //    user.Email.ToLower().Contains(searchValue) ||
            //    user.PhoneNumber.ToLower().Contains(searchValue)).ToList();

            //_userView.DataGridView.DataSource = filteredUsers; // Cập nhật DataSource với danh sách đã lọc
        }

        private void button_Add_Click(object sender, EventArgs e)
        {

        }
    }
}
